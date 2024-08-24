<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReader
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
        lstReaders = New ListBox()
        txtHost = New TextBox()
        txtPort = New TextBox()
        txtFriendly = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        cmdRemove = New Button()
        cmdSave = New Button()
        cmdClose = New Button()
        SuspendLayout()
        ' 
        ' lstReaders
        ' 
        lstReaders.FormattingEnabled = True
        lstReaders.ItemHeight = 15
        lstReaders.Items.AddRange(New Object() {"<add new reader>"})
        lstReaders.Location = New Point(10, 9)
        lstReaders.Margin = New Padding(3, 2, 3, 2)
        lstReaders.Name = "lstReaders"
        lstReaders.Size = New Size(191, 124)
        lstReaders.TabIndex = 0
        ' 
        ' txtHost
        ' 
        txtHost.Location = New Point(14, 202)
        txtHost.Margin = New Padding(3, 2, 3, 2)
        txtHost.Name = "txtHost"
        txtHost.Size = New Size(219, 23)
        txtHost.TabIndex = 1
        ' 
        ' txtPort
        ' 
        txtPort.Location = New Point(238, 202)
        txtPort.Margin = New Padding(3, 2, 3, 2)
        txtPort.Name = "txtPort"
        txtPort.Size = New Size(70, 23)
        txtPort.TabIndex = 2
        ' 
        ' txtFriendly
        ' 
        txtFriendly.Location = New Point(14, 159)
        txtFriendly.Margin = New Padding(3, 2, 3, 2)
        txtFriendly.Name = "txtFriendly"
        txtFriendly.Size = New Size(219, 23)
        txtFriendly.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 142)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 4
        Label1.Text = "Friendly name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 15)
        Label2.TabIndex = 5
        Label2.Text = "Host or IP address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(238, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 15)
        Label3.TabIndex = 6
        Label3.Text = "Port"
        ' 
        ' cmdRemove
        ' 
        cmdRemove.Location = New Point(238, 9)
        cmdRemove.Margin = New Padding(3, 2, 3, 2)
        cmdRemove.Name = "cmdRemove"
        cmdRemove.Size = New Size(82, 22)
        cmdRemove.TabIndex = 7
        cmdRemove.Text = "Remove"
        cmdRemove.UseVisualStyleBackColor = True
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(238, 42)
        cmdSave.Margin = New Padding(3, 2, 3, 2)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(82, 22)
        cmdSave.TabIndex = 8
        cmdSave.Text = "Save"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' cmdClose
        ' 
        cmdClose.Location = New Point(238, 68)
        cmdClose.Margin = New Padding(3, 2, 3, 2)
        cmdClose.Name = "cmdClose"
        cmdClose.Size = New Size(82, 22)
        cmdClose.TabIndex = 9
        cmdClose.Text = "Close"
        cmdClose.UseVisualStyleBackColor = True
        ' 
        ' frmReader
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(367, 232)
        Controls.Add(cmdClose)
        Controls.Add(cmdSave)
        Controls.Add(cmdRemove)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtFriendly)
        Controls.Add(txtPort)
        Controls.Add(txtHost)
        Controls.Add(lstReaders)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmReader"
        StartPosition = FormStartPosition.CenterParent
        Text = "3505 Card readers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstReaders As ListBox
    Friend WithEvents txtHost As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtFriendly As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdRemove As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdClose As Button
End Class
