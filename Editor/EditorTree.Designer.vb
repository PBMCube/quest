﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorTree
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorTree))
        Me.ctlTreeView = New System.Windows.Forms.TreeView()
        Me.ctlContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddObjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddVerbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddImpliedTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDynamicTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDelegateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddObjectTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctlToolStrip = New System.Windows.Forms.ToolStrip()
        Me.mnuFilter = New System.Windows.Forms.ToolStripDropDownButton()
        Me.pnlSearchContainer = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.lstSearchResults = New System.Windows.Forms.ListView()
        Me.colSearchResults = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AddWalkthroughToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctlContextMenu.SuspendLayout()
        Me.ctlToolStrip.SuspendLayout()
        Me.pnlSearchContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctlTreeView
        '
        Me.ctlTreeView.AllowDrop = True
        Me.ctlTreeView.ContextMenuStrip = Me.ctlContextMenu
        Me.ctlTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctlTreeView.HideSelection = False
        Me.ctlTreeView.Location = New System.Drawing.Point(0, 20)
        Me.ctlTreeView.Name = "ctlTreeView"
        Me.ctlTreeView.Size = New System.Drawing.Size(204, 282)
        Me.ctlTreeView.TabIndex = 4
        '
        'ctlContextMenu
        '
        Me.ctlContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddObjectToolStripMenuItem, Me.AddRoomToolStripMenuItem, Me.AddExitToolStripMenuItem, Me.AddVerbToolStripMenuItem, Me.AddCommandToolStripMenuItem, Me.AddFunctionToolStripMenuItem, Me.AddWalkthroughToolStripMenuItem, Me.AddLibraryToolStripMenuItem, Me.AddImpliedTypeToolStripMenuItem, Me.AddTemplateToolStripMenuItem, Me.AddDynamicTemplateToolStripMenuItem, Me.AddDelegateToolStripMenuItem, Me.AddObjectTypeToolStripMenuItem, Me.AddEditorToolStripMenuItem})
        Me.ctlContextMenu.Name = "ctlContextMenu"
        Me.ctlContextMenu.Size = New System.Drawing.Size(200, 334)
        '
        'AddObjectToolStripMenuItem
        '
        Me.AddObjectToolStripMenuItem.Image = Global.AxeSoftware.Quest.My.Resources.Resources.addobject
        Me.AddObjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddObjectToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.AddObjectToolStripMenuItem.Name = "AddObjectToolStripMenuItem"
        Me.AddObjectToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddObjectToolStripMenuItem.Tag = "addobject"
        Me.AddObjectToolStripMenuItem.Text = "Add Object"
        '
        'AddRoomToolStripMenuItem
        '
        Me.AddRoomToolStripMenuItem.Image = Global.AxeSoftware.Quest.My.Resources.Resources.addroom
        Me.AddRoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddRoomToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver
        Me.AddRoomToolStripMenuItem.Name = "AddRoomToolStripMenuItem"
        Me.AddRoomToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddRoomToolStripMenuItem.Tag = "addroom"
        Me.AddRoomToolStripMenuItem.Text = "Add Room"
        '
        'AddExitToolStripMenuItem
        '
        Me.AddExitToolStripMenuItem.Name = "AddExitToolStripMenuItem"
        Me.AddExitToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddExitToolStripMenuItem.Tag = "addexit"
        Me.AddExitToolStripMenuItem.Text = "Add Exit"
        '
        'AddVerbToolStripMenuItem
        '
        Me.AddVerbToolStripMenuItem.Name = "AddVerbToolStripMenuItem"
        Me.AddVerbToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddVerbToolStripMenuItem.Tag = "addverb"
        Me.AddVerbToolStripMenuItem.Text = "Add Verb"
        '
        'AddCommandToolStripMenuItem
        '
        Me.AddCommandToolStripMenuItem.Name = "AddCommandToolStripMenuItem"
        Me.AddCommandToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddCommandToolStripMenuItem.Tag = "addcommand"
        Me.AddCommandToolStripMenuItem.Text = "Add Command"
        '
        'AddFunctionToolStripMenuItem
        '
        Me.AddFunctionToolStripMenuItem.Name = "AddFunctionToolStripMenuItem"
        Me.AddFunctionToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddFunctionToolStripMenuItem.Tag = "addfunction"
        Me.AddFunctionToolStripMenuItem.Text = "Add Function"
        '
        'AddLibraryToolStripMenuItem
        '
        Me.AddLibraryToolStripMenuItem.Name = "AddLibraryToolStripMenuItem"
        Me.AddLibraryToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddLibraryToolStripMenuItem.Tag = "addlibrary"
        Me.AddLibraryToolStripMenuItem.Text = "Add Library"
        '
        'AddImpliedTypeToolStripMenuItem
        '
        Me.AddImpliedTypeToolStripMenuItem.Name = "AddImpliedTypeToolStripMenuItem"
        Me.AddImpliedTypeToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddImpliedTypeToolStripMenuItem.Tag = "addimpliedtype"
        Me.AddImpliedTypeToolStripMenuItem.Text = "Add Implied Type"
        '
        'AddTemplateToolStripMenuItem
        '
        Me.AddTemplateToolStripMenuItem.Name = "AddTemplateToolStripMenuItem"
        Me.AddTemplateToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddTemplateToolStripMenuItem.Tag = "addtemplate"
        Me.AddTemplateToolStripMenuItem.Text = "Add Template"
        '
        'AddDynamicTemplateToolStripMenuItem
        '
        Me.AddDynamicTemplateToolStripMenuItem.Name = "AddDynamicTemplateToolStripMenuItem"
        Me.AddDynamicTemplateToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddDynamicTemplateToolStripMenuItem.Tag = "adddynamictemplate"
        Me.AddDynamicTemplateToolStripMenuItem.Text = "Add Dynamic Template"
        '
        'AddDelegateToolStripMenuItem
        '
        Me.AddDelegateToolStripMenuItem.Name = "AddDelegateToolStripMenuItem"
        Me.AddDelegateToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddDelegateToolStripMenuItem.Tag = "adddelegate"
        Me.AddDelegateToolStripMenuItem.Text = "Add Delegate"
        '
        'AddObjectTypeToolStripMenuItem
        '
        Me.AddObjectTypeToolStripMenuItem.Name = "AddObjectTypeToolStripMenuItem"
        Me.AddObjectTypeToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddObjectTypeToolStripMenuItem.Tag = "addobjecttype"
        Me.AddObjectTypeToolStripMenuItem.Text = "Add Object Type"
        '
        'AddEditorToolStripMenuItem
        '
        Me.AddEditorToolStripMenuItem.Name = "AddEditorToolStripMenuItem"
        Me.AddEditorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddEditorToolStripMenuItem.Tag = "addeditor"
        Me.AddEditorToolStripMenuItem.Text = "Add Editor"
        '
        'ctlToolStrip
        '
        Me.ctlToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ctlToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFilter})
        Me.ctlToolStrip.Location = New System.Drawing.Point(0, 302)
        Me.ctlToolStrip.Name = "ctlToolStrip"
        Me.ctlToolStrip.Size = New System.Drawing.Size(204, 25)
        Me.ctlToolStrip.TabIndex = 2
        Me.ctlToolStrip.Text = "ToolStrip1"
        '
        'mnuFilter
        '
        Me.mnuFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFilter.Image = CType(resources.GetObject("mnuFilter.Image"), System.Drawing.Image)
        Me.mnuFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFilter.Name = "mnuFilter"
        Me.mnuFilter.Size = New System.Drawing.Size(46, 22)
        Me.mnuFilter.Text = "Filter"
        '
        'pnlSearchContainer
        '
        Me.pnlSearchContainer.Controls.Add(Me.txtSearch)
        Me.pnlSearchContainer.Controls.Add(Me.cmdClose)
        Me.pnlSearchContainer.Controls.Add(Me.cmdSearch)
        Me.pnlSearchContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearchContainer.Name = "pnlSearchContainer"
        Me.pnlSearchContainer.Size = New System.Drawing.Size(204, 20)
        Me.pnlSearchContainer.TabIndex = 3
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(184, 20)
        Me.txtSearch.TabIndex = 1
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.Location = New System.Drawing.Point(164, 0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(20, 20)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.Visible = False
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.Location = New System.Drawing.Point(184, 0)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(20, 20)
        Me.cmdSearch.TabIndex = 3
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'lstSearchResults
        '
        Me.lstSearchResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSearchResults})
        Me.lstSearchResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSearchResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstSearchResults.HideSelection = False
        Me.lstSearchResults.Location = New System.Drawing.Point(0, 20)
        Me.lstSearchResults.MultiSelect = False
        Me.lstSearchResults.Name = "lstSearchResults"
        Me.lstSearchResults.Size = New System.Drawing.Size(204, 282)
        Me.lstSearchResults.TabIndex = 4
        Me.lstSearchResults.UseCompatibleStateImageBehavior = False
        Me.lstSearchResults.View = System.Windows.Forms.View.Details
        Me.lstSearchResults.Visible = False
        '
        'colSearchResults
        '
        Me.colSearchResults.Text = "Search Results"
        '
        'AddWalkthroughToolStripMenuItem
        '
        Me.AddWalkthroughToolStripMenuItem.Name = "AddWalkthroughToolStripMenuItem"
        Me.AddWalkthroughToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddWalkthroughToolStripMenuItem.Tag = "addwalkthrough"
        Me.AddWalkthroughToolStripMenuItem.Text = "Add Walkthrough"
        '
        'EditorTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstSearchResults)
        Me.Controls.Add(Me.ctlTreeView)
        Me.Controls.Add(Me.ctlToolStrip)
        Me.Controls.Add(Me.pnlSearchContainer)
        Me.Name = "EditorTree"
        Me.Size = New System.Drawing.Size(204, 327)
        Me.ctlContextMenu.ResumeLayout(False)
        Me.ctlToolStrip.ResumeLayout(False)
        Me.ctlToolStrip.PerformLayout()
        Me.pnlSearchContainer.ResumeLayout(False)
        Me.pnlSearchContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ctlTreeView As System.Windows.Forms.TreeView
    Friend WithEvents ctlToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuFilter As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents pnlSearchContainer As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lstSearchResults As System.Windows.Forms.ListView
    Friend WithEvents colSearchResults As System.Windows.Forms.ColumnHeader
    Friend WithEvents ctlContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddObjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddVerbToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFunctionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddLibraryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddImpliedTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDynamicTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDelegateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddObjectTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddWalkthroughToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
