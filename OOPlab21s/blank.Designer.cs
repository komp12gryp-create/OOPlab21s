namespace OOPlab21s
{
    partial class blank
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
            contextMenu1 = new ContextMenuStrip(components);
            cmnuCut = new ToolStripMenuItem();
            cmnuCopy = new ToolStripMenuItem();
            cmnuPaste = new ToolStripMenuItem();
            cmnuDelete = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            cmnuSelectAll = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            statusBar1 = new StatusStrip();
            sbAmount = new ToolStripStatusLabel();
            sbTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenu1.SuspendLayout();
            statusBar1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenu1
            // 
            contextMenu1.Items.AddRange(new ToolStripItem[] { cmnuCut, cmnuCopy, cmnuPaste, cmnuDelete, toolStripSeparator1, cmnuSelectAll });
            contextMenu1.Name = "contextMenu1";
            contextMenu1.Size = new Size(145, 120);
            // 
            // cmnuCut
            // 
            cmnuCut.Name = "cmnuCut";
            cmnuCut.Size = new Size(144, 22);
            cmnuCut.Text = "Вирізати";
            cmnuCut.Click += cmnuCut_Click;
            // 
            // cmnuCopy
            // 
            cmnuCopy.Name = "cmnuCopy";
            cmnuCopy.Size = new Size(144, 22);
            cmnuCopy.Text = "Копіювати";
            cmnuCopy.Click += cmnuCopy_Click;
            // 
            // cmnuPaste
            // 
            cmnuPaste.Name = "cmnuPaste";
            cmnuPaste.Size = new Size(144, 22);
            cmnuPaste.Text = "Вставити";
            cmnuPaste.Click += cmnuPaste_Click;
            // 
            // cmnuDelete
            // 
            cmnuDelete.Name = "cmnuDelete";
            cmnuDelete.Size = new Size(144, 22);
            cmnuDelete.Text = "Видалити";
            cmnuDelete.Click += cmnuDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(141, 6);
            // 
            // cmnuSelectAll
            // 
            cmnuSelectAll.Name = "cmnuSelectAll";
            cmnuSelectAll.Size = new Size(144, 22);
            cmnuSelectAll.Text = "Виділити все";
            cmnuSelectAll.Click += cmnuSelectAll_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.ContextMenuStrip = contextMenu1;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(600, 356);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // statusBar1
            // 
            statusBar1.Items.AddRange(new ToolStripItem[] { sbAmount, sbTime });
            statusBar1.Location = new Point(0, 356);
            statusBar1.Name = "statusBar1";
            statusBar1.Size = new Size(600, 22);
            statusBar1.TabIndex = 1;
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
            sbTime.Size = new Size(463, 17);
            sbTime.Spring = true;
            sbTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // blank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 378);
            Controls.Add(richTextBox1);
            Controls.Add(statusBar1);
            Name = "blank";
            Text = "blank";
            Load += blank_Load;
            contextMenu1.ResumeLayout(false);
            statusBar1.ResumeLayout(false);
            statusBar1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox richTextBox1;
        private ContextMenuStrip contextMenu1;
        private ToolStripMenuItem cmnuCut;
        private ToolStripMenuItem cmnuCopy;
        private ToolStripMenuItem cmnuPaste;
        private ToolStripMenuItem cmnuDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem cmnuSelectAll;
        private StatusStrip statusBar1;
        private ToolStripStatusLabel sbAmount;
        private ToolStripStatusLabel sbTime;
        private System.Windows.Forms.Timer timer1;
    }
}
