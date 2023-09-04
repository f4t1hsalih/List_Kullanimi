namespace List_Kullanimi
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
            btnListele1 = new Button();
            btnListele2 = new Button();
            btnListele3 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // btnListele1
            // 
            btnListele1.Location = new Point(12, 337);
            btnListele1.Name = "btnListele1";
            btnListele1.Size = new Size(193, 35);
            btnListele1.TabIndex = 0;
            btnListele1.Text = "Listele 1";
            btnListele1.UseVisualStyleBackColor = true;
            btnListele1.Click += btnListele1_Click;
            // 
            // btnListele2
            // 
            btnListele2.Location = new Point(225, 337);
            btnListele2.Name = "btnListele2";
            btnListele2.Size = new Size(193, 35);
            btnListele2.TabIndex = 1;
            btnListele2.Text = "Listele 2";
            btnListele2.UseVisualStyleBackColor = true;
            btnListele2.Click += btnListele2_Click;
            // 
            // btnListele3
            // 
            btnListele3.Location = new Point(437, 337);
            btnListele3.Name = "btnListele3";
            btnListele3.Size = new Size(193, 35);
            btnListele3.TabIndex = 2;
            btnListele3.Text = "Listele 3";
            btnListele3.UseVisualStyleBackColor = true;
            btnListele3.Click += btnListele3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(193, 319);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(225, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(193, 319);
            listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 21;
            listBox3.Location = new Point(437, 12);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(193, 319);
            listBox3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(211, 219, 193);
            ClientSize = new Size(646, 386);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnListele3);
            Controls.Add(btnListele2);
            Controls.Add(btnListele1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(34, 52, 77);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Kullanımı";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListele1;
        private Button btnListele2;
        private Button btnListele3;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}