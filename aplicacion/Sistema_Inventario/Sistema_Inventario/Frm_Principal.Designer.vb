<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Stb_Barra_Estado = New StatusStrip()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Stb_Barra_Estado
        ' 
        Stb_Barra_Estado.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        Stb_Barra_Estado.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Stb_Barra_Estado.ImageScalingSize = New Size(20, 20)
        Stb_Barra_Estado.Location = New Point(0, 578)
        Stb_Barra_Estado.Name = "Stb_Barra_Estado"
        Stb_Barra_Estado.RenderMode = ToolStripRenderMode.Professional
        Stb_Barra_Estado.Size = New Size(800, 22)
        Stb_Barra_Estado.TabIndex = 1
        Stb_Barra_Estado.Text = "StatusStrip1"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(-1, 579)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 20)
        Panel1.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.ForeColor = Color.White
        Panel3.Location = New Point(660, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(120, 20)
        Panel3.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(140, 20)
        Panel2.TabIndex = 3
        ' 
        ' Frm_Principal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 600)
        Controls.Add(Panel1)
        Controls.Add(Stb_Barra_Estado)
        FormBorderStyle = FormBorderStyle.None
        IsMdiContainer = True
        Name = "Frm_Principal"
        Text = "Frm_Principal"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Stb_Barra_Estado As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
