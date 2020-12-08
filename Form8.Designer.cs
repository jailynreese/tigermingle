namespace Dyscord
{
    partial class Form8
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
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.turnTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonA1
            // 
            this.buttonA1.Location = new System.Drawing.Point(12, 12);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(100, 100);
            this.buttonA1.TabIndex = 0;
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonA2
            // 
            this.buttonA2.Location = new System.Drawing.Point(118, 12);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(100, 100);
            this.buttonA2.TabIndex = 1;
            this.buttonA2.UseVisualStyleBackColor = true;
            this.buttonA2.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonA3
            // 
            this.buttonA3.Location = new System.Drawing.Point(224, 12);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(100, 100);
            this.buttonA3.TabIndex = 2;
            this.buttonA3.UseVisualStyleBackColor = true;
            this.buttonA3.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonB1
            // 
            this.buttonB1.Location = new System.Drawing.Point(12, 118);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(100, 100);
            this.buttonB1.TabIndex = 3;
            this.buttonB1.UseVisualStyleBackColor = true;
            this.buttonB1.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonB2
            // 
            this.buttonB2.Location = new System.Drawing.Point(118, 118);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(100, 100);
            this.buttonB2.TabIndex = 4;
            this.buttonB2.UseVisualStyleBackColor = true;
            this.buttonB2.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonB3
            // 
            this.buttonB3.Location = new System.Drawing.Point(224, 118);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(100, 100);
            this.buttonB3.TabIndex = 5;
            this.buttonB3.UseVisualStyleBackColor = true;
            this.buttonB3.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonC1
            // 
            this.buttonC1.Location = new System.Drawing.Point(12, 224);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(100, 100);
            this.buttonC1.TabIndex = 6;
            this.buttonC1.UseVisualStyleBackColor = true;
            this.buttonC1.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonC2
            // 
            this.buttonC2.Location = new System.Drawing.Point(118, 224);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(100, 100);
            this.buttonC2.TabIndex = 7;
            this.buttonC2.UseVisualStyleBackColor = true;
            this.buttonC2.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonC3
            // 
            this.buttonC3.Location = new System.Drawing.Point(224, 224);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(100, 100);
            this.buttonC3.TabIndex = 8;
            this.buttonC3.UseVisualStyleBackColor = true;
            this.buttonC3.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(224, 331);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(99, 23);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetButton_Clicked);
            // 
            // turnTextBox
            // 
            this.turnTextBox.Location = new System.Drawing.Point(13, 333);
            this.turnTextBox.Name = "turnTextBox";
            this.turnTextBox.Size = new System.Drawing.Size(99, 20);
            this.turnTextBox.TabIndex = 10;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(335, 366);
            this.Controls.Add(this.turnTextBox);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonC3);
            this.Controls.Add(this.buttonC2);
            this.Controls.Add(this.buttonC1);
            this.Controls.Add(this.buttonB3);
            this.Controls.Add(this.buttonB2);
            this.Controls.Add(this.buttonB1);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.buttonA1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.Button buttonA2;
        private System.Windows.Forms.Button buttonA3;
        private System.Windows.Forms.Button buttonB1;
        private System.Windows.Forms.Button buttonB2;
        private System.Windows.Forms.Button buttonB3;
        private System.Windows.Forms.Button buttonC1;
        private System.Windows.Forms.Button buttonC2;
        private System.Windows.Forms.Button buttonC3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox turnTextBox;
    }
}