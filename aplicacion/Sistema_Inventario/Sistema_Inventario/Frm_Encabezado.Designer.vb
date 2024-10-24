<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Encabezado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Encabezado))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Btn_Cerrar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(70, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(78, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 25)
        Label1.TabIndex = 1
        Label1.Text = "SimpleStock SS"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(300, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(281, 25)
        Label2.TabIndex = 2
        Label2.Text = "SISTEMA DE INVENTARIO"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Btn_Cerrar
        ' 
        Btn_Cerrar.BackColor = Color.DarkRed
        Btn_Cerrar.Image = CType(resources.GetObject("Btn_Cerrar.Image"), Image)
        Btn_Cerrar.Location = New Point(748, 14)
        Btn_Cerrar.Name = "Btn_Cerrar"
        Btn_Cerrar.Size = New Size(40, 40)
        Btn_Cerrar.TabIndex = 3
        Btn_Cerrar.UseVisualStyleBackColor = False
        ' 
        ' Frm_Encabezado
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(800, 70)
        Controls.Add(Btn_Cerrar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Frm_Encabezado"
        Text = "Frm_Encabezado"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Cerrar As Button
End Class
