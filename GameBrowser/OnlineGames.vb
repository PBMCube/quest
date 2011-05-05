﻿Public Class OnlineGames
    Private Const GamesListURL As String = "http://www.textadventures.co.uk/gameslist.xml"
    Private WithEvents m_client As New System.Net.WebClient

    Public Event DataReady()

    Public Class GameData
        Public Name As String
        Public Ref As String
    End Class

    Public Class GameCategory
        Public Title As String
        Public Games As List(Of GameData)
    End Class

    Private m_categories As New List(Of GameCategory)

    Public Sub StartDownloadGameData()
        ' Setting Proxy to Nothing massively speeds up how quickly the data is fetched
        m_client.Proxy = Nothing
        Dim newThread As New System.Threading.Thread(Sub() m_client.DownloadStringAsync(New System.Uri(GamesListURL)))
        newThread.Start()
    End Sub

    Private Sub m_client_DownloadStringCompleted(sender As Object, e As System.Net.DownloadStringCompletedEventArgs) Handles m_client.DownloadStringCompleted
        If e.Error Is Nothing Then
            ProcessXML(e.Result)
        Else
            ' TO DO: Display error message
        End If
    End Sub

    Private Sub ProcessXML(xml As String)
        Dim doc As XDocument = XDocument.Parse(xml)

        m_categories = (From cat In doc.Descendants("category")
                        Select New GameCategory With {
                                .Title = cat.@title,
                                .Games = (From game In cat.Descendants("game")
                                          Select New GameData With {
                                                 .Name = game.@name,
                                                 .Ref = game.@ref
                                          }).ToList()
                         }).ToList()

        RaiseEvent DataReady()
    End Sub

    Public ReadOnly Property Categories As IEnumerable(Of GameCategory)
        Get
            Return m_categories.AsReadOnly()
        End Get
    End Property

End Class
