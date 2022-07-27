namespace MyScreenSaver
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.chkBoxMouseDbClick = new System.Windows.Forms.CheckBox();
            this.cmbBoxLang = new System.Windows.Forms.ComboBox();
            this.lbLang = new System.Windows.Forms.Label();
            this.listboxPictureDirs = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAllRemove = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtboxTime = new System.Windows.Forms.TextBox();
            this.chkBoxPictureAuto = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.listboxPictureExtensions = new System.Windows.Forms.ListBox();
            this.btnAddPictureExtension = new System.Windows.Forms.Button();
            this.txtboxPictureExtension = new System.Windows.Forms.TextBox();
            this.grpBoxPictureSlideShow = new System.Windows.Forms.GroupBox();
            this.grpBoxMusicPlayer = new System.Windows.Forms.GroupBox();
            this.grpBoxMusicDirList = new System.Windows.Forms.GroupBox();
            this.grpBoxMusicExtension = new System.Windows.Forms.GroupBox();
            this.txtboxMusicExtension = new System.Windows.Forms.TextBox();
            this.listboxMusicExtensions = new System.Windows.Forms.ListBox();
            this.btnAllRemoveMusicExtension = new System.Windows.Forms.Button();
            this.btnMusicExtensionDefault = new System.Windows.Forms.Button();
            this.btnRemoveMusicExtension = new System.Windows.Forms.Button();
            this.btnAddMusicExtension = new System.Windows.Forms.Button();
            this.listboxMusicDirs = new System.Windows.Forms.ListBox();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.btnRemoveMusic = new System.Windows.Forms.Button();
            this.btnDefaultMusic = new System.Windows.Forms.Button();
            this.btnAllRemoveMusic = new System.Windows.Forms.Button();
            this.chkBoxMusicPlayer = new System.Windows.Forms.CheckBox();
            this.grpBoxSlideShowAndTime = new System.Windows.Forms.GroupBox();
            this.chkBoxShowTime = new System.Windows.Forms.CheckBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.grpBoxPictureDirList = new System.Windows.Forms.GroupBox();
            this.grpBoxPictureExtension = new System.Windows.Forms.GroupBox();
            this.btnAllRemovePictureExtension = new System.Windows.Forms.Button();
            this.btnPictureExtensionDefault = new System.Windows.Forms.Button();
            this.btnRemovePictureExtension = new System.Windows.Forms.Button();
            this.grpBoxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.grpBoxPictureSlideShow.SuspendLayout();
            this.grpBoxMusicPlayer.SuspendLayout();
            this.grpBoxMusicDirList.SuspendLayout();
            this.grpBoxMusicExtension.SuspendLayout();
            this.grpBoxSlideShowAndTime.SuspendLayout();
            this.grpBoxPictureDirList.SuspendLayout();
            this.grpBoxPictureExtension.SuspendLayout();
            this.grpBoxGeneralSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBoxMouseDbClick
            // 
            this.chkBoxMouseDbClick.AutoSize = true;
            this.chkBoxMouseDbClick.Checked = true;
            this.chkBoxMouseDbClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxMouseDbClick.Location = new System.Drawing.Point(6, 49);
            this.chkBoxMouseDbClick.Name = "chkBoxMouseDbClick";
            this.chkBoxMouseDbClick.Size = new System.Drawing.Size(106, 17);
            this.chkBoxMouseDbClick.TabIndex = 0;
            this.chkBoxMouseDbClick.Text = "Çift tıklayarak çık";
            this.chkBoxMouseDbClick.UseVisualStyleBackColor = true;
            this.chkBoxMouseDbClick.CheckedChanged += new System.EventHandler(this.chkBoxMouseDbClick_CheckedChanged);
            // 
            // cmbBoxLang
            // 
            this.cmbBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLang.FormattingEnabled = true;
            this.cmbBoxLang.Location = new System.Drawing.Point(31, 22);
            this.cmbBoxLang.Name = "cmbBoxLang";
            this.cmbBoxLang.Size = new System.Drawing.Size(395, 21);
            this.cmbBoxLang.TabIndex = 1;
            this.cmbBoxLang.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLang_SelectedIndexChanged);
            // 
            // lbLang
            // 
            this.lbLang.AutoSize = true;
            this.lbLang.Location = new System.Drawing.Point(6, 27);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(19, 13);
            this.lbLang.TabIndex = 2;
            this.lbLang.Text = "Dil";
            this.lbLang.SizeChanged += new System.EventHandler(this.lbLang_SizeChanged);
            // 
            // listboxPictureDirs
            // 
            this.listboxPictureDirs.FormattingEnabled = true;
            this.listboxPictureDirs.HorizontalScrollbar = true;
            this.listboxPictureDirs.Location = new System.Drawing.Point(6, 19);
            this.listboxPictureDirs.Name = "listboxPictureDirs";
            this.listboxPictureDirs.Size = new System.Drawing.Size(491, 82);
            this.listboxPictureDirs.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(87, 107);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Kaldır";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(416, 107);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 6;
            this.btnDefault.Text = "Varsayılan";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShow.Location = new System.Drawing.Point(12, 814);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAllRemove
            // 
            this.btnAllRemove.Location = new System.Drawing.Point(168, 107);
            this.btnAllRemove.Name = "btnAllRemove";
            this.btnAllRemove.Size = new System.Drawing.Size(96, 23);
            this.btnAllRemove.TabIndex = 8;
            this.btnAllRemove.Text = "Tümünü Kaldır";
            this.btnAllRemove.UseVisualStyleBackColor = true;
            this.btnAllRemove.Click += new System.EventHandler(this.btnAllRemove_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(6, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Süre:";
            // 
            // txtboxTime
            // 
            this.txtboxTime.Location = new System.Drawing.Point(44, 26);
            this.txtboxTime.Name = "txtboxTime";
            this.txtboxTime.Size = new System.Drawing.Size(164, 20);
            this.txtboxTime.TabIndex = 10;
            this.txtboxTime.TextChanged += new System.EventHandler(this.txtboxTime_TextChanged);
            // 
            // chkBoxPictureAuto
            // 
            this.chkBoxPictureAuto.AutoSize = true;
            this.chkBoxPictureAuto.Location = new System.Drawing.Point(272, 19);
            this.chkBoxPictureAuto.Name = "chkBoxPictureAuto";
            this.chkBoxPictureAuto.Size = new System.Drawing.Size(194, 17);
            this.chkBoxPictureAuto.TabIndex = 11;
            this.chkBoxPictureAuto.Text = "Resimleri slayt gösterisi olarak oynat";
            this.chkBoxPictureAuto.UseVisualStyleBackColor = true;
            this.chkBoxPictureAuto.CheckedChanged += new System.EventHandler(this.chkBoxPictureAuto_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(921, 814);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // listboxPictureExtensions
            // 
            this.listboxPictureExtensions.FormattingEnabled = true;
            this.listboxPictureExtensions.HorizontalScrollbar = true;
            this.listboxPictureExtensions.Location = new System.Drawing.Point(6, 19);
            this.listboxPictureExtensions.Name = "listboxPictureExtensions";
            this.listboxPictureExtensions.Size = new System.Drawing.Size(481, 95);
            this.listboxPictureExtensions.TabIndex = 13;
            // 
            // btnAddPictureExtension
            // 
            this.btnAddPictureExtension.Location = new System.Drawing.Point(112, 118);
            this.btnAddPictureExtension.Name = "btnAddPictureExtension";
            this.btnAddPictureExtension.Size = new System.Drawing.Size(75, 23);
            this.btnAddPictureExtension.TabIndex = 4;
            this.btnAddPictureExtension.Text = "Ekle";
            this.btnAddPictureExtension.UseVisualStyleBackColor = true;
            this.btnAddPictureExtension.Click += new System.EventHandler(this.btnAddPictureExtension_Click);
            // 
            // txtboxPictureExtension
            // 
            this.txtboxPictureExtension.Location = new System.Drawing.Point(6, 120);
            this.txtboxPictureExtension.Name = "txtboxPictureExtension";
            this.txtboxPictureExtension.Size = new System.Drawing.Size(100, 20);
            this.txtboxPictureExtension.TabIndex = 14;
            // 
            // grpBoxPictureSlideShow
            // 
            this.grpBoxPictureSlideShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxPictureSlideShow.Controls.Add(this.grpBoxMusicPlayer);
            this.grpBoxPictureSlideShow.Controls.Add(this.chkBoxMusicPlayer);
            this.grpBoxPictureSlideShow.Controls.Add(this.grpBoxSlideShowAndTime);
            this.grpBoxPictureSlideShow.Controls.Add(this.grpBoxPictureDirList);
            this.grpBoxPictureSlideShow.Controls.Add(this.grpBoxPictureExtension);
            this.grpBoxPictureSlideShow.Location = new System.Drawing.Point(491, 12);
            this.grpBoxPictureSlideShow.Name = "grpBoxPictureSlideShow";
            this.grpBoxPictureSlideShow.Size = new System.Drawing.Size(514, 753);
            this.grpBoxPictureSlideShow.TabIndex = 15;
            this.grpBoxPictureSlideShow.TabStop = false;
            this.grpBoxPictureSlideShow.Text = "Slayt Gösterisi";
            // 
            // grpBoxMusicPlayer
            // 
            this.grpBoxMusicPlayer.Controls.Add(this.grpBoxMusicDirList);
            this.grpBoxMusicPlayer.Location = new System.Drawing.Point(6, 392);
            this.grpBoxMusicPlayer.Name = "grpBoxMusicPlayer";
            this.grpBoxMusicPlayer.Size = new System.Drawing.Size(502, 319);
            this.grpBoxMusicPlayer.TabIndex = 17;
            this.grpBoxMusicPlayer.TabStop = false;
            this.grpBoxMusicPlayer.Text = "Müzik Oynatıcısı";
            // 
            // grpBoxMusicDirList
            // 
            this.grpBoxMusicDirList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxMusicDirList.Controls.Add(this.grpBoxMusicExtension);
            this.grpBoxMusicDirList.Controls.Add(this.listboxMusicDirs);
            this.grpBoxMusicDirList.Controls.Add(this.btnAddMusic);
            this.grpBoxMusicDirList.Controls.Add(this.btnRemoveMusic);
            this.grpBoxMusicDirList.Controls.Add(this.btnDefaultMusic);
            this.grpBoxMusicDirList.Controls.Add(this.btnAllRemoveMusic);
            this.grpBoxMusicDirList.Location = new System.Drawing.Point(6, 19);
            this.grpBoxMusicDirList.Name = "grpBoxMusicDirList";
            this.grpBoxMusicDirList.Size = new System.Drawing.Size(490, 294);
            this.grpBoxMusicDirList.TabIndex = 17;
            this.grpBoxMusicDirList.TabStop = false;
            this.grpBoxMusicDirList.Text = "Müzik Klasör Listesi";
            // 
            // grpBoxMusicExtension
            // 
            this.grpBoxMusicExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxMusicExtension.Controls.Add(this.txtboxMusicExtension);
            this.grpBoxMusicExtension.Controls.Add(this.listboxMusicExtensions);
            this.grpBoxMusicExtension.Controls.Add(this.btnAllRemoveMusicExtension);
            this.grpBoxMusicExtension.Controls.Add(this.btnMusicExtensionDefault);
            this.grpBoxMusicExtension.Controls.Add(this.btnRemoveMusicExtension);
            this.grpBoxMusicExtension.Controls.Add(this.btnAddMusicExtension);
            this.grpBoxMusicExtension.Location = new System.Drawing.Point(5, 136);
            this.grpBoxMusicExtension.Name = "grpBoxMusicExtension";
            this.grpBoxMusicExtension.Size = new System.Drawing.Size(478, 146);
            this.grpBoxMusicExtension.TabIndex = 19;
            this.grpBoxMusicExtension.TabStop = false;
            this.grpBoxMusicExtension.Text = "Dosya Türleri";
            // 
            // txtboxMusicExtension
            // 
            this.txtboxMusicExtension.Location = new System.Drawing.Point(6, 120);
            this.txtboxMusicExtension.Name = "txtboxMusicExtension";
            this.txtboxMusicExtension.Size = new System.Drawing.Size(100, 20);
            this.txtboxMusicExtension.TabIndex = 14;
            // 
            // listboxMusicExtensions
            // 
            this.listboxMusicExtensions.FormattingEnabled = true;
            this.listboxMusicExtensions.HorizontalScrollbar = true;
            this.listboxMusicExtensions.Location = new System.Drawing.Point(6, 19);
            this.listboxMusicExtensions.Name = "listboxMusicExtensions";
            this.listboxMusicExtensions.Size = new System.Drawing.Size(466, 95);
            this.listboxMusicExtensions.TabIndex = 13;
            // 
            // btnAllRemoveMusicExtension
            // 
            this.btnAllRemoveMusicExtension.Location = new System.Drawing.Point(274, 117);
            this.btnAllRemoveMusicExtension.Name = "btnAllRemoveMusicExtension";
            this.btnAllRemoveMusicExtension.Size = new System.Drawing.Size(90, 23);
            this.btnAllRemoveMusicExtension.TabIndex = 5;
            this.btnAllRemoveMusicExtension.Text = "Tümünü Kaldır";
            this.btnAllRemoveMusicExtension.UseVisualStyleBackColor = true;
            this.btnAllRemoveMusicExtension.Click += new System.EventHandler(this.btnAllRemoveMusicExtension_Click);
            // 
            // btnMusicExtensionDefault
            // 
            this.btnMusicExtensionDefault.Location = new System.Drawing.Point(397, 117);
            this.btnMusicExtensionDefault.Name = "btnMusicExtensionDefault";
            this.btnMusicExtensionDefault.Size = new System.Drawing.Size(75, 23);
            this.btnMusicExtensionDefault.TabIndex = 6;
            this.btnMusicExtensionDefault.Text = "Varsayılan";
            this.btnMusicExtensionDefault.UseVisualStyleBackColor = true;
            this.btnMusicExtensionDefault.Click += new System.EventHandler(this.btnMusicExtensionDefault_Click);
            // 
            // btnRemoveMusicExtension
            // 
            this.btnRemoveMusicExtension.Location = new System.Drawing.Point(193, 117);
            this.btnRemoveMusicExtension.Name = "btnRemoveMusicExtension";
            this.btnRemoveMusicExtension.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMusicExtension.TabIndex = 5;
            this.btnRemoveMusicExtension.Text = "Kaldır";
            this.btnRemoveMusicExtension.UseVisualStyleBackColor = true;
            this.btnRemoveMusicExtension.Click += new System.EventHandler(this.btnRemoveMusicExtension_Click);
            // 
            // btnAddMusicExtension
            // 
            this.btnAddMusicExtension.Location = new System.Drawing.Point(112, 118);
            this.btnAddMusicExtension.Name = "btnAddMusicExtension";
            this.btnAddMusicExtension.Size = new System.Drawing.Size(75, 23);
            this.btnAddMusicExtension.TabIndex = 4;
            this.btnAddMusicExtension.Text = "Ekle";
            this.btnAddMusicExtension.UseVisualStyleBackColor = true;
            this.btnAddMusicExtension.Click += new System.EventHandler(this.btnAddMusicExtension_Click);
            // 
            // listboxMusicDirs
            // 
            this.listboxMusicDirs.FormattingEnabled = true;
            this.listboxMusicDirs.HorizontalScrollbar = true;
            this.listboxMusicDirs.Location = new System.Drawing.Point(6, 19);
            this.listboxMusicDirs.Name = "listboxMusicDirs";
            this.listboxMusicDirs.Size = new System.Drawing.Size(475, 82);
            this.listboxMusicDirs.TabIndex = 3;
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Location = new System.Drawing.Point(6, 107);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(75, 23);
            this.btnAddMusic.TabIndex = 4;
            this.btnAddMusic.Text = "Ekle";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // btnRemoveMusic
            // 
            this.btnRemoveMusic.Location = new System.Drawing.Point(87, 106);
            this.btnRemoveMusic.Name = "btnRemoveMusic";
            this.btnRemoveMusic.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMusic.TabIndex = 5;
            this.btnRemoveMusic.Text = "Kaldır";
            this.btnRemoveMusic.UseVisualStyleBackColor = true;
            this.btnRemoveMusic.Click += new System.EventHandler(this.btnRemoveMusic_Click);
            // 
            // btnDefaultMusic
            // 
            this.btnDefaultMusic.Location = new System.Drawing.Point(406, 107);
            this.btnDefaultMusic.Name = "btnDefaultMusic";
            this.btnDefaultMusic.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultMusic.TabIndex = 6;
            this.btnDefaultMusic.Text = "Varsayılan";
            this.btnDefaultMusic.UseVisualStyleBackColor = true;
            this.btnDefaultMusic.Click += new System.EventHandler(this.btnDefaultMusic_Click);
            // 
            // btnAllRemoveMusic
            // 
            this.btnAllRemoveMusic.Location = new System.Drawing.Point(168, 106);
            this.btnAllRemoveMusic.Name = "btnAllRemoveMusic";
            this.btnAllRemoveMusic.Size = new System.Drawing.Size(96, 23);
            this.btnAllRemoveMusic.TabIndex = 8;
            this.btnAllRemoveMusic.Text = "Tümünü Kaldır";
            this.btnAllRemoveMusic.UseVisualStyleBackColor = true;
            this.btnAllRemoveMusic.Click += new System.EventHandler(this.btnAllRemoveMusic_Click);
            // 
            // chkBoxMusicPlayer
            // 
            this.chkBoxMusicPlayer.AutoSize = true;
            this.chkBoxMusicPlayer.Location = new System.Drawing.Point(6, 726);
            this.chkBoxMusicPlayer.Name = "chkBoxMusicPlayer";
            this.chkBoxMusicPlayer.Size = new System.Drawing.Size(129, 17);
            this.chkBoxMusicPlayer.TabIndex = 18;
            this.chkBoxMusicPlayer.Text = "Müzik Oynatıcısı Etkin";
            this.chkBoxMusicPlayer.UseVisualStyleBackColor = true;
            this.chkBoxMusicPlayer.CheckedChanged += new System.EventHandler(this.chkBoxMusicPlayer_CheckedChanged);
            // 
            // grpBoxSlideShowAndTime
            // 
            this.grpBoxSlideShowAndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSlideShowAndTime.Controls.Add(this.chkBoxShowTime);
            this.grpBoxSlideShowAndTime.Controls.Add(this.lblSec);
            this.grpBoxSlideShowAndTime.Controls.Add(this.lblTime);
            this.grpBoxSlideShowAndTime.Controls.Add(this.txtboxTime);
            this.grpBoxSlideShowAndTime.Controls.Add(this.chkBoxPictureAuto);
            this.grpBoxSlideShowAndTime.Location = new System.Drawing.Point(6, 326);
            this.grpBoxSlideShowAndTime.Name = "grpBoxSlideShowAndTime";
            this.grpBoxSlideShowAndTime.Size = new System.Drawing.Size(500, 79);
            this.grpBoxSlideShowAndTime.TabIndex = 16;
            this.grpBoxSlideShowAndTime.TabStop = false;
            this.grpBoxSlideShowAndTime.Text = "Süre";
            // 
            // chkBoxShowTime
            // 
            this.chkBoxShowTime.AutoSize = true;
            this.chkBoxShowTime.Location = new System.Drawing.Point(272, 42);
            this.chkBoxShowTime.Name = "chkBoxShowTime";
            this.chkBoxShowTime.Size = new System.Drawing.Size(89, 17);
            this.chkBoxShowTime.TabIndex = 13;
            this.chkBoxShowTime.Text = "Süreyi Göster";
            this.chkBoxShowTime.UseVisualStyleBackColor = true;
            this.chkBoxShowTime.CheckedChanged += new System.EventHandler(this.chkBoxShowTime_CheckedChanged);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(214, 26);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(37, 13);
            this.lblSec.TabIndex = 12;
            this.lblSec.Text = "saniye";
            // 
            // grpBoxPictureDirList
            // 
            this.grpBoxPictureDirList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxPictureDirList.Controls.Add(this.listboxPictureDirs);
            this.grpBoxPictureDirList.Controls.Add(this.btnAdd);
            this.grpBoxPictureDirList.Controls.Add(this.btnRemove);
            this.grpBoxPictureDirList.Controls.Add(this.btnDefault);
            this.grpBoxPictureDirList.Controls.Add(this.btnAllRemove);
            this.grpBoxPictureDirList.Location = new System.Drawing.Point(6, 19);
            this.grpBoxPictureDirList.Name = "grpBoxPictureDirList";
            this.grpBoxPictureDirList.Size = new System.Drawing.Size(502, 135);
            this.grpBoxPictureDirList.TabIndex = 16;
            this.grpBoxPictureDirList.TabStop = false;
            this.grpBoxPictureDirList.Text = "Resim Klasör Listesi";
            // 
            // grpBoxPictureExtension
            // 
            this.grpBoxPictureExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxPictureExtension.Controls.Add(this.txtboxPictureExtension);
            this.grpBoxPictureExtension.Controls.Add(this.listboxPictureExtensions);
            this.grpBoxPictureExtension.Controls.Add(this.btnAllRemovePictureExtension);
            this.grpBoxPictureExtension.Controls.Add(this.btnPictureExtensionDefault);
            this.grpBoxPictureExtension.Controls.Add(this.btnRemovePictureExtension);
            this.grpBoxPictureExtension.Controls.Add(this.btnAddPictureExtension);
            this.grpBoxPictureExtension.Location = new System.Drawing.Point(6, 160);
            this.grpBoxPictureExtension.Name = "grpBoxPictureExtension";
            this.grpBoxPictureExtension.Size = new System.Drawing.Size(502, 159);
            this.grpBoxPictureExtension.TabIndex = 16;
            this.grpBoxPictureExtension.TabStop = false;
            this.grpBoxPictureExtension.Text = "Dosya Türleri";
            // 
            // btnAllRemovePictureExtension
            // 
            this.btnAllRemovePictureExtension.Location = new System.Drawing.Point(274, 117);
            this.btnAllRemovePictureExtension.Name = "btnAllRemovePictureExtension";
            this.btnAllRemovePictureExtension.Size = new System.Drawing.Size(90, 23);
            this.btnAllRemovePictureExtension.TabIndex = 5;
            this.btnAllRemovePictureExtension.Text = "Tümünü Kaldır";
            this.btnAllRemovePictureExtension.UseVisualStyleBackColor = true;
            this.btnAllRemovePictureExtension.Click += new System.EventHandler(this.btnAllRemovePictureExtension_Click);
            // 
            // btnPictureExtensionDefault
            // 
            this.btnPictureExtensionDefault.Location = new System.Drawing.Point(412, 117);
            this.btnPictureExtensionDefault.Name = "btnPictureExtensionDefault";
            this.btnPictureExtensionDefault.Size = new System.Drawing.Size(75, 23);
            this.btnPictureExtensionDefault.TabIndex = 6;
            this.btnPictureExtensionDefault.Text = "Varsayılan";
            this.btnPictureExtensionDefault.UseVisualStyleBackColor = true;
            this.btnPictureExtensionDefault.Click += new System.EventHandler(this.btnPictureExtensionDefault_Click);
            // 
            // btnRemovePictureExtension
            // 
            this.btnRemovePictureExtension.Location = new System.Drawing.Point(193, 117);
            this.btnRemovePictureExtension.Name = "btnRemovePictureExtension";
            this.btnRemovePictureExtension.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePictureExtension.TabIndex = 5;
            this.btnRemovePictureExtension.Text = "Kaldır";
            this.btnRemovePictureExtension.UseVisualStyleBackColor = true;
            this.btnRemovePictureExtension.Click += new System.EventHandler(this.btnRemovePictureExtension_Click);
            // 
            // grpBoxGeneralSettings
            // 
            this.grpBoxGeneralSettings.Controls.Add(this.cmbBoxLang);
            this.grpBoxGeneralSettings.Controls.Add(this.chkBoxMouseDbClick);
            this.grpBoxGeneralSettings.Controls.Add(this.lbLang);
            this.grpBoxGeneralSettings.Location = new System.Drawing.Point(12, 12);
            this.grpBoxGeneralSettings.Name = "grpBoxGeneralSettings";
            this.grpBoxGeneralSettings.Size = new System.Drawing.Size(468, 768);
            this.grpBoxGeneralSettings.TabIndex = 16;
            this.grpBoxGeneralSettings.TabStop = false;
            this.grpBoxGeneralSettings.Text = "Genel Ayarlar";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 849);
            this.Controls.Add(this.grpBoxGeneralSettings);
            this.Controls.Add(this.grpBoxPictureSlideShow);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.grpBoxPictureSlideShow.ResumeLayout(false);
            this.grpBoxPictureSlideShow.PerformLayout();
            this.grpBoxMusicPlayer.ResumeLayout(false);
            this.grpBoxMusicDirList.ResumeLayout(false);
            this.grpBoxMusicExtension.ResumeLayout(false);
            this.grpBoxMusicExtension.PerformLayout();
            this.grpBoxSlideShowAndTime.ResumeLayout(false);
            this.grpBoxSlideShowAndTime.PerformLayout();
            this.grpBoxPictureDirList.ResumeLayout(false);
            this.grpBoxPictureExtension.ResumeLayout(false);
            this.grpBoxPictureExtension.PerformLayout();
            this.grpBoxGeneralSettings.ResumeLayout(false);
            this.grpBoxGeneralSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBoxMouseDbClick;
        private System.Windows.Forms.Label lbLang;
        private System.Windows.Forms.ListBox listboxPictureDirs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAllRemove;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtboxTime;
        private System.Windows.Forms.CheckBox chkBoxPictureAuto;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox listboxPictureExtensions;
        private System.Windows.Forms.Button btnAddPictureExtension;
        private System.Windows.Forms.TextBox txtboxPictureExtension;
        private System.Windows.Forms.GroupBox grpBoxPictureSlideShow;
        private System.Windows.Forms.GroupBox grpBoxPictureExtension;
        private System.Windows.Forms.GroupBox grpBoxPictureDirList;
        private System.Windows.Forms.GroupBox grpBoxSlideShowAndTime;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Button btnAllRemovePictureExtension;
        private System.Windows.Forms.Button btnRemovePictureExtension;
        private System.Windows.Forms.Button btnPictureExtensionDefault;
        private System.Windows.Forms.GroupBox grpBoxGeneralSettings;
        private System.Windows.Forms.ComboBox cmbBoxLang;
        private System.Windows.Forms.CheckBox chkBoxShowTime;
        private System.Windows.Forms.GroupBox grpBoxMusicPlayer;
        private System.Windows.Forms.GroupBox grpBoxMusicDirList;
        private System.Windows.Forms.ListBox listboxMusicDirs;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Button btnRemoveMusic;
        private System.Windows.Forms.Button btnDefaultMusic;
        private System.Windows.Forms.Button btnAllRemoveMusic;
        private System.Windows.Forms.CheckBox chkBoxMusicPlayer;
        private System.Windows.Forms.GroupBox grpBoxMusicExtension;
        private System.Windows.Forms.TextBox txtboxMusicExtension;
        private System.Windows.Forms.ListBox listboxMusicExtensions;
        private System.Windows.Forms.Button btnAllRemoveMusicExtension;
        private System.Windows.Forms.Button btnMusicExtensionDefault;
        private System.Windows.Forms.Button btnRemoveMusicExtension;
        private System.Windows.Forms.Button btnAddMusicExtension;
    }
}