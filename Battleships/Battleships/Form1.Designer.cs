
namespace Battleships
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
            this.carrierButton = new System.Windows.Forms.Button();
            this.battleShipButton = new System.Windows.Forms.Button();
            this.destroyerButton = new System.Windows.Forms.Button();
            this.submarineButton = new System.Windows.Forms.Button();
            this.patrolBoatButton = new System.Windows.Forms.Button();
            this.playerLogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // carrierButton
            // 
            this.carrierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrierButton.Location = new System.Drawing.Point(12, 111);
            this.carrierButton.Name = "carrierButton";
            this.carrierButton.Size = new System.Drawing.Size(100, 30);
            this.carrierButton.TabIndex = 0;
            this.carrierButton.Text = "Carrier";
            this.carrierButton.UseVisualStyleBackColor = true;
            // 
            // battleShipButton
            // 
            this.battleShipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleShipButton.Location = new System.Drawing.Point(12, 147);
            this.battleShipButton.Name = "battleShipButton";
            this.battleShipButton.Size = new System.Drawing.Size(100, 30);
            this.battleShipButton.TabIndex = 1;
            this.battleShipButton.Text = "BattleShip";
            this.battleShipButton.UseVisualStyleBackColor = true;
            // 
            // destroyerButton
            // 
            this.destroyerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destroyerButton.Location = new System.Drawing.Point(12, 183);
            this.destroyerButton.Name = "destroyerButton";
            this.destroyerButton.Size = new System.Drawing.Size(100, 30);
            this.destroyerButton.TabIndex = 2;
            this.destroyerButton.Text = "Destroyer";
            this.destroyerButton.UseVisualStyleBackColor = true;
            // 
            // submarineButton
            // 
            this.submarineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submarineButton.Location = new System.Drawing.Point(12, 219);
            this.submarineButton.Name = "submarineButton";
            this.submarineButton.Size = new System.Drawing.Size(100, 30);
            this.submarineButton.TabIndex = 3;
            this.submarineButton.Text = "Submarine";
            this.submarineButton.UseVisualStyleBackColor = true;
            // 
            // patrolBoatButton
            // 
            this.patrolBoatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patrolBoatButton.Location = new System.Drawing.Point(12, 255);
            this.patrolBoatButton.Name = "patrolBoatButton";
            this.patrolBoatButton.Size = new System.Drawing.Size(100, 30);
            this.patrolBoatButton.TabIndex = 4;
            this.patrolBoatButton.Text = "Patrol Boat";
            this.patrolBoatButton.UseVisualStyleBackColor = true;
            // 
            // playerLogRichTextBox
            // 
            this.playerLogRichTextBox.Location = new System.Drawing.Point(12, 517);
            this.playerLogRichTextBox.Name = "playerLogRichTextBox";
            this.playerLogRichTextBox.Size = new System.Drawing.Size(776, 69);
            this.playerLogRichTextBox.TabIndex = 5;
            this.playerLogRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.playerLogRichTextBox);
            this.Controls.Add(this.patrolBoatButton);
            this.Controls.Add(this.submarineButton);
            this.Controls.Add(this.destroyerButton);
            this.Controls.Add(this.battleShipButton);
            this.Controls.Add(this.carrierButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carrierButton;
        private System.Windows.Forms.Button battleShipButton;
        private System.Windows.Forms.Button destroyerButton;
        private System.Windows.Forms.Button submarineButton;
        private System.Windows.Forms.Button patrolBoatButton;
        private System.Windows.Forms.RichTextBox playerLogRichTextBox;
    }
}

