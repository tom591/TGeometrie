Public Class Form1
    'Obvod trojúhelníku
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim ot As Double = a + b + c
            TextBox5.Text = ot
            RichTextBox1.Text = ("o=a+b+c")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox2.Text, b) = True Then
            Dim ot As Double = a + b + c
            TextBox5.Text = ot
            RichTextBox1.Text = ("o=a+b+c")
        Else
            MsgBox("Zadaná hodnota v poli 'b' není číslo.")
        End If
        If Double.TryParse(TextBox3.Text, c) = True Then
            Dim ot As Double = a + b + c
            TextBox5.Text = ot
            RichTextBox1.Text = ("o=a+b+c")
        Else
            MsgBox("Zadaná hodnota v poli 'c' není číslo.")
        End If
    End Sub
    'Obvod čtverce
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim oc As Double = 4 * a
            TextBox5.Text = oc
            RichTextBox1.Text = ("o=4.a")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
    End Sub
    'Obvod obdelníku
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As Double
        Dim b As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim oo As Double = 2 * (a + b)
            TextBox5.Text = oo
            RichTextBox1.Text = ("o=2.(a+b)")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox2.Text, b) = True Then
            Dim oo As Double = 2 * (a + b)
            TextBox5.Text = oo
            RichTextBox1.Text = ("o=2.(a+b)")
        Else
            MsgBox("Zadaná hodnota v poli 'b' není číslo.")
        End If
    End Sub
    'Obvod lichoběžníku
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim ol As Double = a + b + c + d
            TextBox5.Text = ol
            RichTextBox1.Text = ("o=a+b+c+d")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox2.Text, b) = True Then
            Dim ol As Double = a + b + c + d
            TextBox5.Text = ol
            RichTextBox1.Text = ("o=a+b+c+d")
        Else
            MsgBox("Zadaná hodnota v poli 'b' není číslo.")
        End If
        If Double.TryParse(TextBox3.Text, c) = True Then
            Dim ol As Double = a + b + c + d
            TextBox5.Text = ol
            RichTextBox1.Text = ("o=a+b+c+d")
        Else
            MsgBox("Zadaná hodnota v poli 'c' není číslo.")
        End If
        If Double.TryParse(TextBox4.Text, d) = True Then
            Dim ol As Double = a + b + c + d
            TextBox5.Text = ol
            RichTextBox1.Text = ("o=a+b+c+d")
        Else
            MsgBox("Zadaná hodnota v poli 'd' není číslo.")
        End If
    End Sub
    'Obsah čtverce
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim sc As Double = a * a
            TextBox5.Text = sc
            RichTextBox1.Text = ("S=a.a")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
    End Sub
    'Obsah obdelníku
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a As Double
        Dim b As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim so As Double = a * b
            TextBox5.Text = so
            RichTextBox1.Text = ("S=a.b")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox2.Text, b) = True Then
            Dim so As Double = a * b
            TextBox5.Text = so
            RichTextBox1.Text = ("S=a.b")
        Else
            MsgBox("Zadaná hodnota v poli 'b' není číslo.")
        End If
    End Sub
    'Obdelníková uhlopříčka
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim a As Double
        Dim b As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim ou As Double = (Math.Sqrt((a ^ 2) + (b ^ 2)))
            TextBox5.Text = ou
            RichTextBox1.Text = ("u=√a^2+b^2")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox2.Text, b) = True Then
            Dim ou As Double = (Math.Sqrt((a ^ 2) + (b ^ 2)))
            TextBox5.Text = ou
            RichTextBox1.Text = ("u=√a^2+b^2")
        Else
            MsgBox("Zadaná hodnota v poli 'b' není číslo.")
        End If
    End Sub
    'Poloměr opsané kružnice
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim u As Double
        If Double.TryParse(TextBox6.Text, u) = True Then
            Dim pok As Double = u / 2
            TextBox5.Text = pok
            RichTextBox1.Text = ("r=u/2")
        Else
            MsgBox("Zadaná hodnota v poli 'u' není číslo.")
        End If
    End Sub
    'Obsah lichoběžníku
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim a As Double
        Dim c As Double
        Dim v As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim sl As Double = ((a + c) / 2) * v
            TextBox5.Text = sl
            RichTextBox1.Text = ("S=((a+c)/2).v")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox3.Text, c) = True Then
            Dim sl As Double = ((a + c) / 2) * v
            TextBox5.Text = sl
            RichTextBox1.Text = ("S=((a+c)/2).v")
        Else
            MsgBox("Zadaná hodnota v poli 'c' není číslo.")
        End If
        If Double.TryParse(TextBox9.Text, v) = True Then
            Dim sl As Double = ((a + c) / 2) * v
            TextBox5.Text = sl
            RichTextBox1.Text = ("S=((a+c)/2).v")
        Else
            MsgBox("Zadaná hodnota v poli 'v' není číslo.")
        End If
    End Sub
    'Odkaz
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("mailto:tom591@seznam.cz")
    End Sub
    'O programu
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        MsgBox("Program pro výpočet základných geometrických funkcí, více o funkcích programu v souboru cti_mne.txt. Naprogramoval Tomáš Salaj.", , "O programu")
    End Sub
    'Poloměr vepsané kružnice
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim a As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim pvk As Double = a / 2
            TextBox5.Text = pvk
            RichTextBox1.Text = ("p=a/2")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
    End Sub
    'Poloměr kružnice opsané obdélníku
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim u As Double
        If Double.TryParse(TextBox6.Text, u) = True Then
            Dim pkoo As Double = u / 2
            TextBox5.Text = pkoo
            RichTextBox1.Text = ("r=u/2")
        Else
            MsgBox("Zadaná hodnota v poli 'u' není číslo.")
        End If
    End Sub
    'Střední příčka lichoběžníku
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim a As Double
        Dim c As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim spl As Double = (a + c) / 2
            TextBox5.Text = spl
            RichTextBox1.Text = ("s=(a+c)/2")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox3.Text, c) = True Then
            Dim spl As Double = (a + c) / 2
            TextBox5.Text = spl
            RichTextBox1.Text = ("s=(a+c)/2")
        Else
            MsgBox("Zadaná hodnota v poli 'c' není číslo.")
        End If
    End Sub
    'Obvod rovnoběžníku
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim a As Double
        Dim b As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim orb As Double = 2 * (a + b)
            TextBox5.Text = orb
            RichTextBox1.Text = ("o=2.(a+b)")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox2.Text, b) = True Then
            Dim orb As Double = 2 * (a + b)
            TextBox5.Text = orb
            RichTextBox1.Text = ("o=2.(a+b)")
        Else
            MsgBox("Zadaná hodnota v poli 'b' není číslo.")
        End If
    End Sub
    'Obsah rovnoběžníku
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim a As Double
        Dim v As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim srb As Double = a * v
            TextBox5.Text = srb
            RichTextBox1.Text = ("S=a.v")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox9.Text, v) = True Then
            Dim srb As Double = a * v
            TextBox5.Text = srb
            RichTextBox1.Text = ("S=a.v")
        Else
            MsgBox("Zadaná hodnota v poli 'v' není číslo.")
        End If
    End Sub
    'Radio čtverec
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox8.ReadOnly = True
            TextBox9.ReadOnly = True
        Else
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            TextBox8.ReadOnly = False
            TextBox9.ReadOnly = False
        End If
    End Sub
    'Čtvercová uhlopříčka
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim a As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim cu As Double = a ^ 2
            TextBox5.Text = cu
            RichTextBox1.Text = ("u=a√2")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
    End Sub
    'Obsah trojúhelníku
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        If Double.TryParse(TextBox1.Text, a) = True Then
            Dim s As Double = (a + b + c) / 2
            Dim st As Double = (Math.Sqrt(s * (s - a) * (s - b) * (s - c)))
            TextBox5.Text = st
            RichTextBox1.Text = ("S=√s(s-a)(s-b)(s-c)")
        Else
            MsgBox("Zadaná hodnota v poli 'a' není číslo.")
        End If
        If Double.TryParse(TextBox2.Text, b) = True Then
            Dim s As Double = (a + b + c) / 2
            Dim st As Double = (Math.Sqrt(s * (s - a) * (s - b) * (s - c)))
            TextBox5.Text = st
            RichTextBox1.Text = ("S=√s(s-a)(s-b)(s-c)")
        Else
            MsgBox("Zadaná hodnota v poli 'b' není číslo.")
        End If
        If Double.TryParse(TextBox3.Text, c) = True Then
            Dim s As Double = (a + b + c) / 2
            Dim st As Double = (Math.Sqrt(s * (s - a) * (s - b) * (s - c)))
            TextBox5.Text = st
            RichTextBox1.Text = ("S=√s(s-a)(s-b)(s-c)")
        Else
            MsgBox("Zadaná hodnota v poli 'c' není číslo.")
        End If
    End Sub
    'Radio obdelník
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox8.ReadOnly = True
            TextBox9.ReadOnly = True
        Else
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            TextBox8.ReadOnly = False
            TextBox9.ReadOnly = False
        End If
    End Sub
    'Radio rovnoběžník
    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox6.ReadOnly = True
            TextBox8.ReadOnly = True
        Else
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            TextBox6.ReadOnly = False
            TextBox8.ReadOnly = False
        End If
    End Sub
    'Radio trojúhelník
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TextBox4.ReadOnly = True
            TextBox6.ReadOnly = True
            TextBox8.ReadOnly = True
            TextBox9.ReadOnly = True
        Else
            TextBox4.ReadOnly = False
            TextBox6.ReadOnly = False
            TextBox8.ReadOnly = False
            TextBox9.ReadOnly = False
        End If
    End Sub
    'Radio lichoběžník
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox6.ReadOnly = True
            TextBox8.ReadOnly = True
        Else
            TextBox6.ReadOnly = False
            TextBox8.ReadOnly = False
        End If
    End Sub
    'Obvod kruhu - délka kružnice
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim r As Double
        If Double.TryParse(TextBox8.Text, r) = True Then
            Dim ok As Double = 2 * Math.PI * r
            TextBox5.Text = ok
            RichTextBox1.Text = ("o=2πr")
        Else
            MsgBox("Zadaná hodnota v poli 'r' není číslo.")
        End If
    End Sub
    'Obsah kruhu
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim r As Double
        If Double.TryParse(TextBox8.Text, r) = True Then
            Dim ok As Double = Math.PI * r ^ 2
            TextBox5.Text = ok
            RichTextBox1.Text = ("S=πr^2")
        Else
            MsgBox("Zadaná hodnota v poli 'r' není číslo.")
        End If
    End Sub
    'Radio kruh - kružnice
    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
            TextBox4.ReadOnly = True
            TextBox6.ReadOnly = True
            TextBox9.ReadOnly = True
        Else
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
            TextBox4.ReadOnly = False
            TextBox6.ReadOnly = True
            TextBox9.ReadOnly = False
        End If
    End Sub
End Class