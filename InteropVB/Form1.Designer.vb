<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnWord = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnWord
        '
        Me.btnWord.Location = New System.Drawing.Point(36, 117)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(75, 23)
        Me.btnWord.TabIndex = 0
        Me.btnWord.Text = "Word"
        Me.btnWord.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(130, 117)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(36, 57)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(169, 20)
        Me.txtDato.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 180)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnWord)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWord As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents txtDato As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
