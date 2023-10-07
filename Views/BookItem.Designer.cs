namespace Book_App.Views
{
    partial class BookItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookItem));
            this.lblPriceItem = new Bunifu.UI.WinForms.BunifuLabel();
            this.ratingItem = new Bunifu.UI.WinForms.BunifuRating();
            this.ptImageItem = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblNameItem = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptImageItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPriceItem
            // 
            this.lblPriceItem.AllowParentOverrides = false;
            this.lblPriceItem.AutoEllipsis = false;
            this.lblPriceItem.BackColor = System.Drawing.Color.White;
            this.lblPriceItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriceItem.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPriceItem.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.lblPriceItem.ForeColor = System.Drawing.Color.Black;
            this.lblPriceItem.Location = new System.Drawing.Point(29, 263);
            this.lblPriceItem.Name = "lblPriceItem";
            this.lblPriceItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPriceItem.Size = new System.Drawing.Size(46, 19);
            this.lblPriceItem.TabIndex = 4;
            this.lblPriceItem.Text = "648.76";
            this.lblPriceItem.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPriceItem.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ratingItem
            // 
            this.ratingItem.BackColor = System.Drawing.Color.Transparent;
            this.ratingItem.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingItem.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.ratingItem.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingItem.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingItem.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingItem.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingItem.InnerRadius = 2F;
            this.ratingItem.Location = new System.Drawing.Point(16, 285);
            this.ratingItem.Name = "ratingItem";
            this.ratingItem.OuterRadius = 7F;
            this.ratingItem.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingItem.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingItem.ReadOnly = false;
            this.ratingItem.RightClickToClear = true;
            this.ratingItem.Size = new System.Drawing.Size(91, 16);
            this.ratingItem.TabIndex = 5;
            this.ratingItem.Text = "bunifuRating1";
            this.ratingItem.Value = 2;
            // 
            // ptImageItem
            // 
            this.ptImageItem.BackColor = System.Drawing.Color.White;
            this.ptImageItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptImageItem.Image = global::Book_App.Properties.Resources._94cdf6ec5a01537d_b28b9a7c8449aac0_327681585241518445957;
            this.ptImageItem.Location = new System.Drawing.Point(5, 5);
            this.ptImageItem.Name = "ptImageItem";
            this.ptImageItem.Size = new System.Drawing.Size(180, 229);
            this.ptImageItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptImageItem.TabIndex = 2;
            this.ptImageItem.TabStop = false;
            this.ptImageItem.Click += new System.EventHandler(this.ptImageItem_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel1.Location = new System.Drawing.Point(20, 262);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(8, 20);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "$";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblNameItem
            // 
            this.lblNameItem.AllowParentOverrides = false;
            this.lblNameItem.AutoEllipsis = true;
            this.lblNameItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNameItem.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNameItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNameItem.Location = new System.Drawing.Point(19, 238);
            this.lblNameItem.Name = "lblNameItem";
            this.lblNameItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNameItem.Size = new System.Drawing.Size(91, 21);
            this.lblNameItem.TabIndex = 7;
            this.lblNameItem.Text = "bunifuLabel2";
            this.lblNameItem.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNameItem.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNameItem);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.ratingItem);
            this.Controls.Add(this.lblPriceItem);
            this.Controls.Add(this.ptImageItem);
            this.Margin = new System.Windows.Forms.Padding(5, 10, 3, 3);
            this.Name = "BookItem";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(190, 313);
            this.Load += new System.EventHandler(this.BookItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptImageItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptImageItem;
        private Bunifu.UI.WinForms.BunifuLabel lblPriceItem;
        private Bunifu.UI.WinForms.BunifuRating ratingItem;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lblNameItem;
    }
}
