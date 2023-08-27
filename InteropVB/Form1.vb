Public Class Form1
    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click

        Dim Word = New Microsoft.Office.Interop.Word.Application
        Dim wordApp = Word.Application()

        Dim ruta, dato As String

        If (SaveFileDialog1.ShowDialog() <> DialogResult.OK) Then
            Return
        End If

        ruta = SaveFileDialog1.FileName
        wordApp.Visible = True

        wordApp.Documents.Add()
        dato = txtDato.Text

        wordApp.Selection.TypeText(dato)
        wordApp.ActiveDocument.SaveAs(ruta)

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        Dim Excel = New Microsoft.Office.Interop.Excel.Application
        Dim excelApp = Excel.Application()

        Dim ruta, dato As String

        If (SaveFileDialog1.ShowDialog() <> DialogResult.OK) Then
            Return
        End If

        ruta = SaveFileDialog1.FileName
        excelApp.Visible = True

        Dim workbook = excelApp.Workbooks.Add()
        Dim worksheet = workbook.ActiveSheet

        worksheet.Cell(1, 1) = txtDato.Text

        workbook.SaveAs(ruta)
    End Sub
End Class
