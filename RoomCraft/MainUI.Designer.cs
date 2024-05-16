
namespace RoomCraft
{
    partial class MainUI
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
            this.BtnStart1 = new MaterialSkin.Controls.MaterialButton();
            this.BtnExit1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // BtnStart1
            // 
            this.BtnStart1.AutoSize = false;
            this.BtnStart1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnStart1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnStart1.Depth = 0;
            this.BtnStart1.Font = new System.Drawing.Font("굴림", 35F);
            this.BtnStart1.HighEmphasis = true;
            this.BtnStart1.Icon = null;
            this.BtnStart1.Location = new System.Drawing.Point(215, 360);
            this.BtnStart1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnStart1.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnStart1.Name = "BtnStart1";
            this.BtnStart1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnStart1.Size = new System.Drawing.Size(148, 57);
            this.BtnStart1.TabIndex = 0;
            this.BtnStart1.Text = "Start";
            this.BtnStart1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnStart1.UseAccentColor = false;
            this.BtnStart1.UseVisualStyleBackColor = true;
            this.BtnStart1.Click += new System.EventHandler(this.BtnStart1_Click_1);
            // 
            // BtnExit1
            // 
            this.BtnExit1.AutoSize = false;
            this.BtnExit1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExit1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExit1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnExit1.Depth = 0;
            this.BtnExit1.Font = new System.Drawing.Font("굴림", 35F);
            this.BtnExit1.HighEmphasis = true;
            this.BtnExit1.Icon = null;
            this.BtnExit1.Location = new System.Drawing.Point(371, 360);
            this.BtnExit1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnExit1.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExit1.Name = "BtnExit1";
            this.BtnExit1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnExit1.Size = new System.Drawing.Size(148, 57);
            this.BtnExit1.TabIndex = 1;
            this.BtnExit1.Text = "Exit";
            this.BtnExit1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnExit1.UseAccentColor = false;
            this.BtnExit1.UseVisualStyleBackColor = false;
            this.BtnExit1.Click += new System.EventHandler(this.BtnExit1_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit1);
            this.Controls.Add(this.BtnStart1);
            this.Name = "MainUI";
            this.Text = "   Room Craft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUI_FormClosing);
            this.ResumeLayout(false);

        }


        #endregion

        private MaterialSkin.Controls.MaterialButton BtnStart1;
        private MaterialSkin.Controls.MaterialButton BtnExit1;
    }
}