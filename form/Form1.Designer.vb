<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tempus Sans ITC", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkOliveGreen
        Label1.Location = New Point(309, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 45)
        Label1.TabIndex = 0
        Label1.Text = "Registration form "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Garamond", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(52, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 26)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Garamond", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(52, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 26)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Garamond", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(52, 271)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 26)
        Label4.TabIndex = 3
        Label4.Text = "Confirm Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Garamond", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(52, 341)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 26)
        Label5.TabIndex = 4
        Label5.Text = "First Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Garamond", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(427, 341)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 26)
        Label6.TabIndex = 5
        Label6.Text = "Last Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.LightGray
        TextBox1.Location = New Point(178, 112)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(261, 30)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.LightGray
        TextBox2.Location = New Point(206, 185)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(261, 30)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.LightGray
        TextBox3.Location = New Point(287, 267)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(261, 30)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.LightGray
        TextBox4.Location = New Point(181, 337)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(187, 30)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.LightGray
        TextBox5.Location = New Point(564, 337)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(195, 30)
        TextBox5.TabIndex = 10
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.ForeColor = Color.DarkGreen
        CheckBox1.Location = New Point(52, 404)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(295, 26)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Accept All Turm and Conditions"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSlateGray
        Button1.Font = New Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(238, 439)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 41)
        Button1.TabIndex = 12
        Button1.Text = "SUBMIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Ravie", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LinkLabel1.LinkVisited = True
        LinkLabel1.Location = New Point(528, 448)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.RightToLeft = RightToLeft.Yes
        LinkLabel1.Size = New Size(96, 27)
        LinkLabel1.TabIndex = 13
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Log in"
        LinkLabel1.UseWaitCursor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(1000, 495)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Tempus Sans ITC", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Registration form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
