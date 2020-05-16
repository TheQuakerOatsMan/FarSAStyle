<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detvtam
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.aniadirp = New System.Windows.Forms.Button()
        Me.btnre8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cveprod = New System.Windows.Forms.TextBox()
        Me.nompro = New System.Windows.Forms.TextBox()
        Me.cantvp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.prevtaprod = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CVEPROD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 213)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CANTIDAD:"
        '
        'aniadirp
        '
        Me.aniadirp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.aniadirp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aniadirp.Location = New System.Drawing.Point(25, 261)
        Me.aniadirp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.aniadirp.Name = "aniadirp"
        Me.aniadirp.Size = New System.Drawing.Size(322, 55)
        Me.aniadirp.TabIndex = 3
        Me.aniadirp.Text = "AÑADIR PRODUCTO"
        Me.aniadirp.UseVisualStyleBackColor = False
        '
        'btnre8
        '
        Me.btnre8.BackColor = System.Drawing.Color.Navy
        Me.btnre8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnre8.Location = New System.Drawing.Point(355, 261)
        Me.btnre8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnre8.Name = "btnre8"
        Me.btnre8.Size = New System.Drawing.Size(218, 55)
        Me.btnre8.TabIndex = 4
        Me.btnre8.Text = "REGRESAR"
        Me.btnre8.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 128)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NOMBREPROD:"
        '
        'cveprod
        '
        Me.cveprod.Enabled = False
        Me.cveprod.Location = New System.Drawing.Point(184, 80)
        Me.cveprod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cveprod.Name = "cveprod"
        Me.cveprod.Size = New System.Drawing.Size(389, 26)
        Me.cveprod.TabIndex = 6
        '
        'nompro
        '
        Me.nompro.Enabled = False
        Me.nompro.Location = New System.Drawing.Point(184, 125)
        Me.nompro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nompro.Name = "nompro"
        Me.nompro.Size = New System.Drawing.Size(389, 26)
        Me.nompro.TabIndex = 7
        '
        'cantvp
        '
        Me.cantvp.FormattingEnabled = True
        Me.cantvp.Location = New System.Drawing.Point(184, 210)
        Me.cantvp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cantvp.Name = "cantvp"
        Me.cantvp.Size = New System.Drawing.Size(389, 28)
        Me.cantvp.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 169)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PRECIOVTAPROD:"
        '
        'prevtaprod
        '
        Me.prevtaprod.Enabled = False
        Me.prevtaprod.Location = New System.Drawing.Point(184, 166)
        Me.prevtaprod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.prevtaprod.Name = "prevtaprod"
        Me.prevtaprod.Size = New System.Drawing.Size(389, 26)
        Me.prevtaprod.TabIndex = 10
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
        Me.Panel1.Size = New System.Drawing.Size(597, 52)
        Me.Panel1.TabIndex = 85
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(-1, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(436, 46)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Farmacia San Antonio"
        '
        'detvtam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 330)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.prevtaprod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cantvp)
        Me.Controls.Add(Me.nompro)
        Me.Controls.Add(Me.cveprod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnre8)
        Me.Controls.Add(Me.aniadirp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "detvtam"
        Me.Text = "detvtprod"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents aniadirp As Button
    Friend WithEvents btnre8 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cveprod As TextBox
    Friend WithEvents nompro As TextBox
    Friend WithEvents cantvp As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents prevtaprod As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
End Class
