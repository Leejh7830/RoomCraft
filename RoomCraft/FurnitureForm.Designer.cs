namespace RoomCraft
{
    partial class FurnitureForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialButton btnAddChair;
        private MaterialSkin.Controls.MaterialButton btnAddTable;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddChair = new MaterialSkin.Controls.MaterialButton();
            this.btnAddTable = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();

            // btnAddChair
            this.btnAddChair.AutoSize = false;
            this.btnAddChair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddChair.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddChair.Depth = 0;
            this.btnAddChair.HighEmphasis = true;
            this.btnAddChair.Icon = null;
            this.btnAddChair.Location = new System.Drawing.Point(50, 50);
            this.btnAddChair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddChair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddChair.Name = "btnAddChair";
            this.btnAddChair.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddChair.Size = new System.Drawing.Size(150, 50);
            this.btnAddChair.TabIndex = 0;
            this.btnAddChair.Text = "Add Chair";
            this.btnAddChair.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddChair.UseAccentColor = false;
            this.btnAddChair.UseVisualStyleBackColor = true;
            this.btnAddChair.Click += new System.EventHandler(this.btnAddChair_Click);

            // btnAddTable
            this.btnAddTable.AutoSize = false;
            this.btnAddTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTable.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddTable.Depth = 0;
            this.btnAddTable.HighEmphasis = true;
            this.btnAddTable.Icon = null;
            this.btnAddTable.Location = new System.Drawing.Point(50, 120);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddTable.Size = new System.Drawing.Size(150, 50);
            this.btnAddTable.TabIndex = 1;
            this.btnAddTable.Text = "Add Table";
            this.btnAddTable.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddTable.UseAccentColor = false;
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);

            // FurnitureSelectionForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 220);
            this.Controls.Add(this.btnAddChair);
            this.Controls.Add(this.btnAddTable);
            this.Name = "FurnitureSelectionForm";
            this.Text = "Select Furniture";
            this.ResumeLayout(false);
        }
    }
}
