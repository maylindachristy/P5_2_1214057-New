﻿namespace P5_2_1214057
{
    partial class ParentForm
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
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.DateOption = new System.Windows.Forms.RadioButton();
            this.TimeOption = new System.Windows.Forms.RadioButton();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGroupBox.Controls.Add(this.DateOption);
            this.OutputGroupBox.Controls.Add(this.TimeOption);
            this.OutputGroupBox.Location = new System.Drawing.Point(46, 162);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(200, 104);
            this.OutputGroupBox.TabIndex = 7;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Choose Output";
            // 
            // DateOption
            // 
            this.DateOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOption.Location = new System.Drawing.Point(16, 16);
            this.DateOption.Name = "DateOption";
            this.DateOption.Size = new System.Drawing.Size(168, 24);
            this.DateOption.TabIndex = 0;
            this.DateOption.TabStop = true;
            this.DateOption.Text = "Display Current D&ate\r\n";
            this.DateOption.UseVisualStyleBackColor = true;
            // 
            // TimeOption
            // 
            this.TimeOption.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeOption.Location = new System.Drawing.Point(16, 64);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(168, 24);
            this.TimeOption.TabIndex = 1;
            this.TimeOption.TabStop = true;
            this.TimeOption.Text = "Display Current &Time\r\n";
            this.TimeOption.UseVisualStyleBackColor = true;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(55, 61);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 5;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(153, 61);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.OutputLabel.Location = new System.Drawing.Point(0, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(293, 32);
            this.OutputLabel.TabIndex = 4;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 280);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputLabel);
            this.Name = "ParentForm";
            this.Text = "Form 1";
            this.OutputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.RadioButton DateOption;
        private System.Windows.Forms.RadioButton TimeOption;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

