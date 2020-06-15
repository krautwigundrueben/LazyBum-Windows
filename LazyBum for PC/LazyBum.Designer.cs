namespace LazyBum_for_PC
{
    partial class LazyWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LazyWindow));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip_allLights = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_lDesk = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_lFloor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_lRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_lDarts = new System.Windows.Forms.ToolStripMenuItem();
            this.mCACCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memory1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memory2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_close = new System.Windows.Forms.ToolStripMenuItem();
            this.SkyUp = new System.Windows.Forms.Button();
            this.SkyLeft = new System.Windows.Forms.Button();
            this.SkyRight = new System.Windows.Forms.Button();
            this.SkyDown = new System.Windows.Forms.Button();
            this.SkyOk = new System.Windows.Forms.Button();
            this.SkyARD = new System.Windows.Forms.Button();
            this.SkyPro7 = new System.Windows.Forms.Button();
            this.SkyBuli = new System.Windows.Forms.Button();
            this.SkySport = new System.Windows.Forms.Button();
            this.SkyLast = new System.Windows.Forms.Button();
            this.volBar = new System.Windows.Forms.TrackBar();
            this.volText = new System.Windows.Forms.Label();
            this.CCvideo = new System.Windows.Forms.Button();
            this.XBOX = new System.Windows.Forms.Button();
            this.TV = new System.Windows.Forms.Button();
            this.PCvideo = new System.Windows.Forms.Button();
            this.CCaudio = new System.Windows.Forms.Button();
            this.lRoom = new System.Windows.Forms.Button();
            this.DvcsOff = new System.Windows.Forms.Button();
            this.lDarts = new System.Windows.Forms.Button();
            this.lAllOn = new System.Windows.Forms.Button();
            this.lAllOff = new System.Windows.Forms.Button();
            this.lFloor = new System.Windows.Forms.Button();
            this.lDesk = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LazyBum";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_allLights,
            this.toolStrip_lDesk,
            this.toolStrip_lFloor,
            this.toolStrip_lRoom,
            this.toolStrip_lDarts,
            this.mCACCToolStripMenuItem,
            this.toolStrip_close});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 158);
            // 
            // toolStrip_allLights
            // 
            this.toolStrip_allLights.Name = "toolStrip_allLights";
            this.toolStrip_allLights.Size = new System.Drawing.Size(171, 22);
            this.toolStrip_allLights.Text = "Alle Lampen";
            this.toolStrip_allLights.Click += new System.EventHandler(this.toolStrip_lAll_Click);
            // 
            // toolStrip_lDesk
            // 
            this.toolStrip_lDesk.Name = "toolStrip_lDesk";
            this.toolStrip_lDesk.Size = new System.Drawing.Size(171, 22);
            this.toolStrip_lDesk.Text = "Schreibtischlampe";
            this.toolStrip_lDesk.Click += new System.EventHandler(this.toolStrip_lDesk_Click);
            // 
            // toolStrip_lFloor
            // 
            this.toolStrip_lFloor.Name = "toolStrip_lFloor";
            this.toolStrip_lFloor.Size = new System.Drawing.Size(171, 22);
            this.toolStrip_lFloor.Text = "Stehlampe";
            this.toolStrip_lFloor.Click += new System.EventHandler(this.toolStrip_lFloor_Click);
            // 
            // toolStrip_lRoom
            // 
            this.toolStrip_lRoom.Name = "toolStrip_lRoom";
            this.toolStrip_lRoom.Size = new System.Drawing.Size(171, 22);
            this.toolStrip_lRoom.Text = "Deckenlampe";
            this.toolStrip_lRoom.Click += new System.EventHandler(this.toolStrip_lRoom_Click);
            // 
            // toolStrip_lDarts
            // 
            this.toolStrip_lDarts.Name = "toolStrip_lDarts";
            this.toolStrip_lDarts.Size = new System.Drawing.Size(171, 22);
            this.toolStrip_lDarts.Text = "Dartlampe";
            this.toolStrip_lDarts.Click += new System.EventHandler(this.toolStrip_lDarts_Click);
            // 
            // mCACCToolStripMenuItem
            // 
            this.mCACCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memory1ToolStripMenuItem,
            this.memory2ToolStripMenuItem});
            this.mCACCToolStripMenuItem.Name = "mCACCToolStripMenuItem";
            this.mCACCToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mCACCToolStripMenuItem.Text = "MCACC";
            // 
            // memory1ToolStripMenuItem
            // 
            this.memory1ToolStripMenuItem.Name = "memory1ToolStripMenuItem";
            this.memory1ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.memory1ToolStripMenuItem.Text = "Memory 1";
            this.memory1ToolStripMenuItem.Click += new System.EventHandler(this.memory1ToolStripMenuItem_Click);
            // 
            // memory2ToolStripMenuItem
            // 
            this.memory2ToolStripMenuItem.Name = "memory2ToolStripMenuItem";
            this.memory2ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.memory2ToolStripMenuItem.Text = "Memory 2";
            this.memory2ToolStripMenuItem.Click += new System.EventHandler(this.memory2ToolStripMenuItem_Click);
            // 
            // toolStrip_close
            // 
            this.toolStrip_close.Name = "toolStrip_close";
            this.toolStrip_close.Size = new System.Drawing.Size(171, 22);
            this.toolStrip_close.Text = "Schließen";
            this.toolStrip_close.Click += new System.EventHandler(this.toolStrip_Close_Click);
            // 
            // SkyUp
            // 
            this.SkyUp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkyUp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkyUp.Location = new System.Drawing.Point(769, 12);
            this.SkyUp.Name = "SkyUp";
            this.SkyUp.Size = new System.Drawing.Size(60, 40);
            this.SkyUp.TabIndex = 2;
            this.SkyUp.Text = "Up";
            this.SkyUp.UseVisualStyleBackColor = false;
            this.SkyUp.Click += new System.EventHandler(this.btn_Click);
            // 
            // SkyLeft
            // 
            this.SkyLeft.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkyLeft.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkyLeft.Location = new System.Drawing.Point(703, 58);
            this.SkyLeft.Name = "SkyLeft";
            this.SkyLeft.Size = new System.Drawing.Size(60, 40);
            this.SkyLeft.TabIndex = 3;
            this.SkyLeft.Text = "Left";
            this.SkyLeft.UseVisualStyleBackColor = false;
            this.SkyLeft.Click += new System.EventHandler(this.btn_Click);
            // 
            // SkyRight
            // 
            this.SkyRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkyRight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkyRight.Location = new System.Drawing.Point(835, 58);
            this.SkyRight.Name = "SkyRight";
            this.SkyRight.Size = new System.Drawing.Size(60, 40);
            this.SkyRight.TabIndex = 4;
            this.SkyRight.Text = "Right";
            this.SkyRight.UseVisualStyleBackColor = false;
            this.SkyRight.Click += new System.EventHandler(this.btn_Click);
            // 
            // SkyDown
            // 
            this.SkyDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkyDown.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyDown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkyDown.Location = new System.Drawing.Point(769, 104);
            this.SkyDown.Name = "SkyDown";
            this.SkyDown.Size = new System.Drawing.Size(60, 40);
            this.SkyDown.TabIndex = 5;
            this.SkyDown.Text = "Down";
            this.SkyDown.UseVisualStyleBackColor = false;
            this.SkyDown.Click += new System.EventHandler(this.btn_Click);
            // 
            // SkyOk
            // 
            this.SkyOk.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkyOk.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkyOk.Location = new System.Drawing.Point(769, 58);
            this.SkyOk.Name = "SkyOk";
            this.SkyOk.Size = new System.Drawing.Size(60, 40);
            this.SkyOk.TabIndex = 6;
            this.SkyOk.Text = "OK";
            this.SkyOk.UseVisualStyleBackColor = false;
            this.SkyOk.Click += new System.EventHandler(this.btn_Click);
            // 
            // SkyARD
            // 
            this.SkyARD.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkyARD.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyARD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkyARD.Location = new System.Drawing.Point(637, 183);
            this.SkyARD.Name = "SkyARD";
            this.SkyARD.Size = new System.Drawing.Size(60, 40);
            this.SkyARD.TabIndex = 7;
            this.SkyARD.Text = "ARD HD";
            this.SkyARD.UseVisualStyleBackColor = false;
            this.SkyARD.Click += new System.EventHandler(this.btn_Click);
            // 
            // SkyPro7
            // 
            this.SkyPro7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkyPro7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyPro7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkyPro7.Location = new System.Drawing.Point(703, 183);
            this.SkyPro7.Name = "SkyPro7";
            this.SkyPro7.Size = new System.Drawing.Size(60, 40);
            this.SkyPro7.TabIndex = 8;
            this.SkyPro7.Text = "Pro 7";
            this.SkyPro7.UseVisualStyleBackColor = false;
            this.SkyPro7.Click += new System.EventHandler(this.btn_Click);
            // 
            // SkyBuli
            // 
            this.SkyBuli.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkyBuli.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyBuli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkyBuli.Location = new System.Drawing.Point(835, 183);
            this.SkyBuli.Name = "SkyBuli";
            this.SkyBuli.Size = new System.Drawing.Size(68, 40);
            this.SkyBuli.TabIndex = 9;
            this.SkyBuli.Text = "Buli HD";
            this.SkyBuli.UseVisualStyleBackColor = false;
            this.SkyBuli.Click += new System.EventHandler(this.btn_Click);
            // 
            // SkySport
            // 
            this.SkySport.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkySport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkySport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkySport.Location = new System.Drawing.Point(769, 183);
            this.SkySport.Name = "SkySport";
            this.SkySport.Size = new System.Drawing.Size(60, 40);
            this.SkySport.TabIndex = 10;
            this.SkySport.Text = "Sport HD";
            this.SkySport.UseVisualStyleBackColor = false;
            this.SkySport.Click += new System.EventHandler(this.btn_Click);
            // 
            // SkyLast
            // 
            this.SkyLast.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkyLast.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkyLast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkyLast.Location = new System.Drawing.Point(637, 104);
            this.SkyLast.Name = "SkyLast";
            this.SkyLast.Size = new System.Drawing.Size(60, 40);
            this.SkyLast.TabIndex = 11;
            this.SkyLast.Text = "Last";
            this.SkyLast.UseVisualStyleBackColor = false;
            this.SkyLast.Click += new System.EventHandler(this.btn_Click);
            // 
            // volBar
            // 
            this.volBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.volBar.ForeColor = System.Drawing.SystemColors.Control;
            this.volBar.LargeChange = 0;
            this.volBar.Location = new System.Drawing.Point(636, 249);
            this.volBar.Maximum = 185;
            this.volBar.Name = "volBar";
            this.volBar.Size = new System.Drawing.Size(266, 45);
            this.volBar.TabIndex = 1;
            this.volBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volBar_MouseMove);
            this.volBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volBar_MouseUp);
            // 
            // volText
            // 
            this.volText.AutoSize = true;
            this.volText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.volText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.volText.Location = new System.Drawing.Point(834, 281);
            this.volText.Name = "volText";
            this.volText.Size = new System.Drawing.Size(67, 13);
            this.volText.TabIndex = 13;
            this.volText.Text = "volume in dB";
            // 
            // CCvideo
            // 
            this.CCvideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CCvideo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCvideo.ForeColor = System.Drawing.Color.DarkBlue;
            this.CCvideo.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_chromecast_on;
            this.CCvideo.Location = new System.Drawing.Point(324, 108);
            this.CCvideo.Name = "CCvideo";
            this.CCvideo.Size = new System.Drawing.Size(136, 90);
            this.CCvideo.TabIndex = 5;
            this.CCvideo.Text = "Chromecast Video";
            this.CCvideo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CCvideo.UseVisualStyleBackColor = false;
            this.CCvideo.Click += new System.EventHandler(this.btn_Click);
            // 
            // XBOX
            // 
            this.XBOX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.XBOX.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XBOX.ForeColor = System.Drawing.Color.DarkBlue;
            this.XBOX.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_xbox;
            this.XBOX.Location = new System.Drawing.Point(324, 204);
            this.XBOX.Name = "XBOX";
            this.XBOX.Size = new System.Drawing.Size(136, 90);
            this.XBOX.TabIndex = 4;
            this.XBOX.Text = "XBOX";
            this.XBOX.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.XBOX.UseVisualStyleBackColor = false;
            this.XBOX.Click += new System.EventHandler(this.btn_Click);
            // 
            // TV
            // 
            this.TV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TV.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TV.ForeColor = System.Drawing.Color.DarkBlue;
            this.TV.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_fernsehen;
            this.TV.Location = new System.Drawing.Point(324, 12);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(136, 90);
            this.TV.TabIndex = 0;
            this.TV.Text = "Fernsehen";
            this.TV.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.TV.UseVisualStyleBackColor = false;
            this.TV.Click += new System.EventHandler(this.btn_Click);
            // 
            // PCvideo
            // 
            this.PCvideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PCvideo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCvideo.ForeColor = System.Drawing.Color.DarkBlue;
            this.PCvideo.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_laptopvideo;
            this.PCvideo.Location = new System.Drawing.Point(466, 12);
            this.PCvideo.Name = "PCvideo";
            this.PCvideo.Size = new System.Drawing.Size(136, 90);
            this.PCvideo.TabIndex = 1;
            this.PCvideo.Text = "Laptop Video";
            this.PCvideo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.PCvideo.UseVisualStyleBackColor = false;
            this.PCvideo.Click += new System.EventHandler(this.btn_Click);
            // 
            // CCaudio
            // 
            this.CCaudio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CCaudio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCaudio.ForeColor = System.Drawing.Color.DarkBlue;
            this.CCaudio.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_chromecast1;
            this.CCaudio.Location = new System.Drawing.Point(466, 108);
            this.CCaudio.Name = "CCaudio";
            this.CCaudio.Size = new System.Drawing.Size(136, 90);
            this.CCaudio.TabIndex = 2;
            this.CCaudio.Text = "Chromecast Audio";
            this.CCaudio.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CCaudio.UseVisualStyleBackColor = false;
            this.CCaudio.Click += new System.EventHandler(this.btn_Click);
            // 
            // lRoom
            // 
            this.lRoom.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lRoom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoom.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lRoom.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_room;
            this.lRoom.Location = new System.Drawing.Point(12, 108);
            this.lRoom.Name = "lRoom";
            this.lRoom.Size = new System.Drawing.Size(136, 90);
            this.lRoom.TabIndex = 6;
            this.lRoom.Text = "Zimmerlampe";
            this.lRoom.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lRoom.UseVisualStyleBackColor = false;
            this.lRoom.Click += new System.EventHandler(this.btn_Click);
            // 
            // DvcsOff
            // 
            this.DvcsOff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DvcsOff.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DvcsOff.ForeColor = System.Drawing.Color.DarkBlue;
            this.DvcsOff.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_alleaus;
            this.DvcsOff.Location = new System.Drawing.Point(466, 204);
            this.DvcsOff.Name = "DvcsOff";
            this.DvcsOff.Size = new System.Drawing.Size(136, 90);
            this.DvcsOff.TabIndex = 3;
            this.DvcsOff.Text = "Alle ausschalten";
            this.DvcsOff.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DvcsOff.UseVisualStyleBackColor = false;
            this.DvcsOff.Click += new System.EventHandler(this.btn_Click);
            // 
            // lDarts
            // 
            this.lDarts.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lDarts.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDarts.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lDarts.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_darts;
            this.lDarts.Location = new System.Drawing.Point(154, 108);
            this.lDarts.Name = "lDarts";
            this.lDarts.Size = new System.Drawing.Size(136, 90);
            this.lDarts.TabIndex = 7;
            this.lDarts.Text = "Dartlampe";
            this.lDarts.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lDarts.UseVisualStyleBackColor = false;
            this.lDarts.Click += new System.EventHandler(this.btn_Click);
            // 
            // lAllOn
            // 
            this.lAllOn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lAllOn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAllOn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lAllOn.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_allon;
            this.lAllOn.Location = new System.Drawing.Point(12, 204);
            this.lAllOn.Name = "lAllOn";
            this.lAllOn.Size = new System.Drawing.Size(136, 90);
            this.lAllOn.TabIndex = 4;
            this.lAllOn.Text = "Alle an";
            this.lAllOn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lAllOn.UseVisualStyleBackColor = false;
            this.lAllOn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lAllOff
            // 
            this.lAllOff.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lAllOff.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAllOff.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lAllOff.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_alloff;
            this.lAllOff.Location = new System.Drawing.Point(154, 204);
            this.lAllOff.Name = "lAllOff";
            this.lAllOff.Size = new System.Drawing.Size(136, 90);
            this.lAllOff.TabIndex = 5;
            this.lAllOff.Text = "Alle aus";
            this.lAllOff.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lAllOff.UseVisualStyleBackColor = false;
            this.lAllOff.Click += new System.EventHandler(this.btn_Click);
            // 
            // lFloor
            // 
            this.lFloor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lFloor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFloor.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lFloor.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_floor;
            this.lFloor.Location = new System.Drawing.Point(154, 12);
            this.lFloor.Name = "lFloor";
            this.lFloor.Size = new System.Drawing.Size(136, 90);
            this.lFloor.TabIndex = 2;
            this.lFloor.Text = "Stehlampe";
            this.lFloor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lFloor.UseVisualStyleBackColor = false;
            this.lFloor.Click += new System.EventHandler(this.btn_Click);
            // 
            // lDesk
            // 
            this.lDesk.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lDesk.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDesk.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lDesk.Image = global::LazyBum_for_PC.Properties.Resources.lazybum_desk;
            this.lDesk.Location = new System.Drawing.Point(12, 12);
            this.lDesk.Name = "lDesk";
            this.lDesk.Size = new System.Drawing.Size(136, 90);
            this.lDesk.TabIndex = 3;
            this.lDesk.Text = "Schreibtischlampe";
            this.lDesk.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lDesk.UseVisualStyleBackColor = false;
            this.lDesk.Click += new System.EventHandler(this.btn_Click);
            // 
            // LazyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 305);
            this.Controls.Add(this.volText);
            this.Controls.Add(this.volBar);
            this.Controls.Add(this.CCvideo);
            this.Controls.Add(this.SkyLast);
            this.Controls.Add(this.XBOX);
            this.Controls.Add(this.TV);
            this.Controls.Add(this.PCvideo);
            this.Controls.Add(this.SkySport);
            this.Controls.Add(this.CCaudio);
            this.Controls.Add(this.lRoom);
            this.Controls.Add(this.DvcsOff);
            this.Controls.Add(this.SkyBuli);
            this.Controls.Add(this.lDarts);
            this.Controls.Add(this.SkyPro7);
            this.Controls.Add(this.lAllOn);
            this.Controls.Add(this.SkyARD);
            this.Controls.Add(this.SkyOk);
            this.Controls.Add(this.lAllOff);
            this.Controls.Add(this.SkyDown);
            this.Controls.Add(this.SkyRight);
            this.Controls.Add(this.lFloor);
            this.Controls.Add(this.SkyLeft);
            this.Controls.Add(this.lDesk);
            this.Controls.Add(this.SkyUp);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LazyWindow";
            this.Text = "LazyBum";
            this.Load += new System.EventHandler(this.LazyWindow_Load);
            this.SizeChanged += new System.EventHandler(this.LazyWindow_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lAllOff;
        private System.Windows.Forms.Button lAllOn;
        private System.Windows.Forms.Button lDesk;
        private System.Windows.Forms.Button lFloor;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_lDesk;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_lFloor;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_allLights;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_close;
        private System.Windows.Forms.Button lDarts;
        private System.Windows.Forms.Button lRoom;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_lRoom;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_lDarts;
        private System.Windows.Forms.Button SkyUp;
        private System.Windows.Forms.Button SkyLeft;
        private System.Windows.Forms.Button SkyRight;
        private System.Windows.Forms.Button SkyDown;
        private System.Windows.Forms.Button SkyOk;
        private System.Windows.Forms.Button SkyARD;
        private System.Windows.Forms.Button SkyPro7;
        private System.Windows.Forms.Button SkyBuli;
        private System.Windows.Forms.Button SkySport;
        private System.Windows.Forms.Button SkyLast;
        private System.Windows.Forms.Button DvcsOff;
        private System.Windows.Forms.Button CCaudio;
        private System.Windows.Forms.Button PCvideo;
        private System.Windows.Forms.Button TV;
        private System.Windows.Forms.Button XBOX;
        private System.Windows.Forms.Button CCvideo;
        private System.Windows.Forms.TrackBar volBar;
        private System.Windows.Forms.Label volText;
        private System.Windows.Forms.ToolStripMenuItem mCACCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memory1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memory2ToolStripMenuItem;

    }
}

