
namespace LondonBaku_Homework_
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
            this.BakuBtn = new System.Windows.Forms.Button();
            this.LondonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BakuBtn
            // 
            this.BakuBtn.Location = new System.Drawing.Point(105, 370);
            this.BakuBtn.Name = "BakuBtn";
            this.BakuBtn.Size = new System.Drawing.Size(75, 23);
            this.BakuBtn.TabIndex = 0;
            this.BakuBtn.Text = "Baku";
            this.BakuBtn.UseVisualStyleBackColor = true;
            this.BakuBtn.Click += new System.EventHandler(this.BakuBtn_Click);
            this.BakuBtn.MouseEnter += new System.EventHandler(this.BakuBtn_MouseEnter);
            this.BakuBtn.MouseLeave += new System.EventHandler(this.BakuBtn_MouseLeave);
            // 
            // LondonBtn
            // 
            this.LondonBtn.Location = new System.Drawing.Point(365, 370);
            this.LondonBtn.Name = "LondonBtn";
            this.LondonBtn.Size = new System.Drawing.Size(75, 23);
            this.LondonBtn.TabIndex = 1;
            this.LondonBtn.Text = "London";
            this.LondonBtn.UseVisualStyleBackColor = true;
            this.LondonBtn.Click += new System.EventHandler(this.LondonBtn_Click);
            this.LondonBtn.MouseEnter += new System.EventHandler(this.LondonBtn_MouseEnter);
            this.LondonBtn.MouseLeave += new System.EventHandler(this.LondonBtn_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.LondonBtn);
            this.Controls.Add(this.BakuBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BakuBtn;
        private System.Windows.Forms.Button LondonBtn;
    }
}

