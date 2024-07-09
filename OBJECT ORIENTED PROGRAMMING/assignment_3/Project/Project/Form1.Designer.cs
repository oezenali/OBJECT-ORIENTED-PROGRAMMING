
namespace ProjeOdevi
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBestScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.s400Panel = new System.Windows.Forms.Panel();
            this.battlegroundPanel = new System.Windows.Forms.Panel();
            this.bilgiPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.Color.Black;
            this.bilgiPanel.Controls.Add(this.panel1);
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(936, 160);
            this.bilgiPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBestScore);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timelabel);
            this.panel1.Controls.Add(this.labelPoint);
            this.panel1.Location = new System.Drawing.Point(705, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 127);
            this.panel1.TabIndex = 10;
            // 
            // buttonBestScore
            // 
            this.buttonBestScore.CausesValidation = false;
            this.buttonBestScore.Enabled = false;
            this.buttonBestScore.Location = new System.Drawing.Point(48, 84);
            this.buttonBestScore.Name = "buttonBestScore";
            this.buttonBestScore.Size = new System.Drawing.Size(160, 34);
            this.buttonBestScore.TabIndex = 11;
            this.buttonBestScore.TabStop = false;
            this.buttonBestScore.Text = "En iyi skorları göster";
            this.buttonBestScore.UseVisualStyleBackColor = true;
            this.buttonBestScore.Click += new System.EventHandler(this.buttonBestScore_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Skor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timelabel
            // 
            this.timelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timelabel.ForeColor = System.Drawing.Color.White;
            this.timelabel.Location = new System.Drawing.Point(123, 3);
            this.timelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(85, 37);
            this.timelabel.TabIndex = 1;
            this.timelabel.Text = "0:00";
            this.timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timelabel.Click += new System.EventHandler(this.timelabel_Click);
            // 
            // labelPoint
            // 
            this.labelPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPoint.ForeColor = System.Drawing.Color.White;
            this.labelPoint.Location = new System.Drawing.Point(123, 40);
            this.labelPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(85, 37);
            this.labelPoint.TabIndex = 2;
            this.labelPoint.Text = "0";
            this.labelPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bilgiLabel.ForeColor = System.Drawing.Color.White;
            this.bilgiLabel.Location = new System.Drawing.Point(13, 11);
            this.bilgiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(634, 130);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = resources.GetString("bilgiLabel.Text");
            this.bilgiLabel.Click += new System.EventHandler(this.bilgiLabel_Click);
            // 
            // s400Panel
            // 
            this.s400Panel.BackColor = System.Drawing.Color.Yellow;
            this.s400Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.s400Panel.Location = new System.Drawing.Point(0, 613);
            this.s400Panel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.s400Panel.Name = "s400Panel";
            this.s400Panel.Size = new System.Drawing.Size(936, 58);
            this.s400Panel.TabIndex = 1;
            // 
            // battlegroundPanel
            // 
            this.battlegroundPanel.BackColor = System.Drawing.Color.Crimson;
            this.battlegroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.battlegroundPanel.Location = new System.Drawing.Point(0, 160);
            this.battlegroundPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.battlegroundPanel.Name = "battlegroundPanel";
            this.battlegroundPanel.Size = new System.Drawing.Size(936, 453);
            this.battlegroundPanel.TabIndex = 1;
            this.battlegroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.savasAlaniPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 671);
            this.Controls.Add(this.battlegroundPanel);
            this.Controls.Add(this.s400Panel);
            this.Controls.Add(this.bilgiPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Savaş Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Panel s400Panel;
        private System.Windows.Forms.Panel battlegroundPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBestScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label labelPoint;
    }
}

