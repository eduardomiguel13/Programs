Public Class email
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Public Sub gerar()
        wait(1)
        WebBrowser1.Document.GetElementById("click-to-delete").InvokeMember("click")
        wait(1)
        Dim ht, mail(), mail2(), mail3() As String
        TextBox1.Text = WebBrowser1.Document.GetElementById("mail").InnerText
        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("input")
            If Element.OuterHtml.Contains("value") Then
                ht = Element.OuterHtml.ToString
            End If
        Next
        mail = ht.Split("=")
        For i = 1 To mail.Length
            mail2 = mail(i - 1).Split(" ")
            For f = 1 To mail2.Length
                If mail2(f - 1) = "value" Then
                    mail3 = mail(i).Split(" ")
                    TextBox1.Text = mail3(0)
                End If
            Next
        Next
        Tribo.Show()
        Tribo.mail(TextBox1.Text)
        Me.Close()
    End Sub

    Public Sub validar()
        wait(2)
        Dim ht, mail(), mail2(), mail3(), mail4() As String
        WebBrowser1.Document.GetElementById("Click-to-refresh").InvokeMember("click")
        wait(2)
        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("a")
            If Element.OuterHtml.Contains("title-subject") Then
                If Element.InnerText.Contains("Tribos - Ativação") Then
                    Element.InvokeMember("click")
                End If
            End If
        Next
        wait(2)
        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("a")
            If Element.OuterHtml.Contains("https://www.tribalwars.com.pt/page/validate/") Then
                ht = Element.OuterHtml.ToString
            End If
        Next
        mail = ht.Split("=")
        For i = 1 To mail.Length
            mail2 = mail(i - 1).Split(" ")
            For f = 1 To mail2.Length
                If mail2(f - 1) = "href" Then
                    mail3 = mail(i).Split(" ")
                    mail4 = mail3(0).Split("/")
                End If
            Next
        Next
        Tribo.Show()
        Tribo.site("https://www.tribalwars.com.pt/page/validate/" + mail4(5) + "/0")
        Me.Close()
    End Sub
    Private Sub mail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://temp-mail.org/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Document.GetElementById("click-to-delete").InvokeMember("click")
        wait(1)
        Dim ht, mail(), mail2(), mail3(), user() As String
        TextBox1.Text = WebBrowser1.Document.GetElementById("mail").InnerText
        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("input")
            If Element.OuterHtml.Contains("value") Then
                ht = Element.OuterHtml.ToString
            End If
        Next
        mail = ht.Split("=")
        For i = 1 To mail.Length
            mail2 = mail(i - 1).Split(" ")
            For f = 1 To mail2.Length
                If mail2(f - 1) = "value" Then
                    mail3 = mail(i).Split(" ")
                    TextBox1.Text = mail3(0)
                End If
            Next
        Next
        Tribo.Show()
        Tribo.mail(TextBox1.Text)
        user = TextBox1.Text.Split("@")
        Tribo.gerar(user(0))
        wait(1)
        Tribo.inserir()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ht, mail(), mail2(), mail3(), mail4() As String
        WebBrowser1.Document.GetElementById("Click-to-refresh").InvokeMember("click")
        wait(2)
        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("a")
            If Element.OuterHtml.Contains("title-subject") Then
                If Element.InnerText.Contains("Tribos - Ativação") Then
                    Element.InvokeMember("click")
                End If
            End If
        Next
        wait(2)
        For Each Element As HtmlElement In WebBrowser1.Document.GetElementsByTagName("a")
            If Element.OuterHtml.Contains("https://www.tribalwars.com.pt/page/validate/") Then
                ht = Element.OuterHtml.ToString
            End If
        Next
        mail = ht.Split("=")
        For i = 1 To mail.Length
            mail2 = mail(i - 1).Split(" ")
            For f = 1 To mail2.Length
                If mail2(f - 1) = "href" Then
                    mail3 = mail(i).Split(" ")
                    mail4 = mail3(0).Split("/")
                End If
            Next
        Next
        Tribo.Show()
        Tribo.site("https://www.tribalwars.com.pt/page/validate/" + mail4(5) + "/0")
    End Sub
End Class