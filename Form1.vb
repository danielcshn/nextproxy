Imports System.Threading
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValueDataGeoCountry()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim proxy As String = txtIP.Text
        lbIPProxy.Text = txtIP.Text
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", Nothing) Is Nothing Then
            My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", proxy)
            'Proxy Enable:
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "1", RegistryValueKind.DWord)
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", proxy)
            'Proxy Enable:
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "1", RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim proxy As String = txtIP.Text
        lbIPProxy.Text = "***.*.*.***"
        'Proxy Enable:
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", RegistryValueKind.DWord)
    End Sub

    Private Function ValueDataGeoCountry()
        ' http://api.wipmania.com/192.232.69.132?k=test&t=json&v=USD
        'Dim URLTOGEO As String = "http://api.wipmania.com/" + lbIPPublic.Text
        Dim URLTOGEO As String = "http://ipapi.co/json"
        Try
            Dim UpdateClient As HttpWebRequest = WebRequest.Create(
            New Uri(URLTOGEO))
            UpdateClient.Timeout = 2500
            Dim response As WebResponse = UpdateClient.GetResponse()
            Dim content As Stream = response.GetResponseStream()
            Dim readstream As New StreamReader(content, Encoding.Default)
            Dim textjson As String = readstream.ReadToEnd
            readstream.Close()
            content.Close()

            Dim json As JObject = JObject.Parse(textjson)
            'MsgBox(json.SelectToken("country"))

            lbIPPublic.Text = json.SelectToken("ip")
            Dim Code As String = json.SelectToken("country")
            lbCountry.Text = json.SelectToken("country_name")
            pbCountry.Image = Image.FromFile("flag\" + LCase(Code) + ".png")

            Return Nothing
        Catch
            Return Nothing
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbCountry_Click(sender As Object, e As EventArgs) Handles lbCountry.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
