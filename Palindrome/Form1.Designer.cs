
namespace OTFI1B_Parinas_Palindrome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.word1 = new System.Windows.Forms.TextBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.TxtOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anjo OnlyFans";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter word:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // word1
            // 
            this.word1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word1.Location = new System.Drawing.Point(86, 124);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(234, 27);
            this.word1.TabIndex = 2;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(171, 177);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(75, 27);
            this.CheckBtn.TabIndex = 3;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(86, 220);
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.ReadOnly = true;
            this.TxtOut.Size = new System.Drawing.Size(234, 27);
            this.TxtOut.TabIndex = 5;
            this.TxtOut.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 359);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.word1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Palindrome Determination";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox word1;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.TextBox TxtOut;
    }
}

