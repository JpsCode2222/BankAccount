namespace BankAccount
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            createAccountBtn = new Button();
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            depositBtn = new Button();
            withdrawBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 16);
            label1.Name = "label1";
            label1.Size = new Size(237, 35);
            label1.TabIndex = 0;
            label1.Text = "Bank Accounts";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 65);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 106);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 2;
            label2.Text = "Owner :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(126, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 32);
            textBox1.TabIndex = 1;
            // 
            // createAccountBtn
            // 
            createAccountBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccountBtn.Location = new Point(67, 163);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(164, 41);
            createAccountBtn.TabIndex = 2;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(347, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(441, 257);
            dataGridView1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(126, 382);
            numericUpDown1.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(187, 32);
            numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 382);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 7;
            label3.Text = "Amount :";
            // 
            // depositBtn
            // 
            depositBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            depositBtn.Location = new Point(398, 376);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(164, 41);
            depositBtn.TabIndex = 4;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = true;
            // 
            // withdrawBtn
            // 
            withdrawBtn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            withdrawBtn.Location = new Point(584, 376);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(164, 41);
            withdrawBtn.TabIndex = 5;
            withdrawBtn.Text = "Withdraw";
            withdrawBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(withdrawBtn);
            Controls.Add(depositBtn);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Controls.Add(createAccountBtn);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Button createAccountBtn;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button depositBtn;
        private Button withdrawBtn;
    }
}
