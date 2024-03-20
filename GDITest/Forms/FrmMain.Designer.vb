<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        lblInfo = New Label()
        btnForm = New Button()
        btnCloseForms = New Button()
        SuspendLayout()
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Location = New Point(12, 18)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(41, 15)
        lblInfo.TabIndex = 0
        lblInfo.Text = "lblInfo"
        ' 
        ' btnForm
        ' 
        btnForm.Location = New Point(146, 9)
        btnForm.Name = "btnForm"
        btnForm.Size = New Size(128, 32)
        btnForm.TabIndex = 2
        btnForm.Text = "Launch Form"
        btnForm.UseVisualStyleBackColor = True
        ' 
        ' btnCloseForms
        ' 
        btnCloseForms.Location = New Point(146, 47)
        btnCloseForms.Name = "btnCloseForms"
        btnCloseForms.Size = New Size(128, 32)
        btnCloseForms.TabIndex = 3
        btnCloseForms.Text = "Close Forms"
        btnCloseForms.UseVisualStyleBackColor = True
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(286, 88)
        Controls.Add(btnCloseForms)
        Controls.Add(btnForm)
        Controls.Add(lblInfo)
        Name = "FrmMain"
        Text = "GDI Test"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents btnForm As Button
    Friend WithEvents btnCloseForms As Button

End Class
