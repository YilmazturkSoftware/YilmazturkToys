namespace Yilmazturk_Toys
{
    partial class Duzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duzenle));
            this.yilmazturkShadow1 = new YilmazturkUI.YilmazturkShadow();
            this.yilmazturkMoveControl1 = new YilmazturkUI.YilmazturkMoveControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.duzenleBtn = new YilmazturkUI.YilmazturkAdvancedButton();
            this.silBtn = new YilmazturkUI.YilmazturkAdvancedButton();
            this.SuspendLayout();
            // 
            // yilmazturkShadow1
            // 
            this.yilmazturkShadow1.Location = new System.Drawing.Point(731, 513);
            this.yilmazturkShadow1.Name = "yilmazturkShadow1";
            this.yilmazturkShadow1.Size = new System.Drawing.Size(33, 10);
            this.yilmazturkShadow1.TabIndex = 4;
            this.yilmazturkShadow1.TargetControl = this;
            this.yilmazturkShadow1.Text = "yilmazturkShadow1";
            // 
            // yilmazturkMoveControl1
            // 
            this.yilmazturkMoveControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tuşları düzenle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Atanan tuşlar;";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(20, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 360);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // duzenleBtn
            // 
            this.duzenleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.duzenleBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.duzenleBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(240)))));
            this.duzenleBtn.BorderRadius = 20;
            this.duzenleBtn.BorderSize = 2;
            this.duzenleBtn.FlatAppearance.BorderSize = 0;
            this.duzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duzenleBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duzenleBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.duzenleBtn.Location = new System.Drawing.Point(396, 132);
            this.duzenleBtn.Name = "duzenleBtn";
            this.duzenleBtn.Size = new System.Drawing.Size(368, 41);
            this.duzenleBtn.TabIndex = 14;
            this.duzenleBtn.Text = "Düzenle";
            this.duzenleBtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.duzenleBtn.UseVisualStyleBackColor = false;
            this.duzenleBtn.Visible = false;
            this.duzenleBtn.Click += new System.EventHandler(this.duzenleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.silBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.silBtn.BorderColor = System.Drawing.Color.Red;
            this.silBtn.BorderRadius = 20;
            this.silBtn.BorderSize = 2;
            this.silBtn.FlatAppearance.BorderSize = 0;
            this.silBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silBtn.ForeColor = System.Drawing.Color.Red;
            this.silBtn.Location = new System.Drawing.Point(396, 190);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(368, 41);
            this.silBtn.TabIndex = 15;
            this.silBtn.Text = "Sil";
            this.silBtn.TextColor = System.Drawing.Color.Red;
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Visible = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // Duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(789, 535);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.duzenleBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yilmazturkShadow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Duzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tuşları düzenle";
            this.Load += new System.EventHandler(this.Duzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public YilmazturkUI.YilmazturkShadow yilmazturkShadow1;
        public YilmazturkUI.YilmazturkMoveControl yilmazturkMoveControl1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox1;
        private YilmazturkUI.YilmazturkAdvancedButton duzenleBtn;
        private YilmazturkUI.YilmazturkAdvancedButton silBtn;
    }
}