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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        button1 = New Button()
        textBox5 = New TextBox()
        textBox4 = New TextBox()
        textBox3 = New TextBox()
        textBox2 = New TextBox()
        textBox1 = New TextBox()
        label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' button1
        ' 
        button1.BackColor = Color.Transparent
        button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), Image)
        button1.FlatStyle = FlatStyle.Popup
        button1.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button1.ForeColor = SystemColors.ButtonHighlight
        button1.Image = CType(resources.GetObject("button1.Image"), Image)
        button1.ImageAlign = ContentAlignment.BottomRight
        button1.Location = New Point(711, 495)
        button1.Name = "button1"
        button1.Size = New Size(112, 34)
        button1.TabIndex = 13
        button1.Text = "NEXT ->"
        button1.UseVisualStyleBackColor = False
        ' 
        ' textBox5
        ' 
        textBox5.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        textBox5.Location = New Point(57, 264)
        textBox5.Name = "textBox5"
        textBox5.PlaceholderText = "Name"
        textBox5.Size = New Size(228, 28)
        textBox5.TabIndex = 12
        ' 
        ' textBox4
        ' 
        textBox4.Font = New Font("Times New Roman", 9F)
        textBox4.Location = New Point(57, 315)
        textBox4.Name = "textBox4"
        textBox4.PlaceholderText = "Email Address..."
        textBox4.Size = New Size(228, 28)
        textBox4.TabIndex = 11
        ' 
        ' textBox3
        ' 
        textBox3.Font = New Font("Times New Roman", 9F)
        textBox3.Location = New Point(57, 371)
        textBox3.Name = "textBox3"
        textBox3.PlaceholderText = "GENDER"
        textBox3.Size = New Size(150, 28)
        textBox3.TabIndex = 10
        ' 
        ' textBox2
        ' 
        textBox2.Font = New Font("Times New Roman", 9F)
        textBox2.Location = New Point(57, 422)
        textBox2.Name = "textBox2"
        textBox2.PlaceholderText = "CONTACT NO..."
        textBox2.Size = New Size(150, 28)
        textBox2.TabIndex = 9
        ' 
        ' textBox1
        ' 
        textBox1.Font = New Font("Times New Roman", 9F)
        textBox1.Location = New Point(57, 467)
        textBox1.Name = "textBox1"
        textBox1.PlaceholderText = "PASSPORT NO."
        textBox1.Size = New Size(150, 28)
        textBox1.TabIndex = 8
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.Transparent
        label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = SystemColors.ButtonFace
        label1.Image = CType(resources.GetObject("label1.Image"), Image)
        label1.ImageAlign = ContentAlignment.TopLeft
        label1.Location = New Point(57, 98)
        label1.Name = "label1"
        label1.Size = New Size(311, 28)
        label1.TabIndex = 7
        label1.Text = "PERSONAL INFORMATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Transparent
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.Location = New Point(749, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 21)
        Label2.TabIndex = 14
        Label2.Text = "AIRFLY"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(911, 573)
        Controls.Add(Label2)
        Controls.Add(button1)
        Controls.Add(textBox5)
        Controls.Add(textBox4)
        Controls.Add(textBox3)
        Controls.Add(textBox2)
        Controls.Add(textBox1)
        Controls.Add(label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public WithEvents button1 As Button
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents Label2 As Label

End Class
