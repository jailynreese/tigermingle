
namespace Battleships
{
    partial class Board
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
            this.flipOrientButton = new System.Windows.Forms.Button();
            this.battlePanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.carrierLabel = new System.Windows.Forms.Label();
            this.battleLabel = new System.Windows.Forms.Label();
            this.destroyerLabel = new System.Windows.Forms.Label();
            this.submarineLabel = new System.Windows.Forms.Label();
            this.patrolBoatLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // carrierButton
            // 
            this.carrierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrierButton.Location = new System.Drawing.Point(260, 534);
            this.carrierButton.Name = "carrierButton";
            this.carrierButton.Size = new System.Drawing.Size(140, 30);
            this.carrierButton.TabIndex = 0;
            this.carrierButton.Text = "Carrier";
            this.carrierButton.UseVisualStyleBackColor = true;
            // 
            // battleShipButton
            // 
            this.battleShipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleShipButton.Location = new System.Drawing.Point(260, 570);
            this.battleShipButton.Name = "battleShipButton";
            this.battleShipButton.Size = new System.Drawing.Size(140, 30);
            this.battleShipButton.TabIndex = 1;
            this.battleShipButton.Text = "BattleShip";
            this.battleShipButton.UseVisualStyleBackColor = true;
            // 
            // destroyerButton
            // 
            this.destroyerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destroyerButton.Location = new System.Drawing.Point(260, 606);
            this.destroyerButton.Name = "destroyerButton";
            this.destroyerButton.Size = new System.Drawing.Size(140, 30);
            this.destroyerButton.TabIndex = 2;
            this.destroyerButton.Text = "Destroyer";
            this.destroyerButton.UseVisualStyleBackColor = true;
            // 
            // submarineButton
            // 
            this.submarineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submarineButton.Location = new System.Drawing.Point(613, 534);
            this.submarineButton.Name = "submarineButton";
            this.submarineButton.Size = new System.Drawing.Size(140, 30);
            this.submarineButton.TabIndex = 3;
            this.submarineButton.Text = "Submarine";
            this.submarineButton.UseVisualStyleBackColor = true;
            // 
            // patrolBoatButton
            // 
            this.patrolBoatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patrolBoatButton.Location = new System.Drawing.Point(613, 570);
            this.patrolBoatButton.Name = "patrolBoatButton";
            this.patrolBoatButton.Size = new System.Drawing.Size(140, 30);
            this.patrolBoatButton.TabIndex = 4;
            this.patrolBoatButton.Text = "Patrol Boat";
            this.patrolBoatButton.UseVisualStyleBackColor = true;
            // 
            // playerLogRichTextBox
            // 
            this.playerLogRichTextBox.HideSelection = false;
            this.playerLogRichTextBox.Location = new System.Drawing.Point(12, 28);
            this.playerLogRichTextBox.Name = "playerLogRichTextBox";
            this.playerLogRichTextBox.ReadOnly = true;
            this.playerLogRichTextBox.Size = new System.Drawing.Size(220, 544);
            this.playerLogRichTextBox.TabIndex = 5;
            this.playerLogRichTextBox.Text = "";
            // 
            // flipOrientButton
            // 
            this.flipOrientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipOrientButton.Location = new System.Drawing.Point(457, 534);
            this.flipOrientButton.Name = "flipOrientButton";
            this.flipOrientButton.Size = new System.Drawing.Size(100, 102);
            this.flipOrientButton.TabIndex = 6;
            this.flipOrientButton.Text = "Rotated: Horizontal";
            this.flipOrientButton.UseVisualStyleBackColor = true;
            // 
            // battlePanel
            // 
            this.battlePanel.Location = new System.Drawing.Point(260, 28);
            this.battlePanel.Name = "battlePanel";
            this.battlePanel.Size = new System.Drawing.Size(493, 500);
            this.battlePanel.TabIndex = 7;
            this.battlePanel.Visible = false;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 578);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(220, 58);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // carrierLabel
            // 
            this.carrierLabel.BackColor = System.Drawing.Color.Red;
            this.carrierLabel.Location = new System.Drawing.Point(406, 534);
            this.carrierLabel.Name = "carrierLabel";
            this.carrierLabel.Size = new System.Drawing.Size(30, 30);
            this.carrierLabel.TabIndex = 9;
            // 
            // battleLabel
            // 
            this.battleLabel.BackColor = System.Drawing.Color.Green;
            this.battleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.battleLabel.Location = new System.Drawing.Point(406, 570);
            this.battleLabel.Name = "battleLabel";
            this.battleLabel.Size = new System.Drawing.Size(30, 30);
            this.battleLabel.TabIndex = 10;
            // 
            // destroyerLabel
            // 
            this.destroyerLabel.BackColor = System.Drawing.Color.Purple;
            this.destroyerLabel.Location = new System.Drawing.Point(406, 606);
            this.destroyerLabel.Name = "destroyerLabel";
            this.destroyerLabel.Size = new System.Drawing.Size(30, 30);
            this.destroyerLabel.TabIndex = 11;
            // 
            // submarineLabel
            // 
            this.submarineLabel.BackColor = System.Drawing.Color.Orange;
            this.submarineLabel.Location = new System.Drawing.Point(577, 534);
            this.submarineLabel.Name = "submarineLabel";
            this.submarineLabel.Size = new System.Drawing.Size(30, 30);
            this.submarineLabel.TabIndex = 12;
            // 
            // patrolBoatLabel
            // 
            this.patrolBoatLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.patrolBoatLabel.Location = new System.Drawing.Point(577, 570);
            this.patrolBoatLabel.Name = "patrolBoatLabel";
            this.patrolBoatLabel.Size = new System.Drawing.Size(30, 30);
            this.patrolBoatLabel.TabIndex = 13;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.ControlBox = false;
            this.Controls.Add(this.patrolBoatLabel);
            this.Controls.Add(this.submarineLabel);
            this.Controls.Add(this.destroyerLabel);
            this.Controls.Add(this.battleLabel);
            this.Controls.Add(this.carrierLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.battlePanel);
            this.Controls.Add(this.flipOrientButton);
            this.Controls.Add(this.playerLogRichTextBox);
            this.Controls.Add(this.patrolBoatButton);
            this.Controls.Add(this.submarineButton);
            this.Controls.Add(this.destroyerButton);
            this.Controls.Add(this.battleShipButton);
            this.Controls.Add(this.carrierButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Board";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carrierButton;
        private System.Windows.Forms.Button battleShipButton;
        private System.Windows.Forms.Button destroyerButton;
        private System.Windows.Forms.Button submarineButton;
        private System.Windows.Forms.Button patrolBoatButton;
        private System.Windows.Forms.RichTextBox playerLogRichTextBox;
        private System.Windows.Forms.Button flipOrientButton;
        private System.Windows.Forms.Panel battlePanel;
        private System.Windows.Forms.Button startButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label carrierLabel;
        private System.Windows.Forms.Label battleLabel;
        private System.Windows.Forms.Label destroyerLabel;
        private System.Windows.Forms.Label submarineLabel;
        private System.Windows.Forms.Label patrolBoatLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

