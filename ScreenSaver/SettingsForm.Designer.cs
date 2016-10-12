﻿namespace ScreenSaver
{
    partial class SettingsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.chkDifferentMonitorMovies = new System.Windows.Forms.CheckBox();
            this.chkUseTimeOfDay = new System.Windows.Forms.CheckBox();
            this.chkMultiscreenDisabled = new System.Windows.Forms.CheckBox();
            this.chkCacheVideos = new System.Windows.Forms.CheckBox();
            this.fbdCacheLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCacheLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aerial Settings";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(197, 144);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(116, 144);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // chkDifferentMonitorMovies
            // 
            this.chkDifferentMonitorMovies.AutoSize = true;
            this.chkDifferentMonitorMovies.Checked = true;
            this.chkDifferentMonitorMovies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDifferentMonitorMovies.Location = new System.Drawing.Point(19, 56);
            this.chkDifferentMonitorMovies.Name = "chkDifferentMonitorMovies";
            this.chkDifferentMonitorMovies.Size = new System.Drawing.Size(195, 17);
            this.chkDifferentMonitorMovies.TabIndex = 6;
            this.chkDifferentMonitorMovies.Text = "Play different Aerial on each monitor";
            this.chkDifferentMonitorMovies.UseVisualStyleBackColor = true;
            // 
            // chkUseTimeOfDay
            // 
            this.chkUseTimeOfDay.AutoSize = true;
            this.chkUseTimeOfDay.Checked = true;
            this.chkUseTimeOfDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseTimeOfDay.Location = new System.Drawing.Point(19, 78);
            this.chkUseTimeOfDay.Name = "chkUseTimeOfDay";
            this.chkUseTimeOfDay.Size = new System.Drawing.Size(240, 17);
            this.chkUseTimeOfDay.TabIndex = 7;
            this.chkUseTimeOfDay.Text = "Use time of day to show day/night videos first";
            this.chkUseTimeOfDay.UseVisualStyleBackColor = true;
            // 
            // chkMultiscreenDisabled
            // 
            this.chkMultiscreenDisabled.AutoSize = true;
            this.chkMultiscreenDisabled.Checked = true;
            this.chkMultiscreenDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMultiscreenDisabled.Location = new System.Drawing.Point(19, 100);
            this.chkMultiscreenDisabled.Name = "chkMultiscreenDisabled";
            this.chkMultiscreenDisabled.Size = new System.Drawing.Size(251, 17);
            this.chkMultiscreenDisabled.TabIndex = 8;
            this.chkMultiscreenDisabled.Text = "Disable all but main screen on 3+ screen setups";
            this.chkMultiscreenDisabled.UseVisualStyleBackColor = true;
            // 
            // chkCacheVideos
            // 
            this.chkCacheVideos.AutoSize = true;
            this.chkCacheVideos.Location = new System.Drawing.Point(19, 122);
            this.chkCacheVideos.Name = "chkCacheVideos";
            this.chkCacheVideos.Size = new System.Drawing.Size(91, 17);
            this.chkCacheVideos.TabIndex = 9;
            this.chkCacheVideos.Text = "Cache videos";
            this.chkCacheVideos.UseVisualStyleBackColor = true;
            // 
            // btnCacheLocation
            // 
            this.btnCacheLocation.Location = new System.Drawing.Point(116, 118);
            this.btnCacheLocation.Name = "btnCacheLocation";
            this.btnCacheLocation.Size = new System.Drawing.Size(75, 23);
            this.btnCacheLocation.TabIndex = 10;
            this.btnCacheLocation.Text = "Set Path";
            this.btnCacheLocation.UseVisualStyleBackColor = true;
            this.btnCacheLocation.Click += new System.EventHandler(this.btnCacheLocation_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.btnCacheLocation);
            this.Controls.Add(this.chkCacheVideos);
            this.Controls.Add(this.chkMultiscreenDisabled);
            this.Controls.Add(this.chkUseTimeOfDay);
            this.Controls.Add(this.chkDifferentMonitorMovies);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Aerial Screen Saver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox chkDifferentMonitorMovies;
        private System.Windows.Forms.CheckBox chkUseTimeOfDay;
        private System.Windows.Forms.CheckBox chkMultiscreenDisabled;
        private System.Windows.Forms.CheckBox chkCacheVideos;
        private System.Windows.Forms.FolderBrowserDialog fbdCacheLocation;
        private System.Windows.Forms.Button btnCacheLocation;
    }
}
