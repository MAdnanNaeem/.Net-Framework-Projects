
namespace CricketGame
{
    partial class CricketGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_rScore = new System.Windows.Forms.TextBox();
            this.btn_gScore = new System.Windows.Forms.Button();
            this.txt_balls = new System.Windows.Forms.TextBox();
            this.txt_Over = new System.Windows.Forms.TextBox();
            this.txt_pScore = new System.Windows.Forms.TextBox();
            this.txt_cScore = new System.Windows.Forms.TextBox();
            this.rtb_team2 = new System.Windows.Forms.RichTextBox();
            this.rtb_team1 = new System.Windows.Forms.RichTextBox();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_target);
            this.panel1.Controls.Add(this.txt_rScore);
            this.panel1.Controls.Add(this.btn_gScore);
            this.panel1.Controls.Add(this.txt_balls);
            this.panel1.Controls.Add(this.txt_Over);
            this.panel1.Controls.Add(this.txt_pScore);
            this.panel1.Controls.Add(this.txt_cScore);
            this.panel1.Controls.Add(this.rtb_team2);
            this.panel1.Controls.Add(this.rtb_team1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 688);
            this.panel1.TabIndex = 0;
            // 
            // txt_rScore
            // 
            this.txt_rScore.Location = new System.Drawing.Point(999, 231);
            this.txt_rScore.Multiline = true;
            this.txt_rScore.Name = "txt_rScore";
            this.txt_rScore.Size = new System.Drawing.Size(132, 54);
            this.txt_rScore.TabIndex = 7;
            // 
            // btn_gScore
            // 
            this.btn_gScore.Location = new System.Drawing.Point(1011, 320);
            this.btn_gScore.Name = "btn_gScore";
            this.btn_gScore.Size = new System.Drawing.Size(109, 47);
            this.btn_gScore.TabIndex = 6;
            this.btn_gScore.Text = "button1";
            this.btn_gScore.UseVisualStyleBackColor = true;
            this.btn_gScore.Click += new System.EventHandler(this.btn_gScore_Click);
            // 
            // txt_balls
            // 
            this.txt_balls.Location = new System.Drawing.Point(587, 622);
            this.txt_balls.Multiline = true;
            this.txt_balls.Name = "txt_balls";
            this.txt_balls.Size = new System.Drawing.Size(132, 54);
            this.txt_balls.TabIndex = 5;
            // 
            // txt_Over
            // 
            this.txt_Over.Location = new System.Drawing.Point(382, 622);
            this.txt_Over.Multiline = true;
            this.txt_Over.Name = "txt_Over";
            this.txt_Over.Size = new System.Drawing.Size(132, 54);
            this.txt_Over.TabIndex = 4;
            // 
            // txt_pScore
            // 
            this.txt_pScore.Location = new System.Drawing.Point(194, 622);
            this.txt_pScore.Multiline = true;
            this.txt_pScore.Name = "txt_pScore";
            this.txt_pScore.Size = new System.Drawing.Size(132, 54);
            this.txt_pScore.TabIndex = 3;
            // 
            // txt_cScore
            // 
            this.txt_cScore.Location = new System.Drawing.Point(24, 622);
            this.txt_cScore.Multiline = true;
            this.txt_cScore.Name = "txt_cScore";
            this.txt_cScore.Size = new System.Drawing.Size(132, 54);
            this.txt_cScore.TabIndex = 2;
            // 
            // rtb_team2
            // 
            this.rtb_team2.Location = new System.Drawing.Point(490, 13);
            this.rtb_team2.Name = "rtb_team2";
            this.rtb_team2.Size = new System.Drawing.Size(460, 396);
            this.rtb_team2.TabIndex = 1;
            this.rtb_team2.Text = "";
            // 
            // rtb_team1
            // 
            this.rtb_team1.Location = new System.Drawing.Point(13, 13);
            this.rtb_team1.Name = "rtb_team1";
            this.rtb_team1.Size = new System.Drawing.Size(438, 396);
            this.rtb_team1.TabIndex = 0;
            this.rtb_team1.Text = "";
            // 
            // txt_target
            // 
            this.txt_target.Location = new System.Drawing.Point(777, 622);
            this.txt_target.Multiline = true;
            this.txt_target.Name = "txt_target";
            this.txt_target.Size = new System.Drawing.Size(132, 54);
            this.txt_target.TabIndex = 8;
            // 
            // CricketGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 688);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CricketGame";
            this.Text = "Cricket Game";
            this.Load += new System.EventHandler(this.CricketGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_gScore;
        private System.Windows.Forms.TextBox txt_balls;
        private System.Windows.Forms.TextBox txt_Over;
        private System.Windows.Forms.TextBox txt_pScore;
        private System.Windows.Forms.TextBox txt_cScore;
        private System.Windows.Forms.RichTextBox rtb_team2;
        private System.Windows.Forms.RichTextBox rtb_team1;
        private System.Windows.Forms.TextBox txt_rScore;
        private System.Windows.Forms.TextBox txt_target;
    }
}

