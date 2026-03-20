namespace lr_3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button = new System.Windows.Forms.Button();
            this.TextRichBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKol_vo = new System.Windows.Forms.Label();
            this.buttonOt = new System.Windows.Forms.Button();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductListBox
            // 
            this.ProductListBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProductListBox.BackColor = System.Drawing.Color.Pink;
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.Location = new System.Drawing.Point(1, 7);
            this.ProductListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(108, 355);
            this.ProductListBox.TabIndex = 0;
            this.ProductListBox.SelectedIndexChanged += new System.EventHandler(this.ProductListBox_SelectedIndexChanged);
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.BackColor = System.Drawing.Color.Pink;
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(368, 11);
            this.ProductComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(195, 21);
            this.ProductComboBox.TabIndex = 1;
            this.ProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена за кг:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(528, 64);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 13);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Срок годности (в днях):";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(528, 131);
            this.DataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(35, 13);
            this.DataLabel.TabIndex = 7;
            this.DataLabel.Text = "label6";
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Location = new System.Drawing.Point(134, 12);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(206, 259);
            this.FotoPictureBox.TabIndex = 8;
            this.FotoPictureBox.TabStop = false;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button.Location = new System.Drawing.Point(388, 248);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(105, 23);
            this.button.TabIndex = 9;
            this.button.Text = "Заказать";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // TextRichBox
            // 
            this.TextRichBox.BackColor = System.Drawing.Color.Pink;
            this.TextRichBox.Location = new System.Drawing.Point(107, 294);
            this.TextRichBox.Name = "TextRichBox";
            this.TextRichBox.Size = new System.Drawing.Size(495, 68);
            this.TextRichBox.TabIndex = 10;
            this.TextRichBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество:";
            // 
            // labelKol_vo
            // 
            this.labelKol_vo.AutoSize = true;
            this.labelKol_vo.Location = new System.Drawing.Point(531, 100);
            this.labelKol_vo.Name = "labelKol_vo";
            this.labelKol_vo.Size = new System.Drawing.Size(35, 13);
            this.labelKol_vo.TabIndex = 12;
            this.labelKol_vo.Text = "label2";
            // 
            // buttonOt
            // 
            this.buttonOt.Location = new System.Drawing.Point(499, 248);
            this.buttonOt.Name = "buttonOt";
            this.buttonOt.Size = new System.Drawing.Size(75, 23);
            this.buttonOt.TabIndex = 13;
            this.buttonOt.Text = "Отчёт";
            this.buttonOt.UseVisualStyleBackColor = true;
            this.buttonOt.Click += new System.EventHandler(this.buttonOt_Click);
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(454, 211);
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDown.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.buttonOt);
            this.Controls.Add(this.labelKol_vo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextRichBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.FotoPictureBox);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.ProductListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductListBox;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.PictureBox FotoPictureBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RichTextBox TextRichBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKol_vo;
        private System.Windows.Forms.Button buttonOt;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
    }
}

