<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnApply = New System.Windows.Forms.Button()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbIPPublic = New System.Windows.Forms.Label()
        Me.lbCountry = New System.Windows.Forms.Label()
        Me.lbConnection = New System.Windows.Forms.Label()
        Me.lbtxt1 = New System.Windows.Forms.Label()
        Me.lbtxt2 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbCountry = New System.Windows.Forms.PictureBox()
        Me.pxCountry = New System.Windows.Forms.PictureBox()
        Me.lbIPProxy = New System.Windows.Forms.Label()
        Me.lbCountryProxy = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(12, 290)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(97, 40)
        Me.btnApply.TabIndex = 0
        Me.btnApply.Text = "Connect"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'txtIP
        '
        Me.txtIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(12, 249)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(303, 30)
        Me.txtIP.TabIndex = 1
        Me.txtIP.Text = "000.000.000.000:1111"
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(115, 290)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(97, 40)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Disconnect"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address + Port:"
        '
        'lbIPPublic
        '
        Me.lbIPPublic.AutoSize = True
        Me.lbIPPublic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIPPublic.ForeColor = System.Drawing.Color.Red
        Me.lbIPPublic.Location = New System.Drawing.Point(81, 93)
        Me.lbIPPublic.Name = "lbIPPublic"
        Me.lbIPPublic.Size = New System.Drawing.Size(93, 25)
        Me.lbIPPublic.TabIndex = 4
        Me.lbIPPublic.Text = "127.0.0.1"
        '
        'lbCountry
        '
        Me.lbCountry.AutoSize = True
        Me.lbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCountry.Location = New System.Drawing.Point(81, 119)
        Me.lbCountry.Name = "lbCountry"
        Me.lbCountry.Size = New System.Drawing.Size(40, 25)
        Me.lbCountry.TabIndex = 5
        Me.lbCountry.Text = "UK"
        '
        'lbConnection
        '
        Me.lbConnection.AutoSize = True
        Me.lbConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConnection.ForeColor = System.Drawing.Color.Red
        Me.lbConnection.Location = New System.Drawing.Point(79, 16)
        Me.lbConnection.Name = "lbConnection"
        Me.lbConnection.Size = New System.Drawing.Size(117, 20)
        Me.lbConnection.TabIndex = 8
        Me.lbConnection.Text = "Not connected!"
        '
        'lbtxt1
        '
        Me.lbtxt1.AutoSize = True
        Me.lbtxt1.Location = New System.Drawing.Point(81, 41)
        Me.lbtxt1.Name = "lbtxt1"
        Me.lbtxt1.Size = New System.Drawing.Size(235, 13)
        Me.lbtxt1.TabIndex = 9
        Me.lbtxt1.Text = "Warning: Your internet traffic is unencrypted and"
        '
        'lbtxt2
        '
        Me.lbtxt2.AutoSize = True
        Me.lbtxt2.Location = New System.Drawing.Point(81, 54)
        Me.lbtxt2.Name = "lbtxt2"
        Me.lbtxt2.Size = New System.Drawing.Size(181, 13)
        Me.lbtxt2.TabIndex = 10
        Me.lbtxt2.Text = "your virtual online identity is exposed."
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Ok-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "Close-2-icon.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'pbCountry
        '
        Me.pbCountry.ErrorImage = CType(resources.GetObject("pbCountry.ErrorImage"), System.Drawing.Image)
        Me.pbCountry.Image = CType(resources.GetObject("pbCountry.Image"), System.Drawing.Image)
        Me.pbCountry.InitialImage = CType(resources.GetObject("pbCountry.InitialImage"), System.Drawing.Image)
        Me.pbCountry.Location = New System.Drawing.Point(12, 95)
        Me.pbCountry.Name = "pbCountry"
        Me.pbCountry.Size = New System.Drawing.Size(63, 47)
        Me.pbCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCountry.TabIndex = 12
        Me.pbCountry.TabStop = False
        '
        'pxCountry
        '
        Me.pxCountry.ErrorImage = CType(resources.GetObject("pxCountry.ErrorImage"), System.Drawing.Image)
        Me.pxCountry.Image = CType(resources.GetObject("pxCountry.Image"), System.Drawing.Image)
        Me.pxCountry.InitialImage = CType(resources.GetObject("pxCountry.InitialImage"), System.Drawing.Image)
        Me.pxCountry.Location = New System.Drawing.Point(12, 165)
        Me.pxCountry.Name = "pxCountry"
        Me.pxCountry.Size = New System.Drawing.Size(63, 47)
        Me.pxCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pxCountry.TabIndex = 13
        Me.pxCountry.TabStop = False
        '
        'lbIPProxy
        '
        Me.lbIPProxy.AutoSize = True
        Me.lbIPProxy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIPProxy.Location = New System.Drawing.Point(81, 163)
        Me.lbIPProxy.Name = "lbIPProxy"
        Me.lbIPProxy.Size = New System.Drawing.Size(184, 25)
        Me.lbIPProxy.TabIndex = 14
        Me.lbIPProxy.Text = "???.?.?.??? (Proxy)"
        '
        'lbCountryProxy
        '
        Me.lbCountryProxy.AutoSize = True
        Me.lbCountryProxy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCountryProxy.Location = New System.Drawing.Point(81, 189)
        Me.lbCountryProxy.Name = "lbCountryProxy"
        Me.lbCountryProxy.Size = New System.Drawing.Size(40, 25)
        Me.lbCountryProxy.TabIndex = 15
        Me.lbCountryProxy.Text = "UK"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 41)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Proxy List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 342)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.lbCountryProxy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.lbIPProxy)
        Me.Controls.Add(Me.pxCountry)
        Me.Controls.Add(Me.pbCountry)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbtxt2)
        Me.Controls.Add(Me.lbtxt1)
        Me.Controls.Add(Me.lbConnection)
        Me.Controls.Add(Me.lbCountry)
        Me.Controls.Add(Me.lbIPPublic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NextProxy"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnApply As Button
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lbIPPublic As Label
    Friend WithEvents lbCountry As Label
    Friend WithEvents lbConnection As Label
    Friend WithEvents lbtxt1 As Label
    Friend WithEvents lbtxt2 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbCountry As PictureBox
    Friend WithEvents pxCountry As PictureBox
    Friend WithEvents lbIPProxy As Label
    Friend WithEvents lbCountryProxy As Label
    Friend WithEvents Button1 As Button
End Class
