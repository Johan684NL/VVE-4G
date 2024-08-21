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
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        RichTextBox2 = New RichTextBox()
        TextBox4 = New TextBox()
        PrintDialog1 = New PrintDialog()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Navy
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LightSteelBlue
        Label1.Location = New Point(288, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(315, 28)
        Label1.TabIndex = 0
        Label1.Text = "Kansberekening signaalsterkte VVE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.UseMnemonic = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(288, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(134, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(288, 112)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(134, 27)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(245, 20)
        Label2.TabIndex = 3
        Label2.Text = "Voer de hoogst gemeten waarde in:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(239, 20)
        Label3.TabIndex = 4
        Label3.Text = "Voer de laagst gemeten waarde in:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(185, 20)
        Label4.TabIndex = 5
        Label4.Text = "Voer het aantal iteraties in:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(288, 157)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(134, 27)
        TextBox3.TabIndex = 6
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.ForeColor = Color.ForestGreen
        RichTextBox1.Location = New Point(473, 71)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(388, 119)
        RichTextBox1.TabIndex = 7
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkBlue
        Button1.ForeColor = Color.LightSteelBlue
        Button1.Location = New Point(12, 201)
        Button1.Name = "Button1"
        Button1.Size = New Size(152, 36)
        Button1.TabIndex = 8
        Button1.Text = "Bereken"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(12, 243)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(679, 250)
        RichTextBox2.TabIndex = 9
        RichTextBox2.Text = ""
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(707, 248)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(157, 25)
        TextBox4.TabIndex = 10
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.AllowCurrentPage = True
        PrintDialog1.UseEXDialog = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.GreenYellow
        Button2.Location = New Point(713, 443)
        Button2.Name = "Button2"
        Button2.Size = New Size(148, 50)
        Button2.TabIndex = 11
        Button2.Text = "Print naar default printer"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(883, 505)
        Controls.Add(Button2)
        Controls.Add(TextBox4)
        Controls.Add(RichTextBox2)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "VVE kansberekening 4G signaalsterkte"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Button2 As Button

End Class
