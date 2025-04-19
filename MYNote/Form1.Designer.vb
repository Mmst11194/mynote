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
        ToolStrip1 = New ToolStrip()
        YeniToolStripButton = New ToolStripButton()
        AçToolStripButton = New ToolStripButton()
        KaydetToolStripButton = New ToolStripButton()
        YazdırToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        KesToolStripButton = New ToolStripButton()
        ToolStripButton1 = New ToolStripButton()
        KopyalaToolStripButton = New ToolStripButton()
        YapıştırToolStripButton = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        YardımToolStripButton = New ToolStripButton()
        RichTextBox1 = New RichTextBox()
        PrintDialog1 = New PrintDialog()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {YeniToolStripButton, AçToolStripButton, KaydetToolStripButton, YazdırToolStripButton, toolStripSeparator, KesToolStripButton, ToolStripButton1, KopyalaToolStripButton, YapıştırToolStripButton, toolStripSeparator1, YardımToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' YeniToolStripButton
        ' 
        YeniToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        YeniToolStripButton.Image = CType(resources.GetObject("YeniToolStripButton.Image"), Image)
        YeniToolStripButton.ImageTransparentColor = Color.Magenta
        YeniToolStripButton.Name = "YeniToolStripButton"
        YeniToolStripButton.Size = New Size(23, 22)
        YeniToolStripButton.Text = "Ye&ni"
        ' 
        ' AçToolStripButton
        ' 
        AçToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AçToolStripButton.Image = CType(resources.GetObject("AçToolStripButton.Image"), Image)
        AçToolStripButton.ImageTransparentColor = Color.Magenta
        AçToolStripButton.Name = "AçToolStripButton"
        AçToolStripButton.Size = New Size(23, 22)
        AçToolStripButton.Text = "&Aç"
        ' 
        ' KaydetToolStripButton
        ' 
        KaydetToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        KaydetToolStripButton.Image = CType(resources.GetObject("KaydetToolStripButton.Image"), Image)
        KaydetToolStripButton.ImageTransparentColor = Color.Magenta
        KaydetToolStripButton.Name = "KaydetToolStripButton"
        KaydetToolStripButton.Size = New Size(23, 22)
        KaydetToolStripButton.Text = "&Kaydet"
        ' 
        ' YazdırToolStripButton
        ' 
        YazdırToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        YazdırToolStripButton.Image = CType(resources.GetObject("YazdırToolStripButton.Image"), Image)
        YazdırToolStripButton.ImageTransparentColor = Color.Magenta
        YazdırToolStripButton.Name = "YazdırToolStripButton"
        YazdırToolStripButton.Size = New Size(23, 22)
        YazdırToolStripButton.Text = "&Yazdır"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 25)
        ' 
        ' KesToolStripButton
        ' 
        KesToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        KesToolStripButton.Image = CType(resources.GetObject("KesToolStripButton.Image"), Image)
        KesToolStripButton.ImageTransparentColor = Color.Magenta
        KesToolStripButton.Name = "KesToolStripButton"
        KesToolStripButton.Size = New Size(23, 22)
        KesToolStripButton.Text = "&Kes"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "T&ümünü seç"
        ' 
        ' KopyalaToolStripButton
        ' 
        KopyalaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        KopyalaToolStripButton.Image = CType(resources.GetObject("KopyalaToolStripButton.Image"), Image)
        KopyalaToolStripButton.ImageTransparentColor = Color.Magenta
        KopyalaToolStripButton.Name = "KopyalaToolStripButton"
        KopyalaToolStripButton.Size = New Size(23, 22)
        KopyalaToolStripButton.Text = "K&opyala"
        ' 
        ' YapıştırToolStripButton
        ' 
        YapıştırToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        YapıştırToolStripButton.Image = CType(resources.GetObject("YapıştırToolStripButton.Image"), Image)
        YapıştırToolStripButton.ImageTransparentColor = Color.Magenta
        YapıştırToolStripButton.Name = "YapıştırToolStripButton"
        YapıştırToolStripButton.Size = New Size(23, 22)
        YapıştırToolStripButton.Text = "&Yapıştır"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' YardımToolStripButton
        ' 
        YardımToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        YardımToolStripButton.Image = CType(resources.GetObject("YardımToolStripButton.Image"), Image)
        YardımToolStripButton.ImageTransparentColor = Color.Magenta
        YardımToolStripButton.Name = "YardımToolStripButton"
        YardımToolStripButton.Size = New Size(23, 22)
        YardımToolStripButton.Text = "&Hakkında"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        RichTextBox1.Location = New Point(0, 28)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(800, 423)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(ToolStrip1)
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MYNote"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents YeniToolStripButton As ToolStripButton
    Friend WithEvents AçToolStripButton As ToolStripButton
    Friend WithEvents KaydetToolStripButton As ToolStripButton
    Friend WithEvents YazdırToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents KesToolStripButton As ToolStripButton
    Friend WithEvents KopyalaToolStripButton As ToolStripButton
    Friend WithEvents YapıştırToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents YardımToolStripButton As ToolStripButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStripButton1 As ToolStripButton

End Class
