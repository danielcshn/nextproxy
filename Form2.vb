Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class Form2
    Private Property pageready As Boolean = False
    Private trd As Thread
    Dim count As Integer = 0
    Dim linea As String = ""

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbHideMyAss.ForeColor = Color.Black
        cbHideMyName.ForeColor = Color.Black
        cbNNTIME.ForeColor = Color.Black
        cbPremProxy.ForeColor = Color.Black
        cbFreeProxyList2.ForeColor = Color.Black
        cbSpysru.ForeColor = Color.Black
        cbGatherProxy.ForeColor = Color.Black
        cbHTTPtunnel.ForeColor = Color.Black
        cbProxyNova.ForeColor = Color.Black

        Me.Cursor = Cursors.AppStarting
        Progress.Maximum = 0
        ' ProgressBar Total
        If cbHideMyAss.Checked = True Then
            Progress.Maximum = Progress.Maximum + 10
        End If
        If cbHideMyName.Checked = True Then
            Progress.Maximum = Progress.Maximum + 10
        End If
        If cbNNTIME.Checked = True Then
            Progress.Maximum = Progress.Maximum + 10
        End If
        If cbPremProxy.Checked = True Then
            Progress.Maximum = Progress.Maximum + 10
        End If
        If cbFreeProxyList2.Checked = True Then
            Progress.Maximum = Progress.Maximum + 10
        End If
        If cbSpysru.Checked = True Then
            Progress.Maximum = Progress.Maximum + 10
        End If
        If cbGatherProxy.Checked = True Then
            Progress.Maximum = Progress.Maximum + 10
        End If
        If cbHTTPtunnel.Checked = True Then
            Progress.Maximum = Progress.Maximum + 10
        End If
        If cbProxyNova.Checked = True Then
            Progress.Maximum = Progress.Maximum + 10
        End If

        Button1.Enabled = False
        lbCountProxys.Text = "0"
        Progress.Value = 0
        If cbHideMyAss.Checked = True Then
            WebBrowser1.Navigate("http://proxylist.hidemyass.com/")
            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = ""
            sourceCode = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", ":").Replace$("::::", ":").Replace$(":::", ":")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
            cbHideMyAss.ForeColor = Color.Green
            Progress.Value = Progress.Value + 10
            lbCountProxys.Text = ListView1.Items.Count
        End If
        If cbHideMyName.Checked = True Then
            WebBrowser1.Navigate("https://hidemy.name/es/proxy-list/")
            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = ""
            sourceCode = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", ":")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
            cbHideMyName.ForeColor = Color.Green
            Progress.Value = Progress.Value + 10
            lbCountProxys.Text = ListView1.Items.Count
        End If
        If cbNNTIME.Checked = True Then
            WebBrowser1.Navigate("http://nntime.com/")
            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = ""
            sourceCode = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", ":").Replace$("1:2:3:4:5", "").Replace$("6:7:8:9:10", "").Replace$("11:12:13:14:15", "")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
            cbNNTIME.ForeColor = Color.Green
            Progress.Value = Progress.Value + 10
            lbCountProxys.Text = ListView1.Items.Count
        End If
        If cbFreeProxyList2.Checked = True Then
            WebBrowser1.Navigate("https://free-proxy-list.net/")
            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = ""
            sourceCode = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", ":")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
            cbFreeProxyList2.ForeColor = Color.Green
            Progress.Value = Progress.Value + 10
            lbCountProxys.Text = ListView1.Items.Count
        End If
        If cbSpysru.Checked = True Then
            WebBrowser1.Navigate("http://spys.ru/en/anonymous-proxy-list/")
            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = ""
            sourceCode = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", "-")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
            cbSpysru.ForeColor = Color.Green
            Progress.Value = Progress.Value + 10
            lbCountProxys.Text = ListView1.Items.Count
        End If
        If cbGatherProxy.Checked = True Then
            WebBrowser1.Navigate("http://www.gatherproxy.com/")
            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = ""
            sourceCode = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", ":").Replace$("/", "&&&&")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
            cbGatherProxy.ForeColor = Color.Green
            Progress.Value = Progress.Value + 10
            lbCountProxys.Text = ListView1.Items.Count
        End If
        If cbProxyNova.Checked = True Then
            WebBrowser1.Navigate("https://www.proxynova.com/proxy-server-list/elite-proxies/")
            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = ""
            sourceCode = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$(" ", ":")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
            cbProxyNova.ForeColor = Color.Green
            Progress.Value = Progress.Value + 10
            lbCountProxys.Text = ListView1.Items.Count
        End If
        If cbHTTPtunnel.Checked = True Then
            WebBrowser1.Navigate("http://www.httptunnel.ge/ProxyListForFree.aspx")
            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = ""
            sourceCode = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "").Replace$("2017", "").Replace$(" ", ":").Replace$("/", "&&&&")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
            cbHTTPtunnel.ForeColor = Color.Green
            Progress.Value = Progress.Value + 10
            lbCountProxys.Text = ListView1.Items.Count
        End If
        If cbPremProxy.Checked = True Then
            WebBrowser1.Navigate("https://premproxy.com/proxy/")
            WaitForPageLoad()

            WebBrowser1.Document.ExecCommand("SelectAll", True, vbNull)
            WebBrowser1.Document.ExecCommand("Copy", False, vbNull)
            Dim sourceCode As String = ""
            sourceCode = Clipboard.GetText
            sourceCode = sourceCode.Replace$(vbCrLf, "")
            Dim matches As MatchCollection = Regex.Matches(sourceCode, "\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}")
            For Each m As Match In matches ' Loop over matches.
                For Each c As Capture In m.Captures ' Loop over captures.
                    ListView1.Items.Add(c.Value)
                Next
            Next
            Clipboard.Clear()
            cbPremProxy.ForeColor = Color.Green
            Progress.Value = Progress.Value + 10
            lbCountProxys.Text = ListView1.Items.Count
        End If

        Button1.Enabled = True
        lbCountProxys.Text = ListView1.Items.Count
        Me.Cursor = Cursors.Default
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

    Private Sub cbSelect_CheckedChanged(sender As Object, e As EventArgs) Handles cbSelect.CheckedChanged
        If cbSelect.Checked = True Then
            cbHideMyAss.Checked = True
            cbHideMyName.Checked = True
            cbNNTIME.Checked = True
            cbPremProxy.Checked = True
            cbFreeProxyList2.Checked = True
            cbSpysru.Checked = True
            cbGatherProxy.Checked = True
            cbHTTPtunnel.Checked = True
            cbProxyNova.Checked = True
        Else
            cbHideMyAss.Checked = False
            cbHideMyName.Checked = False
            cbNNTIME.Checked = False
            cbPremProxy.Checked = False
            cbFreeProxyList2.Checked = False
            cbSpysru.Checked = False
            cbGatherProxy.Checked = False
            cbHTTPtunnel.Checked = False
            cbProxyNova.Checked = False
        End If
    End Sub

    Private Sub CheckUplinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckUplinkToolStripMenuItem.Click
        CheckUplinkToolStripMenuItem.Enabled = False
        Progress.Maximum = 100
        Progress.Value = 0
        trd = New Thread(AddressOf ThreadTask)
        trd.IsBackground = True
        trd.Start()
    End Sub

    Private Sub ThreadTask()
        For i As Integer = 0 To ListView1.SelectedItems.Count - 1
            Try
                Dim NewProxy As New WebProxy(Me.ListView1.SelectedItems.Item(i).Text)
                Dim request As WebRequest = WebRequest.Create("https://www.google.com")
                Progress.Value = Progress.Value + 50
                request.Proxy = NewProxy
                request.Timeout = 5000
                Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                If (response.StatusCode = HttpStatusCode.OK) Then
                    Progress.Value = Progress.Value + 50
                    ListView1.Items.Item(i).BackColor = Color.Green
                Else
                    Progress.Value = Progress.Value + 50
                    ListView1.Items.Item(i).BackColor = Color.Red
                End If
            Catch ex As Exception
                Progress.Value = Progress.Value + 50
                ListView1.Items.Item(i).BackColor = Color.Red
            End Try
            CheckUplinkToolStripMenuItem.Enabled = True
        Next
    End Sub

    Public Sub Verify(ProxyList As String)
        Try
            Dim NewProxy As New WebProxy(ProxyList)
            Dim request As WebRequest = WebRequest.Create("https://www.google.com")
            request.Proxy = NewProxy
            request.Timeout = 5000
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            If (response.StatusCode = HttpStatusCode.OK) Then
                MsgBox("ok")
            Else
                MsgBox("no")
            End If
        Catch ex As Exception
            MsgBox("no")
        End Try
    End Sub

    Private Sub CheckAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckAllToolStripMenuItem.Click
        Progress.Maximum = ListView1.Items.Count
        Progress.Value = 0
        linea = ListView1.Items.Item(count).Text
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim NewProxy As New WebProxy(linea)
            Dim request As WebRequest = WebRequest.Create("http://www.google.com")
            request.Proxy = NewProxy
            request.Timeout = 10000
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            If (response.StatusCode = HttpStatusCode.OK) Then
                ListView1.Items.Item(count).BackColor = Color.Green
            Else
                ListView1.Items.Item(count).BackColor = Color.Red
                'request.KeepAlive = False
            End If
        Catch ex As Exception
            ListView1.Items.Item(count).BackColor = Color.Red
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If count = ListView1.Items.Count - 1 Then
            count = 0
            linea = ""
            Progress.Value = ListView1.Items.Count
        Else
            'Increment
            count += 1
            Progress.Value = Progress.Value + 1
            linea = ListView1.Items.Item(count).Text
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub
End Class