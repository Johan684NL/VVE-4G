Public Class Form1
    Public STlow As Int32
    Public SThigh As Int32
    Public Itter As Int32
    Public RNnbr As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        STlow = TextBox2.Text
        SThigh = TextBox1.Text
        Itter = TextBox3.Text
        Dim Value(SThigh) As Int32
        Dim ProCaRes(SThigh) As Int32
        TextBox4.Text = DateTime.Now
        For I = STlow To SThigh
            Value(I) = I
        Next
        ' Here start the probability calculation
        For ProCa = 0 To Itter
            RNnbr = CInt(Math.Floor((SThigh - STlow + 1) * Rnd())) + STlow
            ProCaRes(RNnbr) = ProCaRes(RNnbr) + 1
        Next
        RichTextBox2.Text = "KANSBEREKENING SIGNAALSTERKTE 4G            Datum: " + TextBox4.Text + Chr(13)
        RichTextBox2.Text = RichTextBox2.Text + "------------------------------------------------------------------------------------" + Chr(13) + Chr(13)
        RichTextBox2.Text = RichTextBox2.Text + "% Kansberekening 4G netwerk ontvangst kwaliteit
% Bronnen sharetechnote.com/html/FrameStructure_DL.html 
% One radioframe in time 10ms. 
% One slot in time=0,5ms.
% Youtube Monte Carlo Methods: Data Sience Basics
% Meetdata 12 augustus 2024 uitgevoerd door Ardio.
% De tijd voor 1 radioframe bedraagt 10ms.
% Aantal momenten per 24 uur, waarop de kwaliteit van de
% verbinding wordt gecontroleers is:
% 1/0,1 * 60 * 60 * 24 = 864.000
% x 31 dagen = 26.784.000 kansberekeningen" + Chr(13) + Chr(13)
        For Irs = STlow To SThigh
            RichTextBox2.Text = RichTextBox2.Text + "Veldsterkte: " + Convert.ToString(Irs) + "   Aantal keer voorgekomen: " + Convert.ToString(ProCaRes(Irs)) + " Percentage: " + Convert.ToString(ProCaRes(Irs) / Itter * 100) + " %" + Chr(13)
        Next

    End Sub

    Private Sub Button2_Click(senders As Object, beh As EventArgs) Handles Button2.Click
        Dim printDialog As New PrintDialog()

        If printDialog.ShowDialog() = DialogResult.OK Then
            Dim printDocument As New Printing.PrintDocument()
            AddHandler printDocument.PrintPage, Sub(sender, e)
                                                    Dim rtfContent As String = RichTextBox2.Rtf
                                                    e.Graphics.DrawString(rtfContent, RichTextBox2.Font, Brushes.Black, e.MarginBounds)
                                                End Sub
            printDocument.Print()
        End If

    End Sub
End Class
