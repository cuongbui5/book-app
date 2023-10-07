namespace Book_App.Views
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.categoryFilterDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.priceFilterDropDown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.productPage = new System.Windows.Forms.TabPage();
            this.itemContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.detailProductPage = new System.Windows.Forms.TabPage();
            this.lblBookId = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel13 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel11 = new Bunifu.UI.WinForms.BunifuLabel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblCategoryName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.ratingProduct = new Bunifu.UI.WinForms.BunifuRating();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAuthor = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCartItem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ptImageCover = new System.Windows.Forms.PictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1.SuspendLayout();
            this.bunifuPages1.SuspendLayout();
            this.productPage.SuspendLayout();
            this.detailProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImageCover)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(24, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(85, 30);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "All Books";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.categoryFilterDropDown);
            this.panel1.Controls.Add(this.priceFilterDropDown);
            this.panel1.Controls.Add(this.bunifuLabel6);
            this.panel1.Controls.Add(this.bunifuLabel4);
            this.panel1.Controls.Add(this.bunifuButton2);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 84);
            this.panel1.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.AllowAnimations = true;
            this.btnFilter.AllowMouseEffects = true;
            this.btnFilter.AllowToggling = false;
            this.btnFilter.AnimationSpeed = 200;
            this.btnFilter.AutoGenerateColors = false;
            this.btnFilter.AutoRoundBorders = false;
            this.btnFilter.AutoSizeLeftIcon = true;
            this.btnFilter.AutoSizeRightIcon = true;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BackColor1 = System.Drawing.Color.White;
            this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
            this.btnFilter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilter.ButtonText = "";
            this.btnFilter.ButtonTextMarginLeft = 0;
            this.btnFilter.ColorContrastOnClick = 45;
            this.btnFilter.ColorContrastOnHover = 45;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnFilter.CustomizableEdges = borderEdges1;
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFilter.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFilter.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFilter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFilter.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFilter.IconMarginLeft = 11;
            this.btnFilter.IconPadding = 10;
            this.btnFilter.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFilter.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFilter.IconSize = 25;
            this.btnFilter.IdleBorderColor = System.Drawing.Color.White;
            this.btnFilter.IdleBorderRadius = 1;
            this.btnFilter.IdleBorderThickness = 1;
            this.btnFilter.IdleFillColor = System.Drawing.Color.White;
            this.btnFilter.IdleIconLeftImage = global::Book_App.Properties.Resources.filter;
            this.btnFilter.IdleIconRightImage = null;
            this.btnFilter.IndicateFocus = false;
            this.btnFilter.Location = new System.Drawing.Point(838, 36);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFilter.OnDisabledState.BorderRadius = 1;
            this.btnFilter.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilter.OnDisabledState.BorderThickness = 1;
            this.btnFilter.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFilter.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFilter.OnDisabledState.IconLeftImage = null;
            this.btnFilter.OnDisabledState.IconRightImage = null;
            this.btnFilter.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnFilter.onHoverState.BorderRadius = 1;
            this.btnFilter.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilter.onHoverState.BorderThickness = 1;
            this.btnFilter.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnFilter.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFilter.onHoverState.IconLeftImage = null;
            this.btnFilter.onHoverState.IconRightImage = null;
            this.btnFilter.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnFilter.OnIdleState.BorderRadius = 1;
            this.btnFilter.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilter.OnIdleState.BorderThickness = 1;
            this.btnFilter.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnFilter.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFilter.OnIdleState.IconLeftImage = global::Book_App.Properties.Resources.filter;
            this.btnFilter.OnIdleState.IconRightImage = null;
            this.btnFilter.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnFilter.OnPressedState.BorderRadius = 1;
            this.btnFilter.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFilter.OnPressedState.BorderThickness = 1;
            this.btnFilter.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnFilter.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFilter.OnPressedState.IconLeftImage = null;
            this.btnFilter.OnPressedState.IconRightImage = null;
            this.btnFilter.Size = new System.Drawing.Size(48, 39);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFilter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFilter.TextMarginLeft = 0;
            this.btnFilter.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFilter.UseDefaultRadiusAndThickness = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // categoryFilterDropDown
            // 
            this.categoryFilterDropDown.BackColor = System.Drawing.Color.Transparent;
            this.categoryFilterDropDown.BackgroundColor = System.Drawing.Color.White;
            this.categoryFilterDropDown.BorderColor = System.Drawing.Color.Silver;
            this.categoryFilterDropDown.BorderRadius = 1;
            this.categoryFilterDropDown.Color = System.Drawing.Color.Silver;
            this.categoryFilterDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.categoryFilterDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.categoryFilterDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.categoryFilterDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.categoryFilterDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categoryFilterDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.categoryFilterDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryFilterDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.categoryFilterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryFilterDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.categoryFilterDropDown.FillDropDown = true;
            this.categoryFilterDropDown.FillIndicator = false;
            this.categoryFilterDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryFilterDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryFilterDropDown.ForeColor = System.Drawing.Color.Black;
            this.categoryFilterDropDown.FormattingEnabled = true;
            this.categoryFilterDropDown.Icon = null;
            this.categoryFilterDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.categoryFilterDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.categoryFilterDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.categoryFilterDropDown.ItemBackColor = System.Drawing.Color.White;
            this.categoryFilterDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.categoryFilterDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.categoryFilterDropDown.ItemHeight = 26;
            this.categoryFilterDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.categoryFilterDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.categoryFilterDropDown.ItemTopMargin = 3;
            this.categoryFilterDropDown.Location = new System.Drawing.Point(622, 44);
            this.categoryFilterDropDown.Name = "categoryFilterDropDown";
            this.categoryFilterDropDown.Size = new System.Drawing.Size(210, 32);
            this.categoryFilterDropDown.TabIndex = 5;
            this.categoryFilterDropDown.Text = null;
            this.categoryFilterDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.categoryFilterDropDown.TextLeftMargin = 5;
            // 
            // priceFilterDropDown
            // 
            this.priceFilterDropDown.BackColor = System.Drawing.Color.Transparent;
            this.priceFilterDropDown.BackgroundColor = System.Drawing.Color.White;
            this.priceFilterDropDown.BorderColor = System.Drawing.Color.Silver;
            this.priceFilterDropDown.BorderRadius = 1;
            this.priceFilterDropDown.Color = System.Drawing.Color.Silver;
            this.priceFilterDropDown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.priceFilterDropDown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.priceFilterDropDown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.priceFilterDropDown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.priceFilterDropDown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceFilterDropDown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.priceFilterDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.priceFilterDropDown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.priceFilterDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceFilterDropDown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.priceFilterDropDown.FillDropDown = true;
            this.priceFilterDropDown.FillIndicator = false;
            this.priceFilterDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceFilterDropDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceFilterDropDown.ForeColor = System.Drawing.Color.Black;
            this.priceFilterDropDown.FormattingEnabled = true;
            this.priceFilterDropDown.Icon = null;
            this.priceFilterDropDown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.priceFilterDropDown.IndicatorColor = System.Drawing.Color.Gray;
            this.priceFilterDropDown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.priceFilterDropDown.ItemBackColor = System.Drawing.Color.White;
            this.priceFilterDropDown.ItemBorderColor = System.Drawing.Color.White;
            this.priceFilterDropDown.ItemForeColor = System.Drawing.Color.Black;
            this.priceFilterDropDown.ItemHeight = 26;
            this.priceFilterDropDown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.priceFilterDropDown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.priceFilterDropDown.Items.AddRange(new object[] {
            "0-500",
            "500-1000",
            "1000-2000"});
            this.priceFilterDropDown.ItemTopMargin = 3;
            this.priceFilterDropDown.Location = new System.Drawing.Point(506, 44);
            this.priceFilterDropDown.Name = "priceFilterDropDown";
            this.priceFilterDropDown.Size = new System.Drawing.Size(99, 32);
            this.priceFilterDropDown.TabIndex = 4;
            this.priceFilterDropDown.Text = null;
            this.priceFilterDropDown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.priceFilterDropDown.TextLeftMargin = 5;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(622, 22);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(56, 17);
            this.bunifuLabel6.TabIndex = 3;
            this.bunifuLabel6.Text = "Category:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuLabel4.Location = new System.Drawing.Point(506, 21);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(31, 17);
            this.bunifuLabel4.TabIndex = 2;
            this.bunifuLabel4.Text = "Price:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.White;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges2;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.LightCyan;
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.White;
            this.bunifuButton2.IdleIconLeftImage = global::Book_App.Properties.Resources.refresh_button;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(892, 36);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 1;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.BorderRadius = 1;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.LightCyan;
            this.bunifuButton2.OnIdleState.BorderRadius = 1;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = global::Book_App.Properties.Resources.refresh_button;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 1;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(53, 39);
            this.bunifuButton2.TabIndex = 1;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.productPage);
            this.bunifuPages1.Controls.Add(this.detailProductPage);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.productPage;
            this.bunifuPages1.PageIndex = 0;
            this.bunifuPages1.PageName = "productPage";
            this.bunifuPages1.PageTitle = "productPage";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(1016, 606);
            this.bunifuPages1.TabIndex = 2;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Leaf;
            // 
            // productPage
            // 
            this.productPage.BackColor = System.Drawing.Color.White;
            this.productPage.Controls.Add(this.panel1);
            this.productPage.Controls.Add(this.itemContainer);
            this.productPage.Location = new System.Drawing.Point(4, 4);
            this.productPage.Name = "productPage";
            this.productPage.Padding = new System.Windows.Forms.Padding(3);
            this.productPage.Size = new System.Drawing.Size(1008, 580);
            this.productPage.TabIndex = 0;
            this.productPage.Text = "productPage";
            // 
            // itemContainer
            // 
            this.itemContainer.AutoScroll = true;
            this.itemContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemContainer.Location = new System.Drawing.Point(3, 76);
            this.itemContainer.Margin = new System.Windows.Forms.Padding(0);
            this.itemContainer.Name = "itemContainer";
            this.itemContainer.Size = new System.Drawing.Size(1002, 501);
            this.itemContainer.TabIndex = 0;
            // 
            // detailProductPage
            // 
            this.detailProductPage.BackColor = System.Drawing.Color.White;
            this.detailProductPage.Controls.Add(this.lblBookId);
            this.detailProductPage.Controls.Add(this.bunifuLabel13);
            this.detailProductPage.Controls.Add(this.lblPrice);
            this.detailProductPage.Controls.Add(this.bunifuLabel11);
            this.detailProductPage.Controls.Add(this.rtbDescription);
            this.detailProductPage.Controls.Add(this.lblCategoryName);
            this.detailProductPage.Controls.Add(this.bunifuLabel9);
            this.detailProductPage.Controls.Add(this.ratingProduct);
            this.detailProductPage.Controls.Add(this.bunifuLabel7);
            this.detailProductPage.Controls.Add(this.lblAuthor);
            this.detailProductPage.Controls.Add(this.bunifuLabel5);
            this.detailProductPage.Controls.Add(this.lblTitle);
            this.detailProductPage.Controls.Add(this.bunifuButton1);
            this.detailProductPage.Controls.Add(this.btnCartItem);
            this.detailProductPage.Controls.Add(this.ptImageCover);
            this.detailProductPage.Location = new System.Drawing.Point(4, 4);
            this.detailProductPage.Name = "detailProductPage";
            this.detailProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.detailProductPage.Size = new System.Drawing.Size(1008, 580);
            this.detailProductPage.TabIndex = 1;
            this.detailProductPage.Text = "detailProductPage";
            // 
            // lblBookId
            // 
            this.lblBookId.AllowParentOverrides = false;
            this.lblBookId.AutoEllipsis = false;
            this.lblBookId.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBookId.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblBookId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookId.Location = new System.Drawing.Point(677, 112);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBookId.Size = new System.Drawing.Size(0, 0);
            this.lblBookId.TabIndex = 15;
            this.lblBookId.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblBookId.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblBookId.Visible = false;
            // 
            // bunifuLabel13
            // 
            this.bunifuLabel13.AllowParentOverrides = false;
            this.bunifuLabel13.AutoEllipsis = false;
            this.bunifuLabel13.CursorType = null;
            this.bunifuLabel13.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel13.Location = new System.Drawing.Point(570, 216);
            this.bunifuLabel13.Name = "bunifuLabel13";
            this.bunifuLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel13.Size = new System.Drawing.Size(8, 20);
            this.bunifuLabel13.TabIndex = 13;
            this.bunifuLabel13.Text = "$";
            this.bunifuLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel13.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPrice
            // 
            this.lblPrice.AllowParentOverrides = false;
            this.lblPrice.AutoEllipsis = false;
            this.lblPrice.CursorType = null;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblPrice.Location = new System.Drawing.Point(581, 216);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(43, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "676.34";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel11
            // 
            this.bunifuLabel11.AllowParentOverrides = false;
            this.bunifuLabel11.AutoEllipsis = false;
            this.bunifuLabel11.CursorType = null;
            this.bunifuLabel11.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel11.Location = new System.Drawing.Point(476, 216);
            this.bunifuLabel11.Name = "bunifuLabel11";
            this.bunifuLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel11.Size = new System.Drawing.Size(32, 20);
            this.bunifuLabel11.TabIndex = 11;
            this.bunifuLabel11.Text = "Price";
            this.bunifuLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel11.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(476, 309);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(369, 173);
            this.rtbDescription.TabIndex = 9;
            this.rtbDescription.Text = resources.GetString("rtbDescription.Text");
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AllowParentOverrides = false;
            this.lblCategoryName.AutoEllipsis = false;
            this.lblCategoryName.CursorType = null;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblCategoryName.Location = new System.Drawing.Point(570, 178);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCategoryName.Size = new System.Drawing.Size(100, 20);
            this.lblCategoryName.TabIndex = 8;
            this.lblCategoryName.Text = "CategoryName";
            this.lblCategoryName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategoryName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel9.Location = new System.Drawing.Point(476, 178);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(60, 20);
            this.bunifuLabel9.TabIndex = 7;
            this.bunifuLabel9.Text = "Category";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ratingProduct
            // 
            this.ratingProduct.BackColor = System.Drawing.Color.Transparent;
            this.ratingProduct.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingProduct.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.ratingProduct.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingProduct.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingProduct.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingProduct.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingProduct.InnerRadius = 2F;
            this.ratingProduct.Location = new System.Drawing.Point(568, 140);
            this.ratingProduct.Name = "ratingProduct";
            this.ratingProduct.OuterRadius = 10F;
            this.ratingProduct.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingProduct.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingProduct.ReadOnly = false;
            this.ratingProduct.RightClickToClear = true;
            this.ratingProduct.Size = new System.Drawing.Size(121, 22);
            this.ratingProduct.TabIndex = 5;
            this.ratingProduct.Text = "bunifuRating1";
            this.ratingProduct.Value = 2;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel7.Location = new System.Drawing.Point(476, 140);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(43, 20);
            this.bunifuLabel7.TabIndex = 4;
            this.bunifuLabel7.Text = "Rating";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AllowParentOverrides = false;
            this.lblAuthor.AutoEllipsis = true;
            this.lblAuthor.CursorType = null;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblAuthor.Location = new System.Drawing.Point(568, 253);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAuthor.Size = new System.Drawing.Size(85, 20);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "AuthorName";
            this.lblAuthor.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAuthor.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.bunifuLabel5.Location = new System.Drawing.Point(476, 253);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(45, 20);
            this.bunifuLabel5.TabIndex = 2;
            this.bunifuLabel5.Text = "Author";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(476, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(139, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Blue Lock";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.White;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges3;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.White;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.White;
            this.bunifuButton1.IdleIconLeftImage = global::Book_App.Properties.Resources.close;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(942, 16);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = global::Book_App.Properties.Resources.close;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(45, 39);
            this.bunifuButton1.TabIndex = 14;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btnCartItem
            // 
            this.btnCartItem.AllowAnimations = true;
            this.btnCartItem.AllowMouseEffects = true;
            this.btnCartItem.AllowToggling = false;
            this.btnCartItem.AnimationSpeed = 200;
            this.btnCartItem.AutoGenerateColors = false;
            this.btnCartItem.AutoRoundBorders = false;
            this.btnCartItem.AutoSizeLeftIcon = true;
            this.btnCartItem.AutoSizeRightIcon = true;
            this.btnCartItem.BackColor = System.Drawing.Color.Transparent;
            this.btnCartItem.BackColor1 = System.Drawing.Color.White;
            this.btnCartItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCartItem.BackgroundImage")));
            this.btnCartItem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCartItem.ButtonText = "";
            this.btnCartItem.ButtonTextMarginLeft = 0;
            this.btnCartItem.ColorContrastOnClick = 45;
            this.btnCartItem.ColorContrastOnHover = 45;
            this.btnCartItem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnCartItem.CustomizableEdges = borderEdges4;
            this.btnCartItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCartItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCartItem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCartItem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCartItem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCartItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCartItem.ForeColor = System.Drawing.Color.White;
            this.btnCartItem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartItem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCartItem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCartItem.IconMarginLeft = 11;
            this.btnCartItem.IconPadding = 10;
            this.btnCartItem.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCartItem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCartItem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCartItem.IconSize = 25;
            this.btnCartItem.IdleBorderColor = System.Drawing.Color.Black;
            this.btnCartItem.IdleBorderRadius = 1;
            this.btnCartItem.IdleBorderThickness = 1;
            this.btnCartItem.IdleFillColor = System.Drawing.Color.White;
            this.btnCartItem.IdleIconLeftImage = null;
            this.btnCartItem.IdleIconRightImage = global::Book_App.Properties.Resources.shopping_cart;
            this.btnCartItem.IndicateFocus = false;
            this.btnCartItem.Location = new System.Drawing.Point(205, 431);
            this.btnCartItem.Name = "btnCartItem";
            this.btnCartItem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCartItem.OnDisabledState.BorderRadius = 1;
            this.btnCartItem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCartItem.OnDisabledState.BorderThickness = 1;
            this.btnCartItem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCartItem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCartItem.OnDisabledState.IconLeftImage = null;
            this.btnCartItem.OnDisabledState.IconRightImage = null;
            this.btnCartItem.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnCartItem.onHoverState.BorderRadius = 1;
            this.btnCartItem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCartItem.onHoverState.BorderThickness = 1;
            this.btnCartItem.onHoverState.FillColor = System.Drawing.Color.Black;
            this.btnCartItem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCartItem.onHoverState.IconLeftImage = null;
            this.btnCartItem.onHoverState.IconRightImage = global::Book_App.Properties.Resources.icons8_cart_64;
            this.btnCartItem.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnCartItem.OnIdleState.BorderRadius = 1;
            this.btnCartItem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCartItem.OnIdleState.BorderThickness = 1;
            this.btnCartItem.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnCartItem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCartItem.OnIdleState.IconLeftImage = null;
            this.btnCartItem.OnIdleState.IconRightImage = global::Book_App.Properties.Resources.shopping_cart;
            this.btnCartItem.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnCartItem.OnPressedState.BorderRadius = 1;
            this.btnCartItem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCartItem.OnPressedState.BorderThickness = 1;
            this.btnCartItem.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnCartItem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCartItem.OnPressedState.IconLeftImage = null;
            this.btnCartItem.OnPressedState.IconRightImage = global::Book_App.Properties.Resources.icons8_cart_641;
            this.btnCartItem.Size = new System.Drawing.Size(231, 51);
            this.btnCartItem.TabIndex = 10;
            this.btnCartItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCartItem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCartItem.TextMarginLeft = 0;
            this.btnCartItem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCartItem.UseDefaultRadiusAndThickness = true;
            this.btnCartItem.Click += new System.EventHandler(this.btnCartItem_Click);
            // 
            // ptImageCover
            // 
            this.ptImageCover.Image = global::Book_App.Properties.Resources._94cdf6ec5a01537d_b28b9a7c8449aac0_327681585241518445957;
            this.ptImageCover.Location = new System.Drawing.Point(205, 79);
            this.ptImageCover.Name = "ptImageCover";
            this.ptImageCover.Size = new System.Drawing.Size(231, 330);
            this.ptImageCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptImageCover.TabIndex = 0;
            this.ptImageCover.TabStop = false;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(332, 67);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(144, 45);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Blue Lock";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(332, 134);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(91, 21);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "bunifuLabel3";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuPages1);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1016, 606);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuPages1.ResumeLayout(false);
            this.productPage.ResumeLayout(false);
            this.detailProductPage.ResumeLayout(false);
            this.detailProductPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptImageCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage productPage;
        private System.Windows.Forms.FlowLayoutPanel itemContainer;
        private System.Windows.Forms.TabPage detailProductPage;
        private Bunifu.UI.WinForms.BunifuLabel lblAuthor;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private System.Windows.Forms.PictureBox ptImageCover;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuRating ratingProduct;
        private Bunifu.UI.WinForms.BunifuLabel lblCategoryName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCartItem;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel13;
        private Bunifu.UI.WinForms.BunifuLabel lblPrice;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel11;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuLabel lblBookId;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFilter;
        private Bunifu.UI.WinForms.BunifuDropdown categoryFilterDropDown;
        private Bunifu.UI.WinForms.BunifuDropdown priceFilterDropDown;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
    }
}
