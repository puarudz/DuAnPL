namespace DuAn1
{
    partial class Form1
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
            this.soa = new System.Windows.Forms.TextBox();
            this.sob = new System.Windows.Forms.TextBox();
            this.Cong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Tru = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soa
            // 
            this.soa.Location = new System.Drawing.Point(87, 12);
            this.soa.Name = "soa";
            this.soa.Size = new System.Drawing.Size(100, 20);
            this.soa.TabIndex = 0;
            this.soa.Text = "Số A";
            // 
            // sob
            // 
            this.sob.Location = new System.Drawing.Point(87, 39);
            this.sob.Name = "sob";
            this.sob.Size = new System.Drawing.Size(100, 20);
            this.sob.TabIndex = 1;
            this.sob.Text = "Số B";
            // 
            // Cong
            // 
            this.Cong.Location = new System.Drawing.Point(40, 98);
            this.Cong.Name = "Cong";
            this.Cong.Size = new System.Drawing.Size(45, 23);
            this.Cong.TabIndex = 2;
            this.Cong.Text = "Cong";
            this.Cong.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Chia";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Tru
            // 
            this.Tru.Location = new System.Drawing.Point(91, 98);
            this.Tru.Name = "Tru";
            this.Tru.Size = new System.Drawing.Size(45, 23);
            this.Tru.TabIndex = 4;
            this.Tru.Text = "Tru";
            this.Tru.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Nhan";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Tru);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cong);
            this.Controls.Add(this.sob);
            this.Controls.Add(this.soa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox soa;
        private System.Windows.Forms.TextBox sob;
        private System.Windows.Forms.Button Cong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Tru;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

