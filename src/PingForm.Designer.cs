namespace Ping_projekt_SK
{
    partial class PingForm
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
            btnPing = new Button();
            lblAddress = new Label();
            lstReplies = new ListBox();
            nudPacketCount = new NumericUpDown();
            lblCount = new Label();
            lblTTL = new Label();
            nudTTL = new NumericUpDown();
            txtCurrent = new TextBox();
            lblAddressList = new Label();
            lstAddresses = new ListBox();
            label5 = new Label();
            txtNew = new TextBox();
            btnAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnClear = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nudPacketCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTTL).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnPing
            // 
            btnPing.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPing.Location = new Point(147, 6);
            btnPing.Margin = new Padding(3, 6, 3, 3);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(78, 25);
            btnPing.TabIndex = 0;
            btnPing.Text = "Ping!";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_Click;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(3, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(40, 39);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Adres";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstReplies
            // 
            lstReplies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstReplies.FormattingEnabled = true;
            lstReplies.ItemHeight = 15;
            lstReplies.Location = new Point(3, 43);
            lstReplies.MinimumSize = new Size(288, 214);
            lstReplies.Name = "lstReplies";
            lstReplies.Size = new Size(310, 274);
            lstReplies.TabIndex = 2;
            // 
            // nudPacketCount
            // 
            nudPacketCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudPacketCount.Location = new Point(85, 3);
            nudPacketCount.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudPacketCount.Name = "nudPacketCount";
            nudPacketCount.Size = new Size(90, 23);
            nudPacketCount.TabIndex = 3;
            nudPacketCount.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCount.AutoSize = true;
            lblCount.Location = new Point(3, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(76, 15);
            lblCount.TabIndex = 4;
            lblCount.Text = "Powtórzenia:";
            lblCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTTL
            // 
            lblTTL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTTL.AutoSize = true;
            lblTTL.Location = new Point(181, 0);
            lblTTL.Name = "lblTTL";
            lblTTL.Size = new Size(30, 15);
            lblTTL.TabIndex = 5;
            lblTTL.Text = "TTL:";
            lblTTL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudTTL
            // 
            nudTTL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudTTL.Location = new Point(217, 3);
            nudTTL.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudTTL.Name = "nudTTL";
            nudTTL.Size = new Size(90, 23);
            nudTTL.TabIndex = 6;
            nudTTL.Value = new decimal(new int[] { 56, 0, 0, 0 });
            // 
            // txtCurrent
            // 
            txtCurrent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCurrent.Location = new Point(49, 7);
            txtCurrent.Margin = new Padding(3, 7, 3, 3);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(92, 23);
            txtCurrent.TabIndex = 7;
            // 
            // lblAddressList
            // 
            lblAddressList.AutoSize = true;
            lblAddressList.Location = new Point(319, 15);
            lblAddressList.Margin = new Padding(3, 15, 3, 0);
            lblAddressList.Name = "lblAddressList";
            lblAddressList.Size = new Size(76, 15);
            lblAddressList.TabIndex = 8;
            lblAddressList.Text = "Lista hostów:";
            lblAddressList.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstAddresses
            // 
            lstAddresses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstAddresses.FormattingEnabled = true;
            lstAddresses.ItemHeight = 15;
            lstAddresses.Location = new Point(3, 3);
            lstAddresses.Name = "lstAddresses";
            lstAddresses.Size = new Size(202, 229);
            lstAddresses.TabIndex = 9;
            lstAddresses.Click += lstAddresses_Click;
            lstAddresses.DoubleClick += lstAddresses_DoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 227);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 10;
            label5.Text = "Nowy host:";
            // 
            // txtNew
            // 
            txtNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNew.Location = new Point(3, 253);
            txtNew.Margin = new Padding(3, 8, 3, 3);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(202, 23);
            txtNew.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.Location = new Point(319, 326);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(208, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblCount, 0, 0);
            tableLayoutPanel1.Controls.Add(nudPacketCount, 1, 0);
            tableLayoutPanel1.Controls.Add(nudTTL, 3, 0);
            tableLayoutPanel1.Controls.Add(lblTTL, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 326);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.Size = new Size(310, 29);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            tableLayoutPanel2.Controls.Add(lblAddress, 0, 0);
            tableLayoutPanel2.Controls.Add(txtCurrent, 1, 0);
            tableLayoutPanel2.Controls.Add(btnClear, 3, 0);
            tableLayoutPanel2.Controls.Add(btnPing, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.MaximumSize = new Size(0, 39);
            tableLayoutPanel2.MinimumSize = new Size(290, 39);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(310, 39);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Location = new Point(231, 6);
            btnClear.Margin = new Padding(3, 6, 3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(76, 25);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.73535F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.26465F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(btnAdd, 1, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel3.Controls.Add(lstReplies, 0, 1);
            tableLayoutPanel3.Controls.Add(lblAddressList, 1, 0);
            tableLayoutPanel3.Location = new Point(12, 1);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.Size = new Size(530, 358);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(lstAddresses, 0, 0);
            tableLayoutPanel4.Controls.Add(txtNew, 0, 1);
            tableLayoutPanel4.Location = new Point(319, 43);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.Size = new Size(208, 277);
            tableLayoutPanel4.TabIndex = 16;
            // 
            // PingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 371);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label5);
            MinimumSize = new Size(570, 410);
            Name = "PingForm";
            Text = "Ping app";
            ((System.ComponentModel.ISupportInitialize)nudPacketCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTTL).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPing;
        private Label lblAddress;
        private ListBox lstReplies;
        private NumericUpDown nudPacketCount;
        private Label lblCount;
        private Label lblTTL;
        private NumericUpDown nudTTL;
        private TextBox txtCurrent;
        private Label lblAddressList;
        private ListBox lstAddresses;
        private Label label5;
        private TextBox txtNew;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnClear;
    }
}
