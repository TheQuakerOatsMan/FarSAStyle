<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detvmed
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
        Me.prevtamed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cantvm = New System.Windows.Forms.ComboBox()
        Me.nommed = New System.Windows.Forms.TextBox()
        Me.cvemed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnre10 = New System.Windows.Forms.Button()
        Me.aniadirm = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imgrec = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'prevtamed
        '
        Me.prevtamed.Enabled = False
        Me.prevtamed.Location = New System.Drawing.Point(293, 157)
        Me.prevtamed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.prevtamed.Name = "prevtamed"
        Me.prevtamed.Size = New System.Drawing.Size(343, 26)
        Me.prevtamed.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "PRECIOVTAMED:"
        '
        'cantvm
        '
        Me.cantvm.FormattingEnabled = True
        Me.cantvm.Location = New System.Drawing.Point(293, 197)
        Me.cantvm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cantvm.Name = "cantvm"
        Me.cantvm.Size = New System.Drawing.Size(343, 28)
        Me.cantvm.TabIndex = 19
        '
        'nommed
        '
        Me.nommed.Enabled = False
        Me.nommed.Location = New System.Drawing.Point(293, 116)
        Me.nommed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nommed.Name = "nommed"
        Me.nommed.Size = New System.Drawing.Size(343, 26)
        Me.nommed.TabIndex = 18
        '
        'cvemed
        '
        Me.cvemed.Enabled = False
        Me.cvemed.Location = New System.Drawing.Point(293, 76)
        Me.cvemed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cvemed.Name = "cvemed"
        Me.cvemed.Size = New System.Drawing.Size(343, 26)
        Me.cvemed.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 119)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "NOMBREMED:"
        '
        'btnre10
        '
        Me.btnre10.BackColor = System.Drawing.Color.Navy
        Me.btnre10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnre10.Location = New System.Drawing.Point(418, 288)
        Me.btnre10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnre10.Name = "btnre10"
        Me.btnre10.Size = New System.Drawing.Size(218, 55)
        Me.btnre10.TabIndex = 15
        Me.btnre10.Text = "REGRESAR"
        Me.btnre10.UseVisualStyleBackColor = False
        '
        'aniadirm
        '
        Me.aniadirm.BackColor = System.Drawing.Color.CornflowerBlue
        Me.aniadirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aniadirm.Location = New System.Drawing.Point(36, 288)
        Me.aniadirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.aniadirm.Name = "aniadirm"
        Me.aniadirm.Size = New System.Drawing.Size(374, 55)
        Me.aniadirm.TabIndex = 14
        Me.aniadirm.Text = "AÑADIR MEDICAMENTO"
        Me.aniadirm.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 200)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CANTIDAD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "CVEPROD:"
        '
        'imgrec
        '
        Me.imgrec.Location = New System.Drawing.Point(293, 239)
        Me.imgrec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imgrec.MaxLength = 100
        Me.imgrec.Name = "imgrec"
        Me.imgrec.Size = New System.Drawing.Size(391, 26)
        Me.imgrec.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "IMG RECT (INGESA LA RECETA):"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnadd.Location = New System.Drawing.Point(692, 225)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(112, 50)
        Me.btnadd.TabIndex = 24
        Me.btnadd.Text = "AGREGAR"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 52)
        Me.Panel1.TabIndex = 85
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(5, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(436, 46)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Farmacia San Antonio"
        '
        'detvmed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 371)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.imgrec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.prevtamed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cantvm)
        Me.Controls.Add(Me.nommed)
        Me.Controls.Add(Me.cvemed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnre10)
        Me.Controls.Add(Me.aniadirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "detvmed"
        Me.Text = "detvmed"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prevtamed As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cantvm As ComboBox
    Friend WithEvents nommed As TextBox
    Friend WithEvents cvemed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnre10 As Button
    Friend WithEvents aniadirm As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents imgrec As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
End Class
