
namespace projectRMS
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.Overview = new System.Windows.Forms.Label();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.btnTileMenu = new Guna.UI.WinForms.GunaTileButton();
            this.btnTileSales = new Guna.UI.WinForms.GunaTileButton();
            this.btnTileReservation = new Guna.UI.WinForms.GunaTileButton();
            this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnTileOrders = new Guna.UI.WinForms.GunaTileButton();
            this.btnExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 625);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 371);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(239, 60);
            this.button1.TabIndex = 25;
            this.button1.Text = "   Menu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageActive = null;
            this.btnLogout.Location = new System.Drawing.Point(65, 550);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 42);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 24;
            this.btnLogout.TabStop = false;
            this.btnLogout.Zoom = 10;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.Location = new System.Drawing.Point(0, 311);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(239, 60);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "   Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.Location = new System.Drawing.Point(0, 251);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.btnReservation.Size = new System.Drawing.Size(239, 60);
            this.btnReservation.TabIndex = 3;
            this.btnReservation.Text = "   Reservations ";
            this.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.Location = new System.Drawing.Point(0, 191);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(239, 60);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "   Orders ";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUserID);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 191);
            this.panel2.TabIndex = 1;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(85, 128);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(64, 24);
            this.lblUserID.TabIndex = 4;
            this.lblUserID.Text = "User1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pictureBox1.Image = global::projectRMS.Properties.Resources.userIcon2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.Controls.Add(this.Overview);
            this.PanelDesktop.Controls.Add(this.gunaTransfarantPictureBox1);
            this.PanelDesktop.Controls.Add(this.btnTileMenu);
            this.PanelDesktop.Controls.Add(this.btnTileSales);
            this.PanelDesktop.Controls.Add(this.btnTileReservation);
            this.PanelDesktop.Controls.Add(this.lblTime);
            this.PanelDesktop.Controls.Add(this.btnTileOrders);
            this.PanelDesktop.Controls.Add(this.btnExit);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(239, 0);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(717, 625);
            this.PanelDesktop.TabIndex = 1;
            // 
            // Overview
            // 
            this.Overview.AutoSize = true;
            this.Overview.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.Overview.Location = new System.Drawing.Point(12, 76);
            this.Overview.Name = "Overview";
            this.Overview.Size = new System.Drawing.Size(125, 37);
            this.Overview.TabIndex = 23;
            this.Overview.Text = "Overview";
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::projectRMS.Properties.Resources.lalarosa;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(0, 3);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(416, 62);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 22;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // btnTileMenu
            // 
            this.btnTileMenu.Animated = true;
            this.btnTileMenu.AnimationHoverSpeed = 0.07F;
            this.btnTileMenu.AnimationSpeed = 0.03F;
            this.btnTileMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(74)))));
            this.btnTileMenu.BorderColor = System.Drawing.Color.Black;
            this.btnTileMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTileMenu.FocusedColor = System.Drawing.Color.Empty;
            this.btnTileMenu.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTileMenu.ForeColor = System.Drawing.Color.White;
            this.btnTileMenu.Image = null;
            this.btnTileMenu.ImageSize = new System.Drawing.Size(52, 52);
            this.btnTileMenu.Location = new System.Drawing.Point(19, 342);
            this.btnTileMenu.Name = "btnTileMenu";
            this.btnTileMenu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.btnTileMenu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTileMenu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTileMenu.OnHoverImage = null;
            this.btnTileMenu.OnPressedColor = System.Drawing.Color.Black;
            this.btnTileMenu.Size = new System.Drawing.Size(209, 180);
            this.btnTileMenu.TabIndex = 20;
            this.btnTileMenu.Text = "Menu";
            this.btnTileMenu.Click += new System.EventHandler(this.btnTileMenu_Click);
            // 
            // btnTileSales
            // 
            this.btnTileSales.Animated = true;
            this.btnTileSales.AnimationHoverSpeed = 0.07F;
            this.btnTileSales.AnimationSpeed = 0.03F;
            this.btnTileSales.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(65)))), ((int)(((byte)(45)))));
            this.btnTileSales.BorderColor = System.Drawing.Color.Black;
            this.btnTileSales.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTileSales.FocusedColor = System.Drawing.Color.Empty;
            this.btnTileSales.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTileSales.ForeColor = System.Drawing.Color.White;
            this.btnTileSales.Image = null;
            this.btnTileSales.ImageSize = new System.Drawing.Size(52, 52);
            this.btnTileSales.Location = new System.Drawing.Point(496, 128);
            this.btnTileSales.Name = "btnTileSales";
            this.btnTileSales.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            this.btnTileSales.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTileSales.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTileSales.OnHoverImage = null;
            this.btnTileSales.OnPressedColor = System.Drawing.Color.Black;
            this.btnTileSales.Size = new System.Drawing.Size(209, 180);
            this.btnTileSales.TabIndex = 19;
            this.btnTileSales.Text = "Sales";
            this.btnTileSales.Click += new System.EventHandler(this.btnTileSales_Click);
            // 
            // btnTileReservation
            // 
            this.btnTileReservation.Animated = true;
            this.btnTileReservation.AnimationHoverSpeed = 0.07F;
            this.btnTileReservation.AnimationSpeed = 0.03F;
            this.btnTileReservation.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(0)))));
            this.btnTileReservation.BorderColor = System.Drawing.Color.Black;
            this.btnTileReservation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTileReservation.FocusedColor = System.Drawing.Color.Empty;
            this.btnTileReservation.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTileReservation.ForeColor = System.Drawing.Color.White;
            this.btnTileReservation.Image = null;
            this.btnTileReservation.ImageSize = new System.Drawing.Size(52, 52);
            this.btnTileReservation.Location = new System.Drawing.Point(259, 128);
            this.btnTileReservation.Name = "btnTileReservation";
            this.btnTileReservation.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(57)))));
            this.btnTileReservation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTileReservation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTileReservation.OnHoverImage = null;
            this.btnTileReservation.OnPressedColor = System.Drawing.Color.Black;
            this.btnTileReservation.Size = new System.Drawing.Size(209, 180);
            this.btnTileReservation.TabIndex = 18;
            this.btnTileReservation.Text = "Reservations";
            this.btnTileReservation.Click += new System.EventHandler(this.btnTileReservation_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoEllipsis = false;
            this.lblTime.CursorType = null;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(19, 583);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(72, 19);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "dd/mm/777";
            this.lblTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnTileOrders
            // 
            this.btnTileOrders.Animated = true;
            this.btnTileOrders.AnimationHoverSpeed = 0.07F;
            this.btnTileOrders.AnimationSpeed = 0.03F;
            this.btnTileOrders.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.btnTileOrders.BorderColor = System.Drawing.Color.Black;
            this.btnTileOrders.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTileOrders.FocusedColor = System.Drawing.Color.Empty;
            this.btnTileOrders.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTileOrders.ForeColor = System.Drawing.Color.White;
            this.btnTileOrders.Image = null;
            this.btnTileOrders.ImageSize = new System.Drawing.Size(52, 52);
            this.btnTileOrders.Location = new System.Drawing.Point(19, 128);
            this.btnTileOrders.Name = "btnTileOrders";
            this.btnTileOrders.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTileOrders.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTileOrders.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTileOrders.OnHoverImage = null;
            this.btnTileOrders.OnPressedColor = System.Drawing.Color.Black;
            this.btnTileOrders.Size = new System.Drawing.Size(209, 180);
            this.btnTileOrders.TabIndex = 15;
            this.btnTileOrders.Text = "Orders";
            this.btnTileOrders.Click += new System.EventHandler(this.btnTileOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveImage = null;
            this.btnExit.AllowAnimations = true;
            this.btnExit.AllowBuffering = false;
            this.btnExit.AllowZooming = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ErrorImage")));
            this.btnExit.FadeWhenInactive = false;
            this.btnExit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.ImageLocation = null;
            this.btnExit.ImageMargin = 35;
            this.btnExit.ImageSize = new System.Drawing.Size(33, 30);
            this.btnExit.ImageZoomSize = new System.Drawing.Size(68, 65);
            this.btnExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnExit.InitialImage")));
            this.btnExit.Location = new System.Drawing.Point(649, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0;
            this.btnExit.ShowActiveImage = true;
            this.btnExit.ShowCursorChanges = true;
            this.btnExit.ShowImageBorders = true;
            this.btnExit.ShowSizeMarkers = false;
            this.btnExit.Size = new System.Drawing.Size(68, 65);
            this.btnExit.TabIndex = 5;
            this.btnExit.ToolTipText = "";
            this.btnExit.WaitOnLoad = false;
            this.btnExit.Zoom = 35;
            this.btnExit.ZoomSpeed = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 625);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.panel1);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelDesktop.ResumeLayout(false);
            this.PanelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnReservation;
        public System.Windows.Forms.Panel PanelDesktop;
        private Bunifu.UI.WinForms.BunifuLabel lblTime;
        private Bunifu.UI.WinForms.BunifuImageButton btnExit;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaTileButton btnTileOrders;
        private Guna.UI.WinForms.GunaTileButton btnTileMenu;
        private Guna.UI.WinForms.GunaTileButton btnTileSales;
        private Guna.UI.WinForms.GunaTileButton btnTileReservation;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnLogout;
        private System.Windows.Forms.Label Overview;
        private System.Windows.Forms.Button button1;
    }
}