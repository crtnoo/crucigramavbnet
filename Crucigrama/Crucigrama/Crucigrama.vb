Public Class Crucigrama
    Dim TextBoxArray(10, 10) As TextBox
    Const TxtBoxSize As Integer = 25
    Dim crucigrama(,) As String = {
        {"-", "-", "-", "-", "W", "-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "I", "-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "N", "-", "-", "-", "-", "-"},
        {"-", "-", "-", "-", "D", "-", "-", "-", "-", "-"},
        {"C", "O", "N", "S", "O", "L", "A", "-", "-", "P"},
        {"-", "-", "-", "-", "W", "-", "-", "-", "-", "Y"},
        {"-", "-", "-", "-", "S", "C", "R", "I", "P", "T"},
        {"-", "-", "-", "-", "-", "-", "-", "-", "-", "H"},
        {"-", "-", "-", "-", "-", "-", "-", "-", "-", "O"},
        {"-", "-", "-", "-", "-", "-", "-", "-", "-", "N"}
    }

    Private Sub Crucigrama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        For i = 0 To 9
            For j = 0 To 9
                TextBoxArray(i, j) = New TextBox
                TextBoxArray(i, j).Width = TxtBoxSize
                TextBoxArray(i, j).Height = TxtBoxSize
                TextBoxArray(i, j).AutoSize = False
                TextBoxArray(i, j).MaxLength = 1
                Console.WriteLine(crucigrama(i, j))
                If crucigrama(i, j) <> "-" Then
                    Console.WriteLine("se crea una caja")
                    TextBoxArray(i, j).Location = New Point(TxtBoxSize + j * TxtBoxSize, TxtBoxSize + i * TxtBoxSize)
                    Me.Controls.Add(TextBoxArray(i, j))
                End If
            Next
        Next
    End Sub

    Private Sub ButtonValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonValidar.Click
        'VALIDAR CRUCIGRAMA
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
