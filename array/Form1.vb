Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim strNamaHari(6) As String
        Dim sum As Integer

        strNamaHari(0) = "Ahad"
        strNamaHari(1) = "Isnin"
        strNamaHari(2) = "Selasa"
        strNamaHari(3) = "Rabu"
        strNamaHari(4) = "Khamis"
        strNamaHari(5) = "Jumaat"
        strNamaHari(6) = "Sabtu"

        System.Array.Reverse(strNamaHari)

        For sum = 0 To 6
            ListBox1.Items.Add(strNamaHari(sum))
        Next

    End Sub
End Class
