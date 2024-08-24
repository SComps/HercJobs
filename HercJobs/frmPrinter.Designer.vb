<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinter
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
        OutputList = New ListBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        TextBox1 = New TextBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CheckBox2 = New CheckBox()
        SuspendLayout()
        ' 
        ' OutputList
        ' 
        OutputList.FormattingEnabled = True
        OutputList.ItemHeight = 15
        OutputList.Location = New Point(12, 12)
        OutputList.Name = "OutputList"
        OutputList.Size = New Size(276, 124)
        OutputList.TabIndex = 0
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(12, 142)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(111, 19)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "IBM 1403 Printer"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(12, 167)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(110, 19)
        RadioButton2.TabIndex = 2
        RadioButton2.TabStop = True
        RadioButton2.Text = "IBM 3525 Punch"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 217)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(275, 23)
        TextBox1.TabIndex = 3
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(157, 195)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(130, 19)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "Poll local filesystem"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 199)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 5
        Label1.Text = "Friendly name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 246)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 15)
        Label2.TabIndex = 7
        Label2.Text = "Host or IP (path if local filesystem)"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 264)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(275, 23)
        TextBox2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 295)
        Label3.Name = "Label3"
        Label3.Size = New Size(207, 15)
        Label3.TabIndex = 9
        Label3.Text = "Remote Port (blank if local filesystem)"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(12, 313)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(275, 23)
        TextBox3.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 354)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 10
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(110, 354)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 11
        Button2.Text = "Remove"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(212, 354)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 12
        Button3.Text = "Close"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(157, 143)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(80, 19)
        CheckBox2.TabIndex = 13
        CheckBox2.Text = "Auto print"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' frmPrinter
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(299, 396)
        Controls.Add(CheckBox2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(OutputList)
        Name = "frmPrinter"
        StartPosition = FormStartPosition.CenterParent
        Text = "Output Devices"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OutputList As ListBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox2 As CheckBox
End Class
