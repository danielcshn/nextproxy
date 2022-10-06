Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1
    Dim dteStart As Date = Nothing
    Dim dteEnd As Date = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", RegistryValueKind.DWord)
        ValueDataGeoCountry()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Timer1.Enabled = True

        dteStart = DateTime.Now

        Dim proxy As String = txtIP.Text

        lbConnection.Text = "Connected!"
        lbtxt1.Text = "Secure: Your internet traffic is encrypted and"
        lbtxt2.Text = "your virtual online identity is private."
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
        dteEnd = DateTime.Now

        Dim proxy As String = txtIP.Text

        lbConnection.Text = "Not connected!"
        lbtxt1.Text = "Warning: Your internet traffic is unencrypted and"
        lbtxt2.Text = "your virtual online identity is exposed."
        lbConnection.ForeColor = Color.Red
        PictureBox1.Image = ImageList1.Images(1)

        lbIPProxy.Text = "***.***.***.***"
        lbCountryProxy.Text = "**"
        'Proxy Enable:
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", RegistryValueKind.DWord)

        Timer1.Enabled = False
    End Sub

    Private Function ValueDataGeoCountry()
        Try
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            ' old: https://ipapi.co/json
            Dim json As String = New System.Net.WebClient().DownloadString("https://ipinfo.io/json")
            Dim parsejson As JObject = JObject.Parse(json)
            Dim ipadd As String = parsejson.SelectToken("ip").ToString()
            Dim country As String = parsejson.SelectToken("country").ToString()
            Dim country_name As String = parsejson.SelectToken("region").ToString() + ", " + parsejson.SelectToken("country").ToString()
            lbIPPublic.Text = ipadd
            lbCountry.Text = country_name
            pbCountry.Image = Image.FromFile("flag\" + LCase(country) + ".png")
            Return Nothing
        Catch
            Return Nothing
        End Try
    End Function

    Private Function ProxyDataGeoCountry(ipproxy As String)
        ' old: https://ipapi.co/json
        Dim URLTOGEO As String = "https://ipinfo.io/" + ipproxy + "/json"

        Try
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Dim json As String = New System.Net.WebClient().DownloadString(URLTOGEO)
            Dim parsejson As JObject = JObject.Parse(json)
            Dim ipadd As String = parsejson.SelectToken("ip").ToString()
            Dim country As String = parsejson.SelectToken("country").ToString()
            Dim country_name As String = parsejson.SelectToken("region").ToString() + ", " + parsejson.SelectToken("country").ToString()
            lbIPProxy.Text = ipadd
            lbCountryProxy.Text = country_name
            pxCountry.Image = Image.FromFile("flag\" + LCase(country) + ".png")
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
            Notify.BalloonTipText = "NextProxy will remain hidden."
            Notify.ShowBalloonTip(10000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' FormClosing disconnect proxy connection.
        Dim proxy As String = txtIP.Text
        lbConnection.Text = "Not connected!"
        lbtxt1.Text = "Warning: Your internet traffic is unencrypted and"
        lbtxt2.Text = "your virtual online identity is exposed."
        lbConnection.ForeColor = Color.Red
        PictureBox1.Image = ImageList1.Images(1)
        lbIPProxy.Text = "***.***.***.***"
        lbCountryProxy.Text = "**"
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", RegistryValueKind.DWord)
        Notify.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeExact()
    End Sub

    Private Sub TimeExact()
        ' Sesion Time Elapsed.
        Dim lngTimeElapsed = DateTime.Now - dteStart
        Dim forTimeElapsed = String.Format("{0:HH:mm:ss}", New DateTime(lngTimeElapsed.Ticks))
        lbSesion.Text = "Sesion Time: " & forTimeElapsed
    End Sub

    Private Sub txtIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIP.KeyPress
        ' txtIP Only Numbers & "." & ":".
        Dim allowedChars As String = ".:"
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False And allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub
End Class
