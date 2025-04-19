Imports System.Drawing.Printing
Imports System.IO
Public Class Form1
    Private printDocument As New PrintDocument()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Uygulama parametrelerini kontrol etme
        Dim args As String() = Environment.GetCommandLineArgs()

        ' Eğer bir dosya yolu sağlanmışsa
        If args.Length > 1 Then
            Dim filePath As String = args(1)
            ' Dosya yolu geçerliyse dosya içeriğini oku ve RichTextBox1'e yükle
            If File.Exists(filePath) Then
                Try
                    Dim fileContent As String = File.ReadAllText(filePath)
                    RichTextBox1.Text = fileContent
                Catch ex As Exception
                    MessageBox.Show("Dosya okunurken bir hata oluştu: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Belirtilen dosya bulunamadı.")
            End If
        End If

        AddHandler printDocument.PrintPage, AddressOf Me.PrintDocument_PrintPage
    End Sub

    Private Sub YazdırToolStripButton_Click(sender As Object, e As EventArgs) Handles YazdırToolStripButton.Click
        PrintDialog1.Document = printDocument
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim printFont As New Font("Arial", 12)
        Dim printString As String = RichTextBox1.Text
        e.Graphics.DrawString(printString, printFont, Brushes.Black, 10, 10)
    End Sub

    Private Sub YeniToolStripButton_Click(sender As Object, e As EventArgs) Handles YeniToolStripButton.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub KaydetToolStripButton_Click(sender As Object, e As EventArgs) Handles KaydetToolStripButton.Click
        ' SaveFileDialog'ı oluştur
        Dim saveFileDialog As New SaveFileDialog()

        ' Dialog özelliklerini ayarla
        saveFileDialog.Filter = "Not Files (*.not)|*.not|All Files (*.*)|*.*"
        saveFileDialog.Title = "Dosyayı Kaydet"

        ' Dialog'ı göster ve kullanıcının seçim yapmasını bekle
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Seçilen dosya yolunu al
            Dim fileName As String = saveFileDialog.FileName

            ' RichTextBox1'deki metni dosyaya yaz
            File.WriteAllText(fileName, RichTextBox1.Text)
        End If
    End Sub

    Private Sub AçToolStripButton_Click(sender As Object, e As EventArgs) Handles AçToolStripButton.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "NOT Files (*.not)|*.not|All Files (*.*)|*.*"
        openFileDialog.Title = "Select a .not file"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim filePath As String = openFileDialog.FileName
                Dim fileContent As String = File.ReadAllText(filePath)
                RichTextBox1.Text = fileContent
            Catch ex As Exception
                MessageBox.Show("Error reading file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub KesToolStripButton_Click(sender As Object, e As EventArgs) Handles KesToolStripButton.Click
        If RichTextBox1.SelectionLength > 0 Then
            RichTextBox1.Cut()
        Else
            MessageBox.Show("Kesmek için önce bir metin seçmelisiniz.")
        End If
    End Sub

    Private Sub KopyalaToolStripButton_Click(sender As Object, e As EventArgs) Handles KopyalaToolStripButton.Click
        ' Seçili metni kopyalar
        If RichTextBox1.SelectedText <> String.Empty Then
            Clipboard.SetText(RichTextBox1.SelectedText)
            MessageBox.Show("Seçili metin kopyalandı.")
        Else
            MessageBox.Show("Kopyalanacak seçili metin bulunmuyor.")
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub YapıştırToolStripButton_Click(sender As Object, e As EventArgs) Handles YapıştırToolStripButton.Click
        ' Panodaki metni yapıştır
        If Clipboard.ContainsText() Then
            RichTextBox1.Text = Clipboard.GetText()
        End If
    End Sub

    Private Sub YardımToolStripButton_Click(sender As Object, e As EventArgs) Handles YardımToolStripButton.Click

        MessageBox.Show("MyCm sunar.", "MYNote V1")
    End Sub

End Class
