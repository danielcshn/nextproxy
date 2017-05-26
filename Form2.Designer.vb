<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.pxColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckUplinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.cbHideMyAss = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbHideMyName = New System.Windows.Forms.CheckBox()
        Me.cbNNTIME = New System.Windows.Forms.CheckBox()
        Me.cbPremProxy = New System.Windows.Forms.CheckBox()
        Me.cbFreeProxyList2 = New System.Windows.Forms.CheckBox()
        Me.cbSpysru = New System.Windows.Forms.CheckBox()
        Me.cbGatherProxy = New System.Windows.Forms.CheckBox()
        Me.cbHTTPtunnel = New System.Windows.Forms.CheckBox()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCountProxys = New System.Windows.Forms.Label()
        Me.cbSelect = New System.Windows.Forms.CheckBox()
        Me.cbProxyNova = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuList.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.pxColumn})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuList
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(190, 318)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'pxColumn
        '
        Me.pxColumn.Text = "IP Proxy List"
        Me.pxColumn.Width = 160
        '
        'ContextMenuList
        '
        Me.ContextMenuList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckUplinkToolStripMenuItem, Me.CheckAllToolStripMenuItem})
        Me.ContextMenuList.Name = "ContextMenuList"
        Me.ContextMenuList.Size = New System.Drawing.Size(145, 48)
        '
        'CheckUplinkToolStripMenuItem
        '
        Me.CheckUplinkToolStripMenuItem.Name = "CheckUplinkToolStripMenuItem"
        Me.CheckUplinkToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CheckUplinkToolStripMenuItem.Text = "Check Uplink"
        '
        'CheckAllToolStripMenuItem
        '
        Me.CheckAllToolStripMenuItem.Name = "CheckAllToolStripMenuItem"
        Me.CheckAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CheckAllToolStripMenuItem.Text = "Check All"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(273, 226)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(48, 33)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Visible = False
        '
        'cbHideMyAss
        '
        Me.cbHideMyAss.AutoSize = True
        Me.cbHideMyAss.Location = New System.Drawing.Point(208, 12)
        Me.cbHideMyAss.Name = "cbHideMyAss"
        Me.cbHideMyAss.Size = New System.Drawing.Size(102, 17)
        Me.cbHideMyAss.TabIndex = 2
        Me.cbHideMyAss.Text = "HideMyAss.com"
        Me.cbHideMyAss.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CAPTURE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbHideMyName
        '
        Me.cbHideMyName.AutoSize = True
        Me.cbHideMyName.Location = New System.Drawing.Point(208, 35)
        Me.cbHideMyName.Name = "cbHideMyName"
        Me.cbHideMyName.Size = New System.Drawing.Size(93, 17)
        Me.cbHideMyName.TabIndex = 4
        Me.cbHideMyName.Text = "HideMy.Name"
        Me.cbHideMyName.UseVisualStyleBackColor = True
        '
        'cbNNTIME
        '
        Me.cbNNTIME.AutoSize = True
        Me.cbNNTIME.Location = New System.Drawing.Point(208, 58)
        Me.cbNNTIME.Name = "cbNNTIME"
        Me.cbNNTIME.Size = New System.Drawing.Size(88, 17)
        Me.cbNNTIME.TabIndex = 5
        Me.cbNNTIME.Text = "NNTime.com"
        Me.cbNNTIME.UseVisualStyleBackColor = True
        '
        'cbPremProxy
        '
        Me.cbPremProxy.AutoSize = True
        Me.cbPremProxy.Location = New System.Drawing.Point(208, 196)
        Me.cbPremProxy.Name = "cbPremProxy"
        Me.cbPremProxy.Size = New System.Drawing.Size(98, 17)
        Me.cbPremProxy.TabIndex = 6
        Me.cbPremProxy.Text = "Premproxy.com"
        Me.cbPremProxy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbPremProxy.UseVisualStyleBackColor = True
        '
        'cbFreeProxyList2
        '
        Me.cbFreeProxyList2.AutoSize = True
        Me.cbFreeProxyList2.Location = New System.Drawing.Point(208, 81)
        Me.cbFreeProxyList2.Name = "cbFreeProxyList2"
        Me.cbFreeProxyList2.Size = New System.Drawing.Size(113, 17)
        Me.cbFreeProxyList2.TabIndex = 7
        Me.cbFreeProxyList2.Text = "Free-Proxy-List.net"
        Me.cbFreeProxyList2.UseVisualStyleBackColor = True
        '
        'cbSpysru
        '
        Me.cbSpysru.AutoSize = True
        Me.cbSpysru.Location = New System.Drawing.Point(208, 104)
        Me.cbSpysru.Name = "cbSpysru"
        Me.cbSpysru.Size = New System.Drawing.Size(61, 17)
        Me.cbSpysru.TabIndex = 8
        Me.cbSpysru.Text = "Spys.ru"
        Me.cbSpysru.UseVisualStyleBackColor = True
        '
        'cbGatherProxy
        '
        Me.cbGatherProxy.AutoSize = True
        Me.cbGatherProxy.Location = New System.Drawing.Point(208, 127)
        Me.cbGatherProxy.Name = "cbGatherProxy"
        Me.cbGatherProxy.Size = New System.Drawing.Size(107, 17)
        Me.cbGatherProxy.TabIndex = 9
        Me.cbGatherProxy.Text = "GatherProxy.com"
        Me.cbGatherProxy.UseVisualStyleBackColor = True
        '
        'cbHTTPtunnel
        '
        Me.cbHTTPtunnel.AutoSize = True
        Me.cbHTTPtunnel.Location = New System.Drawing.Point(208, 173)
        Me.cbHTTPtunnel.Name = "cbHTTPtunnel"
        Me.cbHTTPtunnel.Size = New System.Drawing.Size(99, 17)
        Me.cbHTTPtunnel.TabIndex = 10
        Me.cbHTTPtunnel.Text = "HTTPtunnel.ge"
        Me.cbHTTPtunnel.UseVisualStyleBackColor = True
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(208, 278)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(107, 23)
        Me.Progress.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Proxy List: "
        '
        'lbCountProxys
        '
        Me.lbCountProxys.AutoSize = True
        Me.lbCountProxys.Location = New System.Drawing.Point(262, 262)
        Me.lbCountProxys.Name = "lbCountProxys"
        Me.lbCountProxys.Size = New System.Drawing.Size(13, 13)
        Me.lbCountProxys.TabIndex = 13
        Me.lbCountProxys.Text = "0"
        '
        'cbSelect
        '
        Me.cbSelect.AutoSize = True
        Me.cbSelect.Location = New System.Drawing.Point(208, 219)
        Me.cbSelect.Name = "cbSelect"
        Me.cbSelect.Size = New System.Drawing.Size(70, 17)
        Me.cbSelect.TabIndex = 14
        Me.cbSelect.Text = "Select All"
        Me.cbSelect.UseVisualStyleBackColor = True
        '
        'cbProxyNova
        '
        Me.cbProxyNova.AutoSize = True
        Me.cbProxyNova.Location = New System.Drawing.Point(208, 150)
        Me.cbProxyNova.Name = "cbProxyNova"
        Me.cbProxyNova.Size = New System.Drawing.Size(101, 17)
        Me.cbProxyNova.TabIndex = 15
        Me.cbProxyNova.Text = "ProxyNova.com"
        Me.cbProxyNova.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 342)
        Me.Controls.Add(Me.cbProxyNova)
        Me.Controls.Add(Me.cbSelect)
        Me.Controls.Add(Me.lbCountProxys)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.cbHTTPtunnel)
        Me.Controls.Add(Me.cbGatherProxy)
        Me.Controls.Add(Me.cbSpysru)
        Me.Controls.Add(Me.cbFreeProxyList2)
        Me.Controls.Add(Me.cbPremProxy)
        Me.Controls.Add(Me.cbNNTIME)
        Me.Controls.Add(Me.cbHideMyName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbHideMyAss)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proxy List"
        Me.ContextMenuList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents pxColumn As ColumnHeader
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents cbHideMyAss As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cbHideMyName As CheckBox
    Friend WithEvents cbNNTIME As CheckBox
    Friend WithEvents cbPremProxy As CheckBox
    Friend WithEvents cbFreeProxyList2 As CheckBox
    Friend WithEvents cbSpysru As CheckBox
    Friend WithEvents cbGatherProxy As CheckBox
    Friend WithEvents cbHTTPtunnel As CheckBox
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCountProxys As Label
    Friend WithEvents cbSelect As CheckBox
    Friend WithEvents cbProxyNova As CheckBox
    Friend WithEvents ContextMenuList As ContextMenuStrip
    Friend WithEvents CheckUplinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
