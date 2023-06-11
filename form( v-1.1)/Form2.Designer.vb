<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Matura MT Script Capitals", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(189, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 45)
        Label1.TabIndex = 1
        Label1.Text = "Log in form "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Garamond", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(13, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 26)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Garamond", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(13, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 26)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.LightGray
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(168, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(261, 20)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.LightGray
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(168, 170)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(261, 20)
        TextBox2.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Azure
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(168, 264)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 41)
        Button1.TabIndex = 13
        Button1.Text = "Log in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(96, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(617, 365)
        Panel1.TabIndex = 14
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        BackgroundImage = My.Resources.Resources.WhatsApp_Image_2023_06_09_at_23_20_35
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Log in"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
