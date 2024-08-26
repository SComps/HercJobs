<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnQueue = New Button()
        RunStop = New Button()
        Button1 = New Button()
        DeckList = New ListBox()
        Label1 = New Label()
        SelectedReader = New ComboBox()
        Panel2 = New Panel()
        OutputList = New ListBox()
        Label2 = New Label()
        Button2 = New Button()
        MenuStrip1 = New MenuStrip()
        SetupToolStripMenuItem = New ToolStripMenuItem()
        ConfigureHostsToolStripMenuItem = New ToolStripMenuItem()
        HostsToolStripMenuItem = New ToolStripMenuItem()
        CardReadersToolStripMenuItem = New ToolStripMenuItem()
        PrintersToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        DefaultDevicesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        dlgLoadDeck = New OpenFileDialog()
        LogBox = New RichTextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnQueue)
        Panel1.Controls.Add(RunStop)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DeckList)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(SelectedReader)
        Panel1.Location = New Point(10, 32)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(320, 421)
        Panel1.TabIndex = 0
        ' 
        ' btnQueue
        ' 
        btnQueue.Location = New Point(199, 385)
        btnQueue.Name = "btnQueue"
        btnQueue.Size = New Size(96, 23)
        btnQueue.TabIndex = 3
        btnQueue.Text = "Reader Queue"
        btnQueue.UseVisualStyleBackColor = True
        ' 
        ' RunStop
        ' 
        RunStop.Location = New Point(213, 32)
        RunStop.Margin = New Padding(3, 2, 3, 2)
        RunStop.Name = "RunStop"
        RunStop.Size = New Size(82, 22)
        RunStop.TabIndex = 4
        RunStop.Text = "Pause"
        RunStop.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.Location = New Point(11, 386)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 22)
        Button1.TabIndex = 3
        Button1.Text = "Load Deck"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DeckList
        ' 
        DeckList.AllowDrop = True
        DeckList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DeckList.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DeckList.FormattingEnabled = True
        DeckList.ItemHeight = 12
        DeckList.Location = New Point(11, 66)
        DeckList.Margin = New Padding(3, 2, 3, 2)
        DeckList.Name = "DeckList"
        DeckList.Size = New Size(284, 304)
        DeckList.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 15)
        Label1.TabIndex = 1
        Label1.Text = "Selected Reader"
        ' 
        ' SelectedReader
        ' 
        SelectedReader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SelectedReader.FormattingEnabled = True
        SelectedReader.Location = New Point(11, 32)
        SelectedReader.Margin = New Padding(3, 2, 3, 2)
        SelectedReader.Name = "SelectedReader"
        SelectedReader.Size = New Size(186, 23)
        SelectedReader.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(OutputList)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button2)
        Panel2.Location = New Point(336, 32)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(338, 216)
        Panel2.TabIndex = 1
        ' 
        ' OutputList
        ' 
        OutputList.FormattingEnabled = True
        OutputList.ItemHeight = 15
        OutputList.Location = New Point(3, 36)
        OutputList.Name = "OutputList"
        OutputList.Size = New Size(330, 169)
        OutputList.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 1
        Label2.Text = "Output Devices"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(258, 7)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 0
        Button2.Text = "Pause"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SetupToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(686, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SetupToolStripMenuItem
        ' 
        SetupToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ConfigureHostsToolStripMenuItem, ToolStripMenuItem1, ExitToolStripMenuItem})
        SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        SetupToolStripMenuItem.Size = New Size(49, 20)
        SetupToolStripMenuItem.Text = "Setup"
        ' 
        ' ConfigureHostsToolStripMenuItem
        ' 
        ConfigureHostsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HostsToolStripMenuItem, PrintersToolStripMenuItem, ToolStripMenuItem2, DefaultDevicesToolStripMenuItem})
        ConfigureHostsToolStripMenuItem.Name = "ConfigureHostsToolStripMenuItem"
        ConfigureHostsToolStripMenuItem.Size = New Size(127, 22)
        ConfigureHostsToolStripMenuItem.Text = "Configure"
        ' 
        ' HostsToolStripMenuItem
        ' 
        HostsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CardReadersToolStripMenuItem})
        HostsToolStripMenuItem.Name = "HostsToolStripMenuItem"
        HostsToolStripMenuItem.Size = New Size(155, 22)
        HostsToolStripMenuItem.Text = "Input Devices"
        ' 
        ' CardReadersToolStripMenuItem
        ' 
        CardReadersToolStripMenuItem.Name = "CardReadersToolStripMenuItem"
        CardReadersToolStripMenuItem.Size = New Size(143, 22)
        CardReadersToolStripMenuItem.Text = "Card Readers"
        ' 
        ' PrintersToolStripMenuItem
        ' 
        PrintersToolStripMenuItem.Name = "PrintersToolStripMenuItem"
        PrintersToolStripMenuItem.Size = New Size(155, 22)
        PrintersToolStripMenuItem.Text = "Output Devices"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(152, 6)
        ' 
        ' DefaultDevicesToolStripMenuItem
        ' 
        DefaultDevicesToolStripMenuItem.Enabled = False
        DefaultDevicesToolStripMenuItem.Name = "DefaultDevicesToolStripMenuItem"
        DefaultDevicesToolStripMenuItem.Size = New Size(155, 22)
        DefaultDevicesToolStripMenuItem.Text = "Default Devices"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(124, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(127, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' dlgLoadDeck
        ' 
        dlgLoadDeck.DefaultExt = "jcl"
        dlgLoadDeck.Filter = "JCL Files (*.jcl)|*.jcl|txt Files (*.txt)|*.txt|All Files (*.*)|*.*"
        dlgLoadDeck.OkRequiresInteraction = True
        dlgLoadDeck.RestoreDirectory = True
        dlgLoadDeck.ShowPinnedPlaces = False
        dlgLoadDeck.SupportMultiDottedExtensions = True
        dlgLoadDeck.Title = "Load Deck"
        ' 
        ' LogBox
        ' 
        LogBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        LogBox.Location = New Point(336, 253)
        LogBox.Name = "LogBox"
        LogBox.Size = New Size(338, 200)
        LogBox.TabIndex = 0
        LogBox.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(686, 475)
        Controls.Add(LogBox)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Hercules Jobs"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigureHostsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HostsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CardReadersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents DefaultDevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectedReader As ComboBox
    Friend WithEvents RunStop As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DeckList As ListBox
    Friend WithEvents dlgLoadDeck As OpenFileDialog
    Friend WithEvents LogBox As RichTextBox
    Friend WithEvents OutputList As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnQueue As Button

End Class
