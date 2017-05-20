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

        lbConnection.Text = "Connected!"
        lbConnection.ForeColor = Color.Green
        PictureBox1.Image = ImageList1.Images(0)

        Dim matches As MatchCollection = Regex.Matches(proxy, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}")
        For Each m As Match In matches ' Loop over matches.
            For Each c As Capture In m.Captures ' Loop over captures.
                lbIPProxy.Text = c.Value
                ProxyDataGeoCountry(c.Value)
            Next
        Next
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

        lbConnection.Text = "Not connected!"
        lbConnection.ForeColor = Color.Red
        PictureBox1.Image = ImageList1.Images(1)

        lbIPProxy.Text = "***.*.*.***"
        'Proxy Enable:
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", RegistryValueKind.DWord)
    End Sub

    Private Function ValueDataGeoCountry()
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
            lbIPPublic.Text = json.SelectToken("ip")
            Dim Code As String = json.SelectToken("country")
            lbCountry.Text = json.SelectToken("country_name")
            pbCountry.Image = Image.FromFile("flag\" + LCase(Code) + ".png")
            Return Nothing
        Catch
            Return Nothing
        End Try
    End Function

    Private Function ProxyDataGeoCountry(ipproxy As String)
        Dim URLTOGEO As String = "http://ipapi.co/" + ipproxy + "/json"
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
            Dim Code As String = json.SelectToken("country")
            lbCountryProxy.Text = json.SelectToken("country_name")
            pxCountry.Image = Image.FromFile("flag\" + LCase(Code) + ".png")
            Return Nothing
        Catch
            Return Nothing
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Notify_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Notify.MouseDoubleClick
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        Notify.Visible = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Notify.Visible = True
            'Notify.Icon = SystemIcons.Application
            Notify.BalloonTipIcon = ToolTipIcon.Info
            Notify.BalloonTipTitle = "NextProxy"
            Notify.BalloonTipText = "Verificador corriendo"
            Notify.ShowBalloonTip(10000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub
End Class
