Imports System.IO
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
        BackgroundWorker1.WorkerSupportsCancellation = True

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
            Me.BackgroundWorker1.CancelAsync()
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
                    Me.ListView1.SelectedItems.Item(i).BackColor = Color.Green
                Else
                    Progress.Value = Progress.Value + 50
                    Me.ListView1.SelectedItems.Item(i).BackColor = Color.Red
                End If
            Catch ex As Exception
                Progress.Value = Progress.Value + 50
                Me.ListView1.SelectedItems.Item(i).BackColor = Color.Red
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
                ListView1.Items.Item(count).ForeColor = Color.White
            Else
                ListView1.Items.Item(count).BackColor = Color.Red
                'request.KeepAlive = False
            End If
        Catch ex As Exception
            Try
                ListView1.Items.Item(count).BackColor = Color.Red
            Catch

            End Try
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If count = ListView1.Items.Count - 1 Then
            Try
                count = 0
                linea = ""
                Progress.Value = ListView1.Items.Count
            Catch

            End Try
        Else
            Try
                'Increment
                count += 1
                Progress.Value = Progress.Value + 1
                linea = ListView1.Items.Item(count).Text
                BackgroundWorker1.RunWorkerAsync()
            Catch

            End Try
        End If
    End Sub

    Private Sub CSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CSVToolStripMenuItem.Click
        Dim dlg As New SaveFileDialog
        dlg.Filter = "CSV files (*.CSV)|*.csv"
        dlg.FilterIndex = 1
        dlg.RestoreDirectory = True
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If ExportListViewToCSV(dlg.FileName, ListView1) Then
                Process.Start(dlg.FileName)
            End If
        End If
    End Sub

    Public Function ExportListViewToCSV(ByVal filename As String, ByVal lv As ListView) As Boolean
        Try
            ' Open output file
            Dim os As New StreamWriter(filename)

            ' Write records
            For i As Integer = 0 To lv.Items.Count - 1
                For j As Integer = 0 To lv.Columns.Count - 1
                    os.Write(lv.Items(i).SubItems(j).Text + ";")
                Next
                os.WriteLine()
            Next
            os.Close()
        Catch ex As Exception
            ' catch any errors
            Return False
        End Try
        Return True
    End Function

    Private Sub CSVToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CSVToolStripMenuItem1.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofd.FileName <> "" Then
            Try
                Using reader As New Microsoft.VisualBasic.FileIO.TextFieldParser(ofd.FileName)
                    reader.TextFieldType = FileIO.FieldType.Delimited
                    reader.SetDelimiters(";")
                    While Not reader.EndOfData
                        Dim Fields() As String = reader.ReadFields
                        Dim item As New ListViewItem
                        item.Text = Fields(0)
                        For x = 1 To UBound(Fields)
                            item.SubItems.Add(Fields(x))
                        Next
                        ListView1.Items.Add(item)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show(Err.Description)
            End Try
        End If

    End Sub

    Private Sub TXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TXTToolStripMenuItem.Click

        Dim dlg As New SaveFileDialog
        dlg.Filter = "TXT files (*.TXT)|*.txt"
        dlg.FilterIndex = 1
        dlg.RestoreDirectory = True
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Using file As New IO.StreamWriter(dlg.FileName, False)
                Dim line As String = ""
                For Each item As ListViewItem In Me.ListView1.Items
                    line = ""
                    For Each subitem As ListViewItem.ListViewSubItem In item.SubItems
                        line += subitem.Text '+ vbTab
                    Next
                    file.WriteLine(line)
                Next
                file.Close()
            End Using
        End If

        Process.Start(dlg.FileName)
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub TXTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TXTToolStripMenuItem1.Click
        Dim openfile = New OpenFileDialog()
        openfile.Filter = "Text (*.txt)|*.txt"
        If (openfile.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Dim myfile As String = openfile.FileName
            Dim allLines As String() = File.ReadAllLines(myfile)
            For Each line As String In allLines
                ListView1.Items.Add(line)
            Next
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        ' Remove IP Address : Port.
        For i As Integer = ListView1.SelectedItems.Count - 1 To 0 Step -1
            ListView1.SelectedItems(i).Remove()
            lbCountProxys.Text = ListView1.Items.Count
        Next
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Copy IP Address : Port to Clipboard.
        For i As Integer = ListView1.SelectedItems.Count - 1 To 0 Step -1
            My.Computer.Clipboard.SetText(ListView1.SelectedItems(i).Text)
        Next
    End Sub

    Private Sub RemoveDownlinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveDownlinkToolStripMenuItem.Click
        ' Remove IP Address : Port Status: Downlink
        For Each item As ListViewItem In Me.ListView1.Items
            If item.BackColor = Color.Red Then
                item.Remove()
                lbCountProxys.Text = ListView1.Items.Count
            End If
        Next
    End Sub
End Class