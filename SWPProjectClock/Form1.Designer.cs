﻿namespace SWPProjectClock
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxCommandLine = new System.Windows.Forms.TextBox();
            this.btnDoCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxCommandLine
            // 
            this.tBoxCommandLine.Location = new System.Drawing.Point(12, 12);
            this.tBoxCommandLine.Name = "tBoxCommandLine";
            this.tBoxCommandLine.Size = new System.Drawing.Size(392, 20);
            this.tBoxCommandLine.TabIndex = 0;
            // 
            // btnDoCommand
            // 
            this.btnDoCommand.Location = new System.Drawing.Point(422, 10);
            this.btnDoCommand.Name = "btnDoCommand";
            this.btnDoCommand.Size = new System.Drawing.Size(75, 23);
            this.btnDoCommand.TabIndex = 1;
            this.btnDoCommand.Text = "Go";
            this.btnDoCommand.UseVisualStyleBackColor = true;
            this.btnDoCommand.Click += new System.EventHandler(this.btnDoCommand_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDoCommand;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 45);
            this.Controls.Add(this.btnDoCommand);
            this.Controls.Add(this.tBoxCommandLine);
            this.Name = "Form1";
            this.Text = "UTC Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxCommandLine;
        private System.Windows.Forms.Button btnDoCommand;
    }
}

