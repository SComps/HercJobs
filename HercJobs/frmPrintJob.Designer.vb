<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintJob
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
        outData = New RichTextBox()
        SuspendLayout()
        ' 
        ' outData
        ' 
        outData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        outData.DetectUrls = False
        outData.Font = New Font("r_ansi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        outData.Location = New Point(0, 0)
        outData.Name = "outData"
        outData.Size = New Size(1158, 454)
        outData.TabIndex = 0
        outData.Text = ""
        ' 
        ' frmPrintJob
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1158, 450)
        Controls.Add(outData)
        Name = "frmPrintJob"
        Text = "Print Job Received"
        ResumeLayout(False)
    End Sub

    Friend WithEvents outData As RichTextBox
End Class
