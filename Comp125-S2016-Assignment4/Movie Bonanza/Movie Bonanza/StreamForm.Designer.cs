﻿namespace Movie_Bonanza
{
    partial class StreamForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GrandTotalText = new System.Windows.Forms.Label();
            this.ChosenMovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank You for your time!";
            // 
            // GrandTotalText
            // 
            this.GrandTotalText.AutoSize = true;
            this.GrandTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalText.Location = new System.Drawing.Point(47, 103);
            this.GrandTotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrandTotalText.Name = "GrandTotalText";
            this.GrandTotalText.Size = new System.Drawing.Size(289, 18);
            this.GrandTotalText.TabIndex = 1;
            this.GrandTotalText.Text = "Your Credit Card will be charged [X dollars]";
            // 
            // ChosenMovieLabel
            // 
            this.ChosenMovieLabel.AutoSize = true;
            this.ChosenMovieLabel.Location = new System.Drawing.Point(47, 145);
            this.ChosenMovieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChosenMovieLabel.Name = "ChosenMovieLabel";
            this.ChosenMovieLabel.Size = new System.Drawing.Size(264, 17);
            this.ChosenMovieLabel.TabIndex = 2;
            this.ChosenMovieLabel.Text = "[Your Movie] will begin streaming shortly.";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 266);
            this.Controls.Add(this.ChosenMovieLabel);
            this.Controls.Add(this.GrandTotalText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StreamForm";
            this.Text = "Your Movie is about to start!";
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GrandTotalText;
        private System.Windows.Forms.Label ChosenMovieLabel;
    }
}