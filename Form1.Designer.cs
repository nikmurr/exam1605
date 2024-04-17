namespace AdmissionCommittee
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
            this.pkPanel = new System.Windows.Forms.Panel();
            this.miniButtonBack3 = new AdmissionCommittee.DefaultButton();
            this.applPanel = new System.Windows.Forms.Panel();
            this.miniButtonBack2 = new AdmissionCommittee.DefaultButton();
            this.regPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.defaultButtonAcceptRegFinal = new AdmissionCommittee.DefaultButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.inputFieldRegLogin = new AdmissionCommittee.InputField();
            this.inputFieldRegPassword = new AdmissionCommittee.InputField();
            this.defaultButtonAcceptReg = new AdmissionCommittee.DefaultButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.inputFieldFIO = new AdmissionCommittee.InputField();
            this.inputFieldBD = new AdmissionCommittee.MaskedInputField();
            this.inputComboLevel = new AdmissionCommittee.ComboInput();
            this.inputFieldPass = new AdmissionCommittee.MaskedInputField();
            this.inputFieldSnils = new AdmissionCommittee.MaskedInputField();
            this.inputFieldPhone = new AdmissionCommittee.MaskedInputField();
            this.inputFieldMail = new AdmissionCommittee.InputField();
            this.inputFieldParFIO = new AdmissionCommittee.InputField();
            this.inputFieldUniv = new AdmissionCommittee.InputField();
            this.inputFieldScore = new AdmissionCommittee.InputField();
            this.inputComboDir = new AdmissionCommittee.ComboInput();
            this.miniButtonBack = new AdmissionCommittee.DefaultButton();
            this.headerReg = new System.Windows.Forms.Label();
            this.authPanel = new System.Windows.Forms.Panel();
            this.authPanel2 = new System.Windows.Forms.Panel();
            this.flowApplPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.defaultButtonApplReg = new AdmissionCommittee.DefaultButton();
            this.defaultButtonApplAuth = new AdmissionCommittee.DefaultButton();
            this.inputFieldPassword = new AdmissionCommittee.InputField();
            this.inputFieldLogin = new AdmissionCommittee.InputField();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.stateButtonAppl = new AdmissionCommittee.StateButton();
            this.stateButtonPK = new AdmissionCommittee.StateButton();
            this.headerAuth = new System.Windows.Forms.Label();
            this.pkPanel.SuspendLayout();
            this.applPanel.SuspendLayout();
            this.regPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.authPanel.SuspendLayout();
            this.authPanel2.SuspendLayout();
            this.flowApplPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pkPanel
            // 
            this.pkPanel.BackgroundImage = global::AdmissionCommittee.Properties.Resources.PanelMode01;
            this.pkPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pkPanel.Controls.Add(this.miniButtonBack3);
            this.pkPanel.Location = new System.Drawing.Point(10, 10);
            this.pkPanel.Name = "pkPanel";
            this.pkPanel.Size = new System.Drawing.Size(940, 700);
            this.pkPanel.TabIndex = 3;
            this.pkPanel.Visible = false;
            // 
            // miniButtonBack3
            // 
            this.miniButtonBack3.AutoSize = true;
            this.miniButtonBack3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.miniButtonBack3.Location = new System.Drawing.Point(46, 64);
            this.miniButtonBack3.Margin = new System.Windows.Forms.Padding(0);
            this.miniButtonBack3.Name = "miniButtonBack3";
            this.miniButtonBack3.Size = new System.Drawing.Size(48, 48);
            this.miniButtonBack3.state = false;
            this.miniButtonBack3.TabIndex = 5;
            // 
            // applPanel
            // 
            this.applPanel.BackgroundImage = global::AdmissionCommittee.Properties.Resources.PanelMode02;
            this.applPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.applPanel.Controls.Add(this.miniButtonBack2);
            this.applPanel.Location = new System.Drawing.Point(10, 10);
            this.applPanel.Name = "applPanel";
            this.applPanel.Size = new System.Drawing.Size(940, 700);
            this.applPanel.TabIndex = 2;
            this.applPanel.Visible = false;
            // 
            // miniButtonBack2
            // 
            this.miniButtonBack2.AutoSize = true;
            this.miniButtonBack2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.miniButtonBack2.Location = new System.Drawing.Point(46, 64);
            this.miniButtonBack2.Margin = new System.Windows.Forms.Padding(0);
            this.miniButtonBack2.Name = "miniButtonBack2";
            this.miniButtonBack2.Size = new System.Drawing.Size(48, 48);
            this.miniButtonBack2.state = false;
            this.miniButtonBack2.TabIndex = 5;
            // 
            // regPanel
            // 
            this.regPanel.BackgroundImage = global::AdmissionCommittee.Properties.Resources.BG_Autho;
            this.regPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regPanel.Controls.Add(this.panel2);
            this.regPanel.Location = new System.Drawing.Point(10, 10);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(940, 700);
            this.regPanel.TabIndex = 1;
            this.regPanel.Visible = false;
            this.regPanel.VisibleChanged += new System.EventHandler(this.regPanel_VisibleChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.defaultButtonAcceptRegFinal);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.defaultButtonAcceptReg);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.miniButtonBack);
            this.panel2.Controls.Add(this.headerReg);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(47, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 607);
            this.panel2.TabIndex = 0;
            // 
            // defaultButtonAcceptRegFinal
            // 
            this.defaultButtonAcceptRegFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultButtonAcceptRegFinal.AutoSize = true;
            this.defaultButtonAcceptRegFinal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.defaultButtonAcceptRegFinal.Location = new System.Drawing.Point(799, 559);
            this.defaultButtonAcceptRegFinal.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.defaultButtonAcceptRegFinal.Name = "defaultButtonAcceptRegFinal";
            this.defaultButtonAcceptRegFinal.Size = new System.Drawing.Size(48, 48);
            this.defaultButtonAcceptRegFinal.state = false;
            this.defaultButtonAcceptRegFinal.TabIndex = 8;
            this.defaultButtonAcceptRegFinal.Visible = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.inputFieldRegLogin);
            this.flowLayoutPanel3.Controls.Add(this.inputFieldRegPassword);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 108);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(847, 439);
            this.flowLayoutPanel3.TabIndex = 7;
            this.flowLayoutPanel3.Visible = false;
            // 
            // inputFieldRegLogin
            // 
            this.inputFieldRegLogin.AutoSize = true;
            this.inputFieldRegLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldRegLogin.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldRegLogin.Location = new System.Drawing.Point(0, 0);
            this.inputFieldRegLogin.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputFieldRegLogin.Name = "inputFieldRegLogin";
            this.inputFieldRegLogin.Size = new System.Drawing.Size(272, 97);
            this.inputFieldRegLogin.TabIndex = 0;
            // 
            // inputFieldRegPassword
            // 
            this.inputFieldRegPassword.AutoSize = true;
            this.inputFieldRegPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldRegPassword.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldRegPassword.Location = new System.Drawing.Point(287, 0);
            this.inputFieldRegPassword.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputFieldRegPassword.Name = "inputFieldRegPassword";
            this.inputFieldRegPassword.Size = new System.Drawing.Size(272, 97);
            this.inputFieldRegPassword.TabIndex = 15;
            // 
            // defaultButtonAcceptReg
            // 
            this.defaultButtonAcceptReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultButtonAcceptReg.AutoSize = true;
            this.defaultButtonAcceptReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.defaultButtonAcceptReg.Location = new System.Drawing.Point(799, 559);
            this.defaultButtonAcceptReg.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.defaultButtonAcceptReg.Name = "defaultButtonAcceptReg";
            this.defaultButtonAcceptReg.Size = new System.Drawing.Size(48, 48);
            this.defaultButtonAcceptReg.state = false;
            this.defaultButtonAcceptReg.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.inputFieldFIO);
            this.flowLayoutPanel2.Controls.Add(this.inputFieldBD);
            this.flowLayoutPanel2.Controls.Add(this.inputComboLevel);
            this.flowLayoutPanel2.Controls.Add(this.inputFieldPass);
            this.flowLayoutPanel2.Controls.Add(this.inputFieldSnils);
            this.flowLayoutPanel2.Controls.Add(this.inputFieldPhone);
            this.flowLayoutPanel2.Controls.Add(this.inputFieldMail);
            this.flowLayoutPanel2.Controls.Add(this.inputFieldParFIO);
            this.flowLayoutPanel2.Controls.Add(this.inputFieldUniv);
            this.flowLayoutPanel2.Controls.Add(this.inputFieldScore);
            this.flowLayoutPanel2.Controls.Add(this.inputComboDir);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 108);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(847, 439);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // inputFieldFIO
            // 
            this.inputFieldFIO.AutoSize = true;
            this.inputFieldFIO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldFIO.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldFIO.Location = new System.Drawing.Point(0, 0);
            this.inputFieldFIO.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputFieldFIO.Name = "inputFieldFIO";
            this.inputFieldFIO.Size = new System.Drawing.Size(272, 97);
            this.inputFieldFIO.TabIndex = 0;
            // 
            // inputFieldBD
            // 
            this.inputFieldBD.AutoSize = true;
            this.inputFieldBD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldBD.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldBD.Location = new System.Drawing.Point(287, 0);
            this.inputFieldBD.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputFieldBD.Name = "inputFieldBD";
            this.inputFieldBD.Size = new System.Drawing.Size(272, 97);
            this.inputFieldBD.TabIndex = 11;
            // 
            // inputComboLevel
            // 
            this.inputComboLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputComboLevel.BackColor = System.Drawing.Color.Transparent;
            this.inputComboLevel.Location = new System.Drawing.Point(574, 0);
            this.inputComboLevel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.inputComboLevel.Name = "inputComboLevel";
            this.inputComboLevel.Size = new System.Drawing.Size(272, 97);
            this.inputComboLevel.TabIndex = 9;
            // 
            // inputFieldPass
            // 
            this.inputFieldPass.AutoSize = true;
            this.inputFieldPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldPass.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldPass.Location = new System.Drawing.Point(0, 113);
            this.inputFieldPass.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputFieldPass.Name = "inputFieldPass";
            this.inputFieldPass.Size = new System.Drawing.Size(272, 97);
            this.inputFieldPass.TabIndex = 12;
            // 
            // inputFieldSnils
            // 
            this.inputFieldSnils.AutoSize = true;
            this.inputFieldSnils.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldSnils.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldSnils.Location = new System.Drawing.Point(287, 113);
            this.inputFieldSnils.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputFieldSnils.Name = "inputFieldSnils";
            this.inputFieldSnils.Size = new System.Drawing.Size(272, 97);
            this.inputFieldSnils.TabIndex = 14;
            // 
            // inputFieldPhone
            // 
            this.inputFieldPhone.AutoSize = true;
            this.inputFieldPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldPhone.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldPhone.Location = new System.Drawing.Point(574, 113);
            this.inputFieldPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.inputFieldPhone.Name = "inputFieldPhone";
            this.inputFieldPhone.Size = new System.Drawing.Size(272, 97);
            this.inputFieldPhone.TabIndex = 13;
            // 
            // inputFieldMail
            // 
            this.inputFieldMail.AutoSize = true;
            this.inputFieldMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldMail.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldMail.Location = new System.Drawing.Point(0, 226);
            this.inputFieldMail.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputFieldMail.Name = "inputFieldMail";
            this.inputFieldMail.Size = new System.Drawing.Size(272, 97);
            this.inputFieldMail.TabIndex = 15;
            // 
            // inputFieldParFIO
            // 
            this.inputFieldParFIO.AutoSize = true;
            this.inputFieldParFIO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldParFIO.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldParFIO.Location = new System.Drawing.Point(287, 226);
            this.inputFieldParFIO.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputFieldParFIO.Name = "inputFieldParFIO";
            this.inputFieldParFIO.Size = new System.Drawing.Size(272, 97);
            this.inputFieldParFIO.TabIndex = 6;
            // 
            // inputFieldUniv
            // 
            this.inputFieldUniv.AutoSize = true;
            this.inputFieldUniv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldUniv.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldUniv.Location = new System.Drawing.Point(574, 226);
            this.inputFieldUniv.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.inputFieldUniv.Name = "inputFieldUniv";
            this.inputFieldUniv.Size = new System.Drawing.Size(272, 97);
            this.inputFieldUniv.TabIndex = 7;
            // 
            // inputFieldScore
            // 
            this.inputFieldScore.AutoSize = true;
            this.inputFieldScore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldScore.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldScore.Location = new System.Drawing.Point(0, 339);
            this.inputFieldScore.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputFieldScore.Name = "inputFieldScore";
            this.inputFieldScore.Size = new System.Drawing.Size(272, 97);
            this.inputFieldScore.TabIndex = 8;
            // 
            // inputComboDir
            // 
            this.inputComboDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputComboDir.BackColor = System.Drawing.Color.Transparent;
            this.inputComboDir.Location = new System.Drawing.Point(287, 339);
            this.inputComboDir.Margin = new System.Windows.Forms.Padding(0, 0, 15, 16);
            this.inputComboDir.Name = "inputComboDir";
            this.inputComboDir.Size = new System.Drawing.Size(272, 97);
            this.inputComboDir.TabIndex = 10;
            // 
            // miniButtonBack
            // 
            this.miniButtonBack.AutoSize = true;
            this.miniButtonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.miniButtonBack.Location = new System.Drawing.Point(0, 26);
            this.miniButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.miniButtonBack.Name = "miniButtonBack";
            this.miniButtonBack.Size = new System.Drawing.Size(48, 48);
            this.miniButtonBack.state = false;
            this.miniButtonBack.TabIndex = 5;
            // 
            // headerReg
            // 
            this.headerReg.AutoSize = true;
            this.headerReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerReg.ForeColor = System.Drawing.Color.Black;
            this.headerReg.Location = new System.Drawing.Point(48, 0);
            this.headerReg.Name = "headerReg";
            this.headerReg.Size = new System.Drawing.Size(460, 82);
            this.headerReg.TabIndex = 0;
            this.headerReg.Text = "Регистрация";
            // 
            // authPanel
            // 
            this.authPanel.BackgroundImage = global::AdmissionCommittee.Properties.Resources.BG_Autho_Pic;
            this.authPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.authPanel.Controls.Add(this.authPanel2);
            this.authPanel.Location = new System.Drawing.Point(10, 10);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(940, 700);
            this.authPanel.TabIndex = 0;
            // 
            // authPanel2
            // 
            this.authPanel2.BackColor = System.Drawing.Color.White;
            this.authPanel2.Controls.Add(this.flowApplPanel);
            this.authPanel2.Controls.Add(this.flowLayoutPanel1);
            this.authPanel2.Controls.Add(this.headerAuth);
            this.authPanel2.ForeColor = System.Drawing.Color.White;
            this.authPanel2.Location = new System.Drawing.Point(518, 45);
            this.authPanel2.Name = "authPanel2";
            this.authPanel2.Size = new System.Drawing.Size(374, 607);
            this.authPanel2.TabIndex = 0;
            // 
            // flowApplPanel
            // 
            this.flowApplPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowApplPanel.AutoSize = true;
            this.flowApplPanel.Controls.Add(this.defaultButtonApplReg);
            this.flowApplPanel.Controls.Add(this.defaultButtonApplAuth);
            this.flowApplPanel.Controls.Add(this.inputFieldPassword);
            this.flowApplPanel.Controls.Add(this.inputFieldLogin);
            this.flowApplPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowApplPanel.Location = new System.Drawing.Point(0, 207);
            this.flowApplPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowApplPanel.Name = "flowApplPanel";
            this.flowApplPanel.Size = new System.Drawing.Size(374, 400);
            this.flowApplPanel.TabIndex = 4;
            // 
            // defaultButtonApplReg
            // 
            this.defaultButtonApplReg.AutoSize = true;
            this.defaultButtonApplReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.defaultButtonApplReg.Location = new System.Drawing.Point(0, 352);
            this.defaultButtonApplReg.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.defaultButtonApplReg.Name = "defaultButtonApplReg";
            this.defaultButtonApplReg.Size = new System.Drawing.Size(48, 48);
            this.defaultButtonApplReg.state = false;
            this.defaultButtonApplReg.TabIndex = 1;
            // 
            // defaultButtonApplAuth
            // 
            this.defaultButtonApplAuth.AutoSize = true;
            this.defaultButtonApplAuth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.defaultButtonApplAuth.Location = new System.Drawing.Point(0, 292);
            this.defaultButtonApplAuth.Margin = new System.Windows.Forms.Padding(0, 82, 0, 0);
            this.defaultButtonApplAuth.Name = "defaultButtonApplAuth";
            this.defaultButtonApplAuth.Size = new System.Drawing.Size(48, 48);
            this.defaultButtonApplAuth.state = false;
            this.defaultButtonApplAuth.TabIndex = 0;
            // 
            // inputFieldPassword
            // 
            this.inputFieldPassword.AutoSize = true;
            this.inputFieldPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldPassword.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldPassword.Location = new System.Drawing.Point(0, 113);
            this.inputFieldPassword.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.inputFieldPassword.Name = "inputFieldPassword";
            this.inputFieldPassword.Size = new System.Drawing.Size(374, 97);
            this.inputFieldPassword.TabIndex = 3;
            // 
            // inputFieldLogin
            // 
            this.inputFieldLogin.AutoSize = true;
            this.inputFieldLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inputFieldLogin.BackColor = System.Drawing.Color.Transparent;
            this.inputFieldLogin.Location = new System.Drawing.Point(0, 0);
            this.inputFieldLogin.Margin = new System.Windows.Forms.Padding(0);
            this.inputFieldLogin.Name = "inputFieldLogin";
            this.inputFieldLogin.Size = new System.Drawing.Size(374, 97);
            this.inputFieldLogin.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.stateButtonAppl);
            this.flowLayoutPanel1.Controls.Add(this.stateButtonPK);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(108, 48);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // stateButtonAppl
            // 
            this.stateButtonAppl.AutoSize = true;
            this.stateButtonAppl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stateButtonAppl.isSet = false;
            this.stateButtonAppl.Location = new System.Drawing.Point(0, 0);
            this.stateButtonAppl.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.stateButtonAppl.Name = "stateButtonAppl";
            this.stateButtonAppl.Size = new System.Drawing.Size(48, 48);
            this.stateButtonAppl.TabIndex = 4;
            // 
            // stateButtonPK
            // 
            this.stateButtonPK.AutoSize = true;
            this.stateButtonPK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stateButtonPK.isSet = false;
            this.stateButtonPK.Location = new System.Drawing.Point(60, 0);
            this.stateButtonPK.Margin = new System.Windows.Forms.Padding(0);
            this.stateButtonPK.Name = "stateButtonPK";
            this.stateButtonPK.Size = new System.Drawing.Size(48, 48);
            this.stateButtonPK.TabIndex = 5;
            // 
            // headerAuth
            // 
            this.headerAuth.AutoSize = true;
            this.headerAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerAuth.ForeColor = System.Drawing.Color.Black;
            this.headerAuth.Location = new System.Drawing.Point(-18, 0);
            this.headerAuth.Name = "headerAuth";
            this.headerAuth.Size = new System.Drawing.Size(201, 82);
            this.headerAuth.TabIndex = 0;
            this.headerAuth.Text = "Вход";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.pkPanel);
            this.Controls.Add(this.applPanel);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.authPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pkPanel.ResumeLayout(false);
            this.pkPanel.PerformLayout();
            this.applPanel.ResumeLayout(false);
            this.applPanel.PerformLayout();
            this.regPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.authPanel.ResumeLayout(false);
            this.authPanel2.ResumeLayout(false);
            this.authPanel2.PerformLayout();
            this.flowApplPanel.ResumeLayout(false);
            this.flowApplPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.Panel authPanel2;
        private System.Windows.Forms.Label headerAuth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private StateButton stateButtonAppl;
        private StateButton stateButtonPK;
        private System.Windows.Forms.FlowLayoutPanel flowApplPanel;
        private DefaultButton defaultButtonApplAuth;
        private DefaultButton defaultButtonApplReg;
        private InputField inputFieldPassword;
        private InputField inputFieldLogin;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label headerReg;
        private DefaultButton miniButtonBack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private InputField inputFieldFIO;
        private InputField inputFieldParFIO;
        private InputField inputFieldUniv;
        private InputField inputFieldScore;
        private ComboInput inputComboLevel;
        private ComboInput inputComboDir;
        private DefaultButton defaultButtonAcceptReg;
        private MaskedInputField inputFieldBD;
        private MaskedInputField inputFieldPass;
        private MaskedInputField inputFieldSnils;
        private MaskedInputField inputFieldPhone;
        private InputField inputFieldMail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private InputField inputFieldRegLogin;
        private InputField inputFieldRegPassword;
        private DefaultButton defaultButtonAcceptRegFinal;
        private System.Windows.Forms.Panel applPanel;
        private DefaultButton miniButtonBack2;
        private System.Windows.Forms.Panel pkPanel;
        private DefaultButton miniButtonBack3;
    }
}

