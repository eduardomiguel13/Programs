Public Class Tribo
    Dim user As Integer
    Dim username As String
    Dim Generator As System.Random = New System.Random()

    Public Sub site(ByVal link As String)
        WebBrowser1.Navigate(link)
    End Sub

    Public Sub mail(ByVal mail As String)
        TextBox3.Text = mail
    End Sub
    Public Sub gerar(ByVal user As String)
        TextBox1.Text = user
        TextBox2.Text = "pass" & user
    End Sub

    Public Sub inserir()
        WebBrowser1.Document.GetElementById("register_username").InnerText = TextBox1.Text
        WebBrowser1.Document.GetElementById("register_password").InnerText = TextBox2.Text
        WebBrowser1.Document.GetElementById("register_email").InnerText = TextBox3.Text
        WebBrowser1.Document.GetElementById("terms").InvokeMember("click")
        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("a")
            If Element.OuterHtml.Contains("btn-register") Then
                Element.InvokeMember("click")
            End If
        Next
        wait(2)
        email.Show()
        email.validar()
        WebBrowser1.Navigate("https://www.tribalwars.com.pt/page/join/pt60")
        wait(1)
        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("button")
            If Element.OuterHtml.Contains("btn") Then
                Element.InvokeMember("click")
            End If
        Next
        wait(1)
        UtilizadorTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inserir()
    End Sub

    Private Sub Tribos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MultisDataSet.Utilizador' table. You can move, or remove it, as needed.
        Me.UtilizadorTableAdapter.Fill(Me.MultisDataSet.Utilizador)
        WebBrowser1.Navigate(Form1.convite)

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UtilizadorTableAdapter.InsertQuery(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub
End Class