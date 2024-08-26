<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQueue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        QGrid = New DataGridView()
        IndexDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        pupMenu = New ContextMenuStrip(components)
        SelectFilesToolStripMenuItem = New ToolStripMenuItem()
        ClearListToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        mnuDown = New ToolStripMenuItem()
        mnuUp = New ToolStripMenuItem()
        FilenameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        BindingSource1 = New BindingSource(components)
        btnQueue = New Button()
        btnCancel = New Button()
        dlgFile = New OpenFileDialog()
        CType(QGrid, ComponentModel.ISupportInitialize).BeginInit()
        pupMenu.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' QGrid
        ' 
        QGrid.AllowUserToResizeColumns = False
        QGrid.AutoGenerateColumns = False
        QGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        QGrid.Columns.AddRange(New DataGridViewColumn() {IndexDataGridViewTextBoxColumn, FilenameDataGridViewTextBoxColumn})
        QGrid.DataSource = BindingSource1
        QGrid.Location = New Point(0, 0)
        QGrid.Name = "QGrid"
        QGrid.Size = New Size(706, 371)
        QGrid.TabIndex = 0
        ' 
        ' IndexDataGridViewTextBoxColumn
        ' 
        IndexDataGridViewTextBoxColumn.ContextMenuStrip = pupMenu
        IndexDataGridViewTextBoxColumn.DataPropertyName = "Index"
        IndexDataGridViewTextBoxColumn.HeaderText = "Queue Index"
        IndexDataGridViewTextBoxColumn.Name = "IndexDataGridViewTextBoxColumn"
        ' 
        ' pupMenu
        ' 
        pupMenu.Items.AddRange(New ToolStripItem() {SelectFilesToolStripMenuItem, ClearListToolStripMenuItem, ToolStripMenuItem1, mnuDown, mnuUp})
        pupMenu.Name = "pupMenu"
        pupMenu.Size = New Size(140, 98)
        ' 
        ' SelectFilesToolStripMenuItem
        ' 
        SelectFilesToolStripMenuItem.Name = "SelectFilesToolStripMenuItem"
        SelectFilesToolStripMenuItem.Size = New Size(139, 22)
        SelectFilesToolStripMenuItem.Text = "Select File(s)"
        ' 
        ' ClearListToolStripMenuItem
        ' 
        ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem"
        ClearListToolStripMenuItem.Size = New Size(139, 22)
        ClearListToolStripMenuItem.Text = "Clear List"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(136, 6)
        ' 
        ' mnuDown
        ' 
        mnuDown.Name = "mnuDown"
        mnuDown.Size = New Size(139, 22)
        mnuDown.Text = "Move Down"
        ' 
        ' mnuUp
        ' 
        mnuUp.Name = "mnuUp"
        mnuUp.Size = New Size(139, 22)
        mnuUp.Text = "Move Up"
        ' 
        ' FilenameDataGridViewTextBoxColumn
        ' 
        FilenameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FilenameDataGridViewTextBoxColumn.ContextMenuStrip = pupMenu
        FilenameDataGridViewTextBoxColumn.DataPropertyName = "Filename"
        FilenameDataGridViewTextBoxColumn.HeaderText = "Deck filename"
        FilenameDataGridViewTextBoxColumn.Name = "FilenameDataGridViewTextBoxColumn"
        ' 
        ' BindingSource1
        ' 
        BindingSource1.DataSource = GetType(QueueEntry)
        ' 
        ' btnQueue
        ' 
        btnQueue.Location = New Point(276, 392)
        btnQueue.Name = "btnQueue"
        btnQueue.Size = New Size(75, 23)
        btnQueue.TabIndex = 1
        btnQueue.Text = "Queue"
        btnQueue.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(357, 392)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' dlgFile
        ' 
        dlgFile.FileName = "OpenFileDialog1"
        ' 
        ' frmQueue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(708, 436)
        Controls.Add(btnCancel)
        Controls.Add(btnQueue)
        Controls.Add(QGrid)
        Name = "frmQueue"
        StartPosition = FormStartPosition.CenterParent
        Text = "Reader Queue"
        CType(QGrid, ComponentModel.ISupportInitialize).EndInit()
        pupMenu.ResumeLayout(False)
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents QGrid As DataGridView
    Friend WithEvents btnQueue As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents pupMenu As ContextMenuStrip
    Friend WithEvents SelectFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dlgFile As OpenFileDialog
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents IndexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuDown As ToolStripMenuItem
    Friend WithEvents mnuUp As ToolStripMenuItem
End Class
