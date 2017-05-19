<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.pxColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.cbHideMyAss = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbHideMyName = New System.Windows.Forms.CheckBox()
        Me.cbNNTIME = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.pxColumn})
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(190, 285)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'pxColumn
        '
        Me.pxColumn.Text = "IP Proxy List"
        Me.pxColumn.Width = 160
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(208, 297)
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
        Me.Button1.Location = New System.Drawing.Point(12, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "GET"
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
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 342)
        Me.Controls.Add(Me.cbNNTIME)
        Me.Controls.Add(Me.cbHideMyName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbHideMyAss)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proxy List"
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
End Class
