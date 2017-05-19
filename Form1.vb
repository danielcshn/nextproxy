Imports System.Threading
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbIPPublic.Text = CheckPublicIP()
        lbCountry.Text = CheckCountryIP()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim proxy As String = txtIP.Text + ":" + txtPort.Text
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim proxy As String = txtIP.Text + ":" + txtPort.Text
        'Proxy Enable:
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyEnable", "0", RegistryValueKind.DWord)
    End Sub

    Private Function CheckPublicIP() As String
        Dim ipRegex As New Regex("[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}", RegexOptions.Singleline)

        Try
            Dim UpdateClient As System.Net.HttpWebRequest = WebRequest.Create(
            New Uri("http://checkip.dyndns.org"))
            UpdateClient.Timeout = 15000
            Dim response As WebResponse = UpdateClient.GetResponse()
            Dim content As Stream = response.GetResponseStream()
            Dim readstream As New StreamReader(content, System.Text.Encoding.Default)
            Dim IpAddress As String = readstream.ReadToEnd
            readstream.Close()
            content.Close()
            If ipRegex.IsMatch(IpAddress) Then
                Return ipRegex.Match(IpAddress).Groups(0).Value
            Else
                Return Nothing
            End If
        Catch
            Return Nothing
        End Try
    End Function

    Private Function CheckCountryIP() As String
        ' http://api.wipmania.com/192.232.69.132?k=test&t=json&v=USD
        Dim URLTOGEO As String = "http://api.wipmania.com/" + lbIPPublic.Text
        Try
            Dim UpdateClient As HttpWebRequest = WebRequest.Create(New Uri(URLTOGEO))
            UpdateClient.Timeout = 15000
            Dim response As WebResponse = UpdateClient.GetResponse()
            Dim content As Stream = response.GetResponseStream()
            Dim readstream As New StreamReader(content, Encoding.Default)
            Dim IpCountry As String = readstream.ReadToEnd
            readstream.Close()
            content.Close()
            Return IpCountry
        Catch
            Return Nothing
        End Try
    End Function
End Class
