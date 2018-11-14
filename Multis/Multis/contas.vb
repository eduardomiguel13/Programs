Public Class contas
    Private Sub contas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MultisDataSet.Utilizador' table. You can move, or remove it, as needed.
        Me.UtilizadorTableAdapter.Fill(Me.MultisDataSet.Utilizador)

    End Sub
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
    Private Sub Login(ByVal username As String, password As String, mundo As String)
        WebBrowser1.Navigate("www.tribalwars.com.pt/page/logout")
        wait(2)
        WebBrowser1.Document.GetElementById("user").InnerText = username
        WebBrowser1.Document.GetElementById("password").InnerText = password
        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("a")
            If Element.OuterHtml.Contains("btn-login") Then
                Element.InvokeMember("click")
            End If
        Next
        wait(2)
        WebBrowser1.Navigate("www.tribalwars.com.pt/page/play/pt" + mundo)
        wait(2)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login(ComboBox1.Text, TextBox1.Text, 60)
    End Sub
End Class