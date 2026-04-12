namespace OOPlab21s
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuSave = new ToolStripMenuItem();
            mnuSaveAs = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuCut = new ToolStripMenuItem();
            mnuCopy = new ToolStripMenuItem();
            mnuPaste = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuSelectAll = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuFind = new ToolStripMenuItem();
            mnuFormat = new ToolStripMenuItem();
            mnuFont = new ToolStripMenuItem();
            mnuColor = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            mnuAlignLeft = new ToolStripMenuItem();
            mnuAlignCenter = new ToolStripMenuItem();
            mnuAlignRight = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            mnuInsertImage = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            mnuArrangeIcons = new ToolStripMenuItem();
            mnuLanguage = new ToolStripMenuItem();
            mnuLangUk = new ToolStripMenuItem();
            mnuLangEn = new ToolStripMenuItem();
            mnuLangDe = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tbNew = new ToolStripButton();
            tbOpen = new ToolStripButton();
            tbSave = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tbCut = new ToolStripButton();
            tbCopy = new ToolStripButton();
            tbPaste = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            tbAlignLeft = new ToolStripButton();
            tbAlignCenter = new ToolStripButton();
            tbAlignRight = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            tbInsertImage = new ToolStripButton();
            tbSyntaxHighlight = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            sbAmount = new ToolStripStatusLabel();
            sbTime = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmnuCut = new ToolStripMenuItem();
            cmnuCopy = new ToolStripMenuItem();
            cmnuPaste = new ToolStripMenuItem();
            cmnuDelete = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            cmnuSelectAll = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            openFileDialogImage = new OpenFileDialog();
            panelFind = new Panel();
            btnFindClose = new Button();
            btnFindNext = new Button();
            chkMatchCase = new CheckBox();
            chkWholeWord = new CheckBox();
            txtFind = new TextBox();
            lblFind = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panelFind.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit, mnuFormat, mnuWindow, mnuLanguage, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = mnuWindow;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(900, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen, mnuSave, mnuSaveAs, toolStripSeparator1, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(48, 20);
            mnuFile.Text = "Файл";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuNew.Size = new Size(220, 22);
            mnuNew.Text = "Новий";
            mnuNew.Click += mnuNew_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuOpen.Size = new Size(220, 22);
            mnuOpen.Text = "Відкрити";
            mnuOpen.Click += mnuOpen_Click;
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuSave.Size = new Size(220, 22);
            mnuSave.Text = "Зберегти";
            mnuSave.Click += mnuSave_Click;
            // 
            // mnuSaveAs
            // 
            mnuSaveAs.Name = "mnuSaveAs";
            mnuSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            mnuSaveAs.Size = new Size(220, 22);
            mnuSaveAs.Text = "Зберегти як...";
            mnuSaveAs.Click += mnuSaveAs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(217, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuExit.Size = new Size(220, 22);
            mnuExit.Text = "Вихід";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuEdit
            // 
            mnuEdit.DropDownItems.AddRange(new ToolStripItem[] { mnuCut, mnuCopy, mnuPaste, mnuDelete, toolStripSeparator2, mnuSelectAll, toolStripSeparator3, mnuFind });
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(87, 20);
            mnuEdit.Text = "Редагування";
            // 
            // mnuCut
            // 
            mnuCut.Name = "mnuCut";
            mnuCut.ShortcutKeys = Keys.Control | Keys.X;
            mnuCut.Size = new Size(186, 22);
            mnuCut.Text = "Вирізати";
            mnuCut.Click += mnuCut_Click;
            // 
            // mnuCopy
            // 
            mnuCopy.Name = "mnuCopy";
            mnuCopy.ShortcutKeys = Keys.Control | Keys.C;
            mnuCopy.Size = new Size(186, 22);
            mnuCopy.Text = "Копіювати";
            mnuCopy.Click += mnuCopy_Click;
            // 
            // mnuPaste
            // 
            mnuPaste.Name = "mnuPaste";
            mnuPaste.ShortcutKeys = Keys.Control | Keys.V;
            mnuPaste.Size = new Size(186, 22);
            mnuPaste.Text = "Вставити";
            mnuPaste.Click += mnuPaste_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.ShortcutKeys = Keys.Delete;
            mnuDelete.Size = new Size(186, 22);
            mnuDelete.Text = "Видалити";
            mnuDelete.Click += mnuDelete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(183, 6);
            // 
            // mnuSelectAll
            // 
            mnuSelectAll.Name = "mnuSelectAll";
            mnuSelectAll.ShortcutKeys = Keys.Control | Keys.A;
            mnuSelectAll.Size = new Size(186, 22);
            mnuSelectAll.Text = "Виділити все";
            mnuSelectAll.Click += mnuSelectAll_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(183, 6);
            // 
            // mnuFind
            // 
            mnuFind.Name = "mnuFind";
            mnuFind.ShortcutKeys = Keys.Control | Keys.F;
            mnuFind.Size = new Size(186, 22);
            mnuFind.Text = "Знайти...";
            mnuFind.Click += mnuFind_Click;
            // 
            // mnuFormat
            // 
            mnuFormat.DropDownItems.AddRange(new ToolStripItem[] { mnuFont, mnuColor, toolStripSeparator8, mnuAlignLeft, mnuAlignCenter, mnuAlignRight, toolStripSeparator9, mnuInsertImage });
            mnuFormat.Name = "mnuFormat";
            mnuFormat.Size = new Size(62, 20);
            mnuFormat.Text = "Формат";
            // 
            // mnuFont
            // 
            mnuFont.Name = "mnuFont";
            mnuFont.Size = new Size(210, 22);
            mnuFont.Text = "Шрифт...";
            mnuFont.Click += mnuFont_Click;
            // 
            // mnuColor
            // 
            mnuColor.Name = "mnuColor";
            mnuColor.Size = new Size(210, 22);
            mnuColor.Text = "Колір...";
            mnuColor.Click += mnuColor_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(207, 6);
            // 
            // mnuAlignLeft
            // 
            mnuAlignLeft.Name = "mnuAlignLeft";
            mnuAlignLeft.ShortcutKeys = Keys.Control | Keys.L;
            mnuAlignLeft.Size = new Size(210, 22);
            mnuAlignLeft.Text = "За лівим краєм";
            mnuAlignLeft.Click += mnuAlignLeft_Click;
            // 
            // mnuAlignCenter
            // 
            mnuAlignCenter.Name = "mnuAlignCenter";
            mnuAlignCenter.ShortcutKeys = Keys.Control | Keys.E;
            mnuAlignCenter.Size = new Size(210, 22);
            mnuAlignCenter.Text = "По центру";
            mnuAlignCenter.Click += mnuAlignCenter_Click;
            // 
            // mnuAlignRight
            // 
            mnuAlignRight.Name = "mnuAlignRight";
            mnuAlignRight.ShortcutKeys = Keys.Control | Keys.R;
            mnuAlignRight.Size = new Size(210, 22);
            mnuAlignRight.Text = "За правим краєм";
            mnuAlignRight.Click += mnuAlignRight_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(207, 6);
            // 
            // mnuInsertImage
            // 
            mnuInsertImage.Name = "mnuInsertImage";
            mnuInsertImage.Size = new Size(210, 22);
            mnuInsertImage.Text = "Вставити зображення...";
            mnuInsertImage.Click += mnuInsertImage_Click;
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical, mnuArrangeIcons });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(49, 20);
            mnuWindow.Text = "Вікно";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(211, 22);
            mnuCascade.Text = "Каскадом";
            mnuCascade.Click += mnuCascade_Click;
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(211, 22);
            mnuTileHorizontal.Text = "Плиткою горизонтально";
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(211, 22);
            mnuTileVertical.Text = "Плиткою вертикально";
            mnuTileVertical.Click += mnuTileVertical_Click;
            // 
            // mnuArrangeIcons
            // 
            mnuArrangeIcons.Name = "mnuArrangeIcons";
            mnuArrangeIcons.Size = new Size(211, 22);
            mnuArrangeIcons.Text = "Впорядкувати значки";
            mnuArrangeIcons.Click += mnuArrangeIcons_Click;
            // 
            // mnuLanguage
            // 
            mnuLanguage.DropDownItems.AddRange(new ToolStripItem[] { mnuLangUk, mnuLangEn, mnuLangDe });
            mnuLanguage.Name = "mnuLanguage";
            mnuLanguage.Size = new Size(46, 20);
            mnuLanguage.Text = "Мова";
            // 
            // mnuLangUk
            // 
            mnuLangUk.Checked = true;
            mnuLangUk.CheckState = CheckState.Checked;
            mnuLangUk.Name = "mnuLangUk";
            mnuLangUk.Size = new Size(139, 22);
            mnuLangUk.Text = "Українська";
            mnuLangUk.Click += mnuLangUk_Click;
            // 
            // mnuLangEn
            // 
            mnuLangEn.Name = "mnuLangEn";
            mnuLangEn.Size = new Size(139, 22);
            mnuLangEn.Text = "English";
            mnuLangEn.Click += mnuLangEn_Click;
            // 
            // mnuLangDe
            // 
            mnuLangDe.Name = "mnuLangDe";
            mnuLangDe.Size = new Size(139, 22);
            mnuLangDe.Text = "Deutsch";
            mnuLangDe.Click += mnuLangDe_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(61, 20);
            mnuHelp.Text = "Довідка";
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(163, 22);
            mnuAbout.Text = "Про програму...";
            mnuAbout.Click += mnuAbout_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tbNew, tbOpen, tbSave, toolStripSeparator4, tbCut, tbCopy, tbPaste, toolStripSeparator6, tbAlignLeft, tbAlignCenter, tbAlignRight, toolStripSeparator7, tbInsertImage, tbSyntaxHighlight });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(900, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tbNew
            // 
            tbNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbNew.Name = "tbNew";
            tbNew.Size = new Size(47, 22);
            tbNew.Text = "Новий";
            tbNew.ToolTipText = "Новий документ";
            tbNew.Click += mnuNew_Click;
            // 
            // tbOpen
            // 
            tbOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbOpen.Name = "tbOpen";
            tbOpen.Size = new Size(59, 22);
            tbOpen.Text = "Відкрити";
            tbOpen.ToolTipText = "Відкрити файл";
            tbOpen.Click += mnuOpen_Click;
            // 
            // tbSave
            // 
            tbSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbSave.Name = "tbSave";
            tbSave.Size = new Size(61, 22);
            tbSave.Text = "Зберегти";
            tbSave.ToolTipText = "Зберегти файл";
            tbSave.Click += mnuSave_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // tbCut
            // 
            tbCut.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbCut.Name = "tbCut";
            tbCut.Size = new Size(58, 22);
            tbCut.Text = "Вирізати";
            tbCut.ToolTipText = "Вирізати";
            tbCut.Click += mnuCut_Click;
            // 
            // tbCopy
            // 
            tbCopy.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbCopy.Name = "tbCopy";
            tbCopy.Size = new Size(69, 22);
            tbCopy.Text = "Копіювати";
            tbCopy.ToolTipText = "Копіювати";
            tbCopy.Click += mnuCopy_Click;
            // 
            // tbPaste
            // 
            tbPaste.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbPaste.Name = "tbPaste";
            tbPaste.Size = new Size(60, 22);
            tbPaste.Text = "Вставити";
            tbPaste.ToolTipText = "Вставити";
            tbPaste.Click += mnuPaste_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // tbAlignLeft
            // 
            tbAlignLeft.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbAlignLeft.Name = "tbAlignLeft";
            tbAlignLeft.Size = new Size(23, 22);
            tbAlignLeft.Text = "←";
            tbAlignLeft.ToolTipText = "За лівим краєм";
            tbAlignLeft.Click += mnuAlignLeft_Click;
            // 
            // tbAlignCenter
            // 
            tbAlignCenter.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbAlignCenter.Name = "tbAlignCenter";
            tbAlignCenter.Size = new Size(23, 22);
            tbAlignCenter.Text = "↔";
            tbAlignCenter.ToolTipText = "По центру";
            tbAlignCenter.Click += mnuAlignCenter_Click;
            // 
            // tbAlignRight
            // 
            tbAlignRight.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbAlignRight.Name = "tbAlignRight";
            tbAlignRight.Size = new Size(23, 22);
            tbAlignRight.Text = "→";
            tbAlignRight.ToolTipText = "За правим краєм";
            tbAlignRight.Click += mnuAlignRight_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 25);
            // 
            // tbInsertImage
            // 
            tbInsertImage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbInsertImage.Name = "tbInsertImage";
            tbInsertImage.Size = new Size(23, 22);
            tbInsertImage.Text = "🖼";
            tbInsertImage.ToolTipText = "Вставити зображення";
            tbInsertImage.Click += mnuInsertImage_Click;
            // 
            // tbSyntaxHighlight
            // 
            tbSyntaxHighlight.CheckOnClick = true;
            tbSyntaxHighlight.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tbSyntaxHighlight.Name = "tbSyntaxHighlight";
            tbSyntaxHighlight.Size = new Size(23, 22);
            tbSyntaxHighlight.Text = "C#";
            tbSyntaxHighlight.ToolTipText = "Підсвічування синтаксису C#";
            tbSyntaxHighlight.Click += tbSyntaxHighlight_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sbAmount, sbTime });
            statusStrip1.Location = new Point(0, 478);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(900, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // sbAmount
            // 
            sbAmount.Name = "sbAmount";
            sbAmount.Size = new Size(122, 17);
            sbAmount.Text = "Кількість символів: 0";
            // 
            // sbTime
            // 
            sbTime.Name = "sbTime";
            sbTime.Size = new Size(765, 17);
            sbTime.Spring = true;
            sbTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 79);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 399);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cmnuCut, cmnuCopy, cmnuPaste, cmnuDelete, toolStripSeparator5, cmnuSelectAll });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(145, 120);
            // 
            // cmnuCut
            // 
            cmnuCut.Name = "cmnuCut";
            cmnuCut.Size = new Size(144, 22);
            cmnuCut.Text = "Вирізати";
            cmnuCut.Click += mnuCut_Click;
            // 
            // cmnuCopy
            // 
            cmnuCopy.Name = "cmnuCopy";
            cmnuCopy.Size = new Size(144, 22);
            cmnuCopy.Text = "Копіювати";
            cmnuCopy.Click += mnuCopy_Click;
            // 
            // cmnuPaste
            // 
            cmnuPaste.Name = "cmnuPaste";
            cmnuPaste.Size = new Size(144, 22);
            cmnuPaste.Text = "Вставити";
            cmnuPaste.Click += mnuPaste_Click;
            // 
            // cmnuDelete
            // 
            cmnuDelete.Name = "cmnuDelete";
            cmnuDelete.Size = new Size(144, 22);
            cmnuDelete.Text = "Видалити";
            cmnuDelete.Click += mnuDelete_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(141, 6);
            // 
            // cmnuSelectAll
            // 
            cmnuSelectAll.Name = "cmnuSelectAll";
            cmnuSelectAll.Size = new Size(144, 22);
            cmnuSelectAll.Text = "Виділити все";
            cmnuSelectAll.Click += mnuSelectAll_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "RTF файли (*.rtf)|*.rtf|Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "RTF файли (*.rtf)|*.rtf|Текстові файли (*.txt)|*.txt|Усі файли (*.*)|*.*";
            // 
            // openFileDialogImage
            // 
            openFileDialogImage.Filter = "Зображення (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif|Усі файли (*.*)|*.*";
            // 
            // panelFind
            // 
            panelFind.Controls.Add(btnFindClose);
            panelFind.Controls.Add(btnFindNext);
            panelFind.Controls.Add(chkMatchCase);
            panelFind.Controls.Add(chkWholeWord);
            panelFind.Controls.Add(txtFind);
            panelFind.Controls.Add(lblFind);
            panelFind.Dock = DockStyle.Top;
            panelFind.Location = new Point(0, 49);
            panelFind.Margin = new Padding(3, 2, 3, 2);
            panelFind.Name = "panelFind";
            panelFind.Size = new Size(900, 30);
            panelFind.TabIndex = 4;
            panelFind.Visible = false;
            // 
            // btnFindClose
            // 
            btnFindClose.Location = new Point(721, 5);
            btnFindClose.Margin = new Padding(3, 2, 3, 2);
            btnFindClose.Name = "btnFindClose";
            btnFindClose.Size = new Size(66, 20);
            btnFindClose.TabIndex = 5;
            btnFindClose.Text = "Закрити";
            btnFindClose.UseVisualStyleBackColor = true;
            btnFindClose.Click += btnFindClose_Click;
            // 
            // btnFindNext
            // 
            btnFindNext.Location = new Point(332, 5);
            btnFindNext.Margin = new Padding(3, 2, 3, 2);
            btnFindNext.Name = "btnFindNext";
            btnFindNext.Size = new Size(79, 20);
            btnFindNext.TabIndex = 4;
            btnFindNext.Text = "Знайти далі";
            btnFindNext.UseVisualStyleBackColor = true;
            btnFindNext.Click += btnFindNext_Click;
            // 
            // chkMatchCase
            // 
            chkMatchCase.AutoSize = true;
            chkMatchCase.Location = new Point(508, 8);
            chkMatchCase.Margin = new Padding(3, 2, 3, 2);
            chkMatchCase.Name = "chkMatchCase";
            chkMatchCase.Size = new Size(136, 19);
            chkMatchCase.TabIndex = 3;
            chkMatchCase.Text = "Враховувати регістр";
            chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkWholeWord
            // 
            chkWholeWord.AutoSize = true;
            chkWholeWord.Location = new Point(416, 8);
            chkWholeWord.Margin = new Padding(3, 2, 3, 2);
            chkWholeWord.Name = "chkWholeWord";
            chkWholeWord.Size = new Size(103, 19);
            chkWholeWord.TabIndex = 2;
            chkWholeWord.Text = "Слово цілком";
            chkWholeWord.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(66, 7);
            txtFind.Margin = new Padding(3, 2, 3, 2);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(263, 23);
            txtFind.TabIndex = 1;
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Location = new Point(9, 9);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(49, 15);
            lblFind.TabIndex = 0;
            lblFind.Text = "Знайти:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(tabControl1);
            Controls.Add(panelFind);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Блокнот";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            panelFind.ResumeLayout(false);
            panelFind.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertImage;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuLanguage;
        private System.Windows.Forms.ToolStripMenuItem mnuLangUk;
        private System.Windows.Forms.ToolStripMenuItem mnuLangEn;
        private System.Windows.Forms.ToolStripMenuItem mnuLangDe;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbNew;
        private System.Windows.Forms.ToolStripButton tbOpen;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbCut;
        private System.Windows.Forms.ToolStripButton tbCopy;
        private System.Windows.Forms.ToolStripButton tbPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tbAlignLeft;
        private System.Windows.Forms.ToolStripButton tbAlignCenter;
        private System.Windows.Forms.ToolStripButton tbAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tbInsertImage;
        private System.Windows.Forms.ToolStripButton tbSyntaxHighlight;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbAmount;
        private System.Windows.Forms.ToolStripStatusLabel sbTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnuCut;
        private System.Windows.Forms.ToolStripMenuItem cmnuCopy;
        private System.Windows.Forms.ToolStripMenuItem cmnuPaste;
        private System.Windows.Forms.ToolStripMenuItem cmnuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cmnuSelectAll;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Button btnFindClose;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.CheckBox chkWholeWord;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblFind;
    }
}
