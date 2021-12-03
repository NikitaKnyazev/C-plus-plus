namespace sqlite
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editButton = new System.Windows.Forms.Button();
            this.ereaseButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.inputButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.boolLabel = new System.Windows.Forms.Label();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(336, 297);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(107, 35);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Редактирование таблицы";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ereaseButton
            // 
            this.ereaseButton.Location = new System.Drawing.Point(255, 297);
            this.ereaseButton.Name = "ereaseButton";
            this.ereaseButton.Size = new System.Drawing.Size(75, 35);
            this.ereaseButton.TabIndex = 10;
            this.ereaseButton.Text = "Очистка";
            this.ereaseButton.UseVisualStyleBackColor = true;
            this.ereaseButton.Click += new System.EventHandler(this.ereaseButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(174, 297);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 35);
            this.readButton.TabIndex = 9;
            this.readButton.Text = "Считать таблицу";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(93, 297);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(75, 35);
            this.inputButton.TabIndex = 7;
            this.inputButton.Text = "Добавить записи";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 297);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 35);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Создать таблицу";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // boolLabel
            // 
            this.boolLabel.AutoSize = true;
            this.boolLabel.Location = new System.Drawing.Point(9, 365);
            this.boolLabel.Name = "boolLabel";
            this.boolLabel.Size = new System.Drawing.Size(70, 13);
            this.boolLabel.TabIndex = 14;
            this.boolLabel.Text = "SQL запрос:";
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdTextBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdTextBox.Location = new System.Drawing.Point(85, 362);
            this.cmdTextBox.Multiline = true;
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cmdTextBox.Size = new System.Drawing.Size(614, 78);
            this.cmdTextBox.TabIndex = 15;
            this.cmdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainTextBox_KeyDown);
            this.cmdTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmdTextBox_MouseDoubleClick);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(714, 359);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(49, 23);
            this.okButton.TabIndex = 18;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(544, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Вывод таблицы в датагрид";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(691, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 22;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "BDCreate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Location = new System.Drawing.Point(4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(762, 259);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 24;
            // 
            // mainTextBox
            // 
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.Location = new System.Drawing.Point(0, 0);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTextBox.Size = new System.Drawing.Size(365, 259);
            this.mainTextBox.TabIndex = 13;
            this.mainTextBox.Text = "SELECT * FROM accel\r\nSELECT * FROM exp\r\nSELECT * FROM prt\r\nSELECT * FROM pnt\r\n";
            this.mainTextBox.WordWrap = false;
            this.mainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainTextBox_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 259);
            this.dataGridView1.TabIndex = 20;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 474);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.boolLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.ereaseButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.createButton);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "mainForm";
            this.Text = "Пример использования SQLite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button ereaseButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label boolLabel;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

