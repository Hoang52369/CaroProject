
namespace Cờ_Caro
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
            this.panelChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLan = new System.Windows.Forms.Button();
            this.pictureMark = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChessBoard
            // 
            this.panelChessBoard.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelChessBoard.Location = new System.Drawing.Point(13, 13);
            this.panelChessBoard.Name = "panelChessBoard";
            this.panelChessBoard.Size = new System.Drawing.Size(677, 499);
            this.panelChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureAvatar);
            this.panel2.Location = new System.Drawing.Point(697, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 276);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.pictureMark);
            this.panel3.Controls.Add(this.btnLan);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Location = new System.Drawing.Point(697, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 216);
            this.panel3.TabIndex = 2;
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureAvatar.Image = global::Cờ_Caro.Properties.Resources.licensed_image__1_;
            this.pictureAvatar.Location = new System.Drawing.Point(0, 0);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(300, 273);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAvatar.TabIndex = 0;
            this.pictureAvatar.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-1, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-1, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnLan
            // 
            this.btnLan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLan.Location = new System.Drawing.Point(50, 85);
            this.btnLan.Name = "btnLan";
            this.btnLan.Size = new System.Drawing.Size(85, 23);
            this.btnLan.TabIndex = 3;
            this.btnLan.Text = "Connect\r\n";
            this.btnLan.UseVisualStyleBackColor = true;
            // 
            // pictureMark
            // 
            this.pictureMark.Location = new System.Drawing.Point(184, 4);
            this.pictureMark.Name = "pictureMark";
            this.pictureMark.Size = new System.Drawing.Size(116, 75);
            this.pictureMark.TabIndex = 4;
            this.pictureMark.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChessBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.PictureBox pictureMark;
        private System.Windows.Forms.Button btnLan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtName;
    }
}

