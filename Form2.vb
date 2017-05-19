Imports System.Threading
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form2

    Private Property pageready As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbHideMyAss.Checked = True Then
            WebBrowser1.Navigate("http://proxylist.hidemyass.com/")

            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", ":").Replace$("::::", ":").Replace$(":::", ":")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
        End If
        If cbHideMyName.Checked = True Then
            WebBrowser1.Navigate("https://hidemy.name/es/proxy-list/")

            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", ":")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
        End If
        If cbNNTIME.Checked = True Then
            WebBrowser1.Navigate("http://nntime.com/")

            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", ":").Replace$("1:2:3:4:5", "").Replace$("6:7:8:9:10", "").Replace$("11:12:13:14:15", "")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
        End If
    End Sub

    Private Sub WaitForPageLoad()
        AddHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        While Not pageready
            Application.DoEvents()
        End While
        pageready = False
    End Sub

    Private Sub PageWaiter(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            pageready = True
            RemoveHandler WebBrowser1.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf PageWaiter)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        For i As Integer = 0 To ListView1.SelectedItems.Count - 1
            Form1.txtIP.Text = Me.ListView1.SelectedItems.Item(i).Text
            Form1.btnApply.PerformClick() 'Connect
        Next
    End Sub
End Class