
namespace RoomCraft
{
    partial class RoomSizeSelectionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnOK1 = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel1 = new MaterialSkin.Controls.MaterialButton();
            this.smallRoomRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.mediumRoomRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.largeRoomRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.smallRectRoomRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.mediumRectRoomRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.largeRectRoomRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.widthTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.heightTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.widthLabel = new MaterialSkin.Controls.MaterialLabel();
            this.heightLabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnReset1 = new MaterialSkin.Controls.MaterialButton();
            this.btnApply = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnOK1
            // 
            this.btnOK1.AutoSize = false;
            this.btnOK1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOK1.Depth = 0;
            this.btnOK1.HighEmphasis = true;
            this.btnOK1.Icon = null;
            this.btnOK1.Location = new System.Drawing.Point(14, 25);
            this.btnOK1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOK1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOK1.Size = new System.Drawing.Size(93, 48);
            this.btnOK1.TabIndex = 0;
            this.btnOK1.Text = "OK";
            this.btnOK1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOK1.UseAccentColor = false;
            this.btnOK1.UseVisualStyleBackColor = true;
            this.btnOK1.Click += new System.EventHandler(this.btnOK1_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.AutoSize = false;
            this.btnCancel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel1.Depth = 0;
            this.btnCancel1.HighEmphasis = true;
            this.btnCancel1.Icon = null;
            this.btnCancel1.Location = new System.Drawing.Point(216, 25);
            this.btnCancel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel1.Size = new System.Drawing.Size(93, 48);
            this.btnCancel1.TabIndex = 1;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel1.UseAccentColor = false;
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // smallRoomRadioButton
            // 
            this.smallRoomRadioButton.AutoSize = true;
            this.smallRoomRadioButton.Depth = 0;
            this.smallRoomRadioButton.Location = new System.Drawing.Point(27, 88);
            this.smallRoomRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.smallRoomRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.smallRoomRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.smallRoomRadioButton.Name = "smallRoomRadioButton";
            this.smallRoomRadioButton.Ripple = true;
            this.smallRoomRadioButton.Size = new System.Drawing.Size(181, 37);
            this.smallRoomRadioButton.TabIndex = 2;
            this.smallRoomRadioButton.TabStop = true;
            this.smallRoomRadioButton.Text = "Small (630x630, 3평)";
            this.smallRoomRadioButton.UseVisualStyleBackColor = true;
            this.smallRoomRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // mediumRoomRadioButton
            // 
            this.mediumRoomRadioButton.AutoSize = true;
            this.mediumRoomRadioButton.Depth = 0;
            this.mediumRoomRadioButton.Location = new System.Drawing.Point(27, 136);
            this.mediumRoomRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.mediumRoomRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mediumRoomRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mediumRoomRadioButton.Name = "mediumRoomRadioButton";
            this.mediumRoomRadioButton.Ripple = true;
            this.mediumRoomRadioButton.Size = new System.Drawing.Size(198, 37);
            this.mediumRoomRadioButton.TabIndex = 3;
            this.mediumRoomRadioButton.TabStop = true;
            this.mediumRoomRadioButton.Text = "Medium (726x726, 4평)";
            this.mediumRoomRadioButton.UseVisualStyleBackColor = true;
            this.mediumRoomRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // largeRoomRadioButton
            // 
            this.largeRoomRadioButton.AutoSize = true;
            this.largeRoomRadioButton.Depth = 0;
            this.largeRoomRadioButton.Location = new System.Drawing.Point(27, 186);
            this.largeRoomRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.largeRoomRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.largeRoomRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.largeRoomRadioButton.Name = "largeRoomRadioButton";
            this.largeRoomRadioButton.Ripple = true;
            this.largeRoomRadioButton.Size = new System.Drawing.Size(180, 37);
            this.largeRoomRadioButton.TabIndex = 4;
            this.largeRoomRadioButton.TabStop = true;
            this.largeRoomRadioButton.Text = "Large (812x812, 5평)";
            this.largeRoomRadioButton.UseVisualStyleBackColor = true;
            this.largeRoomRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // smallRectRoomRadioButton
            // 
            this.smallRectRoomRadioButton.AutoSize = true;
            this.smallRectRoomRadioButton.Depth = 0;
            this.smallRectRoomRadioButton.Location = new System.Drawing.Point(288, 88);
            this.smallRectRoomRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.smallRectRoomRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.smallRectRoomRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.smallRectRoomRadioButton.Name = "smallRectRoomRadioButton";
            this.smallRectRoomRadioButton.Ripple = true;
            this.smallRectRoomRadioButton.Size = new System.Drawing.Size(270, 37);
            this.smallRectRoomRadioButton.TabIndex = 5;
            this.smallRectRoomRadioButton.TabStop = true;
            this.smallRectRoomRadioButton.Text = "Small Rectangular (800x495, 3평)";
            this.smallRectRoomRadioButton.UseVisualStyleBackColor = true;
            this.smallRectRoomRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // mediumRectRoomRadioButton
            // 
            this.mediumRectRoomRadioButton.AutoSize = true;
            this.mediumRectRoomRadioButton.Depth = 0;
            this.mediumRectRoomRadioButton.Location = new System.Drawing.Point(288, 136);
            this.mediumRectRoomRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.mediumRectRoomRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mediumRectRoomRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mediumRectRoomRadioButton.Name = "mediumRectRoomRadioButton";
            this.mediumRectRoomRadioButton.Ripple = true;
            this.mediumRectRoomRadioButton.Size = new System.Drawing.Size(287, 37);
            this.mediumRectRoomRadioButton.TabIndex = 6;
            this.mediumRectRoomRadioButton.TabStop = true;
            this.mediumRectRoomRadioButton.Text = "Medium Rectangular (916x576, 4평)";
            this.mediumRectRoomRadioButton.UseVisualStyleBackColor = true;
            this.mediumRectRoomRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // largeRectRoomRadioButton
            // 
            this.largeRectRoomRadioButton.AutoSize = true;
            this.largeRectRoomRadioButton.Depth = 0;
            this.largeRectRoomRadioButton.Location = new System.Drawing.Point(288, 186);
            this.largeRectRoomRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.largeRectRoomRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.largeRectRoomRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.largeRectRoomRadioButton.Name = "largeRectRoomRadioButton";
            this.largeRectRoomRadioButton.Ripple = true;
            this.largeRectRoomRadioButton.Size = new System.Drawing.Size(278, 37);
            this.largeRectRoomRadioButton.TabIndex = 7;
            this.largeRectRoomRadioButton.TabStop = true;
            this.largeRectRoomRadioButton.Text = "Large Rectangular (1000x660, 5평)";
            this.largeRectRoomRadioButton.UseVisualStyleBackColor = true;
            this.largeRectRoomRadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // widthTextBox
            // 
            this.widthTextBox.AnimateReadOnly = false;
            this.widthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.widthTextBox.Depth = 0;
            this.widthTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.widthTextBox.LeadingIcon = null;
            this.widthTextBox.Location = new System.Drawing.Point(102, 264);
            this.widthTextBox.MaxLength = 50;
            this.widthTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.widthTextBox.Multiline = false;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(98, 50);
            this.widthTextBox.TabIndex = 10;
            this.widthTextBox.Text = "";
            this.widthTextBox.TrailingIcon = null;
            // 
            // heightTextBox
            // 
            this.heightTextBox.AnimateReadOnly = false;
            this.heightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.heightTextBox.Depth = 0;
            this.heightTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.heightTextBox.LeadingIcon = null;
            this.heightTextBox.Location = new System.Drawing.Point(274, 264);
            this.heightTextBox.MaxLength = 50;
            this.heightTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.heightTextBox.Multiline = false;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(98, 50);
            this.heightTextBox.TabIndex = 11;
            this.heightTextBox.Text = "";
            this.heightTextBox.TrailingIcon = null;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Depth = 0;
            this.widthLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.widthLabel.Location = new System.Drawing.Point(54, 279);
            this.widthLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(42, 19);
            this.widthLabel.TabIndex = 12;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Depth = 0;
            this.heightLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.heightLabel.Location = new System.Drawing.Point(221, 279);
            this.heightLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(47, 19);
            this.heightLabel.TabIndex = 13;
            this.heightLabel.Text = "Height";
            // 
            // btnReset1
            // 
            this.btnReset1.AutoSize = false;
            this.btnReset1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReset1.Depth = 0;
            this.btnReset1.HighEmphasis = true;
            this.btnReset1.Icon = null;
            this.btnReset1.Location = new System.Drawing.Point(115, 25);
            this.btnReset1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReset1.Size = new System.Drawing.Size(93, 48);
            this.btnReset1.TabIndex = 14;
            this.btnReset1.Text = "Reset";
            this.btnReset1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReset1.UseAccentColor = false;
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = false;
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApply.Depth = 0;
            this.btnApply.HighEmphasis = true;
            this.btnApply.Icon = null;
            this.btnApply.Location = new System.Drawing.Point(382, 270);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApply.Name = "btnApply";
            this.btnApply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnApply.Size = new System.Drawing.Size(77, 36);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply";
            this.btnApply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApply.UseAccentColor = false;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // RoomSizeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnReset1);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.largeRectRoomRadioButton);
            this.Controls.Add(this.mediumRectRoomRadioButton);
            this.Controls.Add(this.smallRectRoomRadioButton);
            this.Controls.Add(this.largeRoomRadioButton);
            this.Controls.Add(this.mediumRoomRadioButton);
            this.Controls.Add(this.smallRoomRadioButton);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.btnOK1);
            this.Name = "RoomSizeSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnOK1;
        private MaterialSkin.Controls.MaterialButton btnCancel1;
        private MaterialSkin.Controls.MaterialRadioButton smallRoomRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton mediumRoomRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton largeRoomRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton smallRectRoomRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton mediumRectRoomRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton largeRectRoomRadioButton;
        private MaterialSkin.Controls.MaterialTextBox widthTextBox;
        private MaterialSkin.Controls.MaterialTextBox heightTextBox;
        private MaterialSkin.Controls.MaterialLabel widthLabel;
        private MaterialSkin.Controls.MaterialLabel heightLabel;
        private MaterialSkin.Controls.MaterialButton btnReset1;
        private MaterialSkin.Controls.MaterialButton btnApply;
    }
}