﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        RunStop = New Button()
        Button1 = New Button()
        DeckList = New ListBox()
        Label1 = New Label()
        SelectedReader = New ComboBox()
        Panel2 = New Panel()
        MenuStrip1 = New MenuStrip()
        SetupToolStripMenuItem = New ToolStripMenuItem()
        ConfigureHostsToolStripMenuItem = New ToolStripMenuItem()
        HostsToolStripMenuItem = New ToolStripMenuItem()
        CardReadersToolStripMenuItem = New ToolStripMenuItem()
        PrintersToolStripMenuItem = New ToolStripMenuItem()
        PrintersToolStripMenuItem1 = New ToolStripMenuItem()
        PunchesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        DefaultDevicesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        dlgLoadDeck = New OpenFileDialog()
        LogBox = New RichTextBox()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(RunStop)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DeckList)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(SelectedReader)
        Panel1.Location = New Point(10, 32)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(320, 327)
        Panel1.TabIndex = 0
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
        Button1.Location = New Point(11, 292)
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
        DeckList.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DeckList.FormattingEnabled = True
        DeckList.ItemHeight = 12
        DeckList.Location = New Point(11, 66)
        DeckList.Margin = New Padding(3, 2, 3, 2)
        DeckList.Name = "DeckList"
        DeckList.Size = New Size(284, 208)
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
        Panel2.Location = New Point(336, 32)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(338, 145)
        Panel2.TabIndex = 1
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
        ConfigureHostsToolStripMenuItem.Size = New Size(180, 22)
        ConfigureHostsToolStripMenuItem.Text = "Configure"
        ' 
        ' HostsToolStripMenuItem
        ' 
        HostsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CardReadersToolStripMenuItem})
        HostsToolStripMenuItem.Name = "HostsToolStripMenuItem"
        HostsToolStripMenuItem.Size = New Size(180, 22)
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
        PrintersToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PrintersToolStripMenuItem1, PunchesToolStripMenuItem})
        PrintersToolStripMenuItem.Enabled = False
        PrintersToolStripMenuItem.Name = "PrintersToolStripMenuItem"
        PrintersToolStripMenuItem.Size = New Size(180, 22)
        PrintersToolStripMenuItem.Text = "Output Devices"
        ' 
        ' PrintersToolStripMenuItem1
        ' 
        PrintersToolStripMenuItem1.Name = "PrintersToolStripMenuItem1"
        PrintersToolStripMenuItem1.Size = New Size(180, 22)
        PrintersToolStripMenuItem1.Text = "Printers"
        ' 
        ' PunchesToolStripMenuItem
        ' 
        PunchesToolStripMenuItem.Name = "PunchesToolStripMenuItem"
        PunchesToolStripMenuItem.Size = New Size(180, 22)
        PunchesToolStripMenuItem.Text = "Punches"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(177, 6)
        ' 
        ' DefaultDevicesToolStripMenuItem
        ' 
        DefaultDevicesToolStripMenuItem.Enabled = False
        DefaultDevicesToolStripMenuItem.Name = "DefaultDevicesToolStripMenuItem"
        DefaultDevicesToolStripMenuItem.Size = New Size(180, 22)
        DefaultDevicesToolStripMenuItem.Text = "Default Devices"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(177, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
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
        LogBox.Location = New Point(336, 182)
        LogBox.Name = "LogBox"
        LogBox.Size = New Size(338, 177)
        LogBox.TabIndex = 0
        LogBox.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(686, 381)
        Controls.Add(LogBox)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Hercules Jobs"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents PrintersToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PunchesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents DefaultDevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectedReader As ComboBox
    Friend WithEvents RunStop As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DeckList As ListBox
    Friend WithEvents dlgLoadDeck As OpenFileDialog
    Friend WithEvents LogBox As RichTextBox

End Class
