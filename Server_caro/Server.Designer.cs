
namespace Server_caro
{
    partial class Server
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListClientIP = new System.Windows.Forms.ListBox();
            this.textMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.textIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.textTurn = new Guna.UI2.WinForms.Guna2TextBox();
            this.textClientIp = new Guna.UI2.WinForms.Guna2TextBox();
            this.textInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnConnect = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(52)))), ((int)(((byte)(12)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 667);
            this.panel1.TabIndex = 0;
            // 
            // ListClientIP
            // 
            this.ListClientIP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ListClientIP.FormattingEnabled = true;
            this.ListClientIP.ItemHeight = 20;
            this.ListClientIP.Location = new System.Drawing.Point(891, 412);
            this.ListClientIP.Name = "ListClientIP";
            this.ListClientIP.Size = new System.Drawing.Size(156, 204);
            this.ListClientIP.TabIndex = 19;
            this.ListClientIP.SelectedIndexChanged += new System.EventHandler(this.ListClientIP_SelectedIndexChanged);
            // 
            // textMessage
            // 
            this.textMessage.BorderColor = System.Drawing.Color.Black;
            this.textMessage.BorderThickness = 2;
            this.textMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textMessage.DefaultText = "";
            this.textMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textMessage.DisabledState.Parent = this.textMessage;
            this.textMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMessage.FocusedState.Parent = this.textMessage;
            this.textMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textMessage.ForeColor = System.Drawing.Color.Black;
            this.textMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMessage.HoverState.Parent = this.textMessage;
            this.textMessage.Location = new System.Drawing.Point(721, 452);
            this.textMessage.Name = "textMessage";
            this.textMessage.PasswordChar = '\0';
            this.textMessage.PlaceholderText = "";
            this.textMessage.SelectedText = "";
            this.textMessage.ShadowDecoration.Parent = this.textMessage;
            this.textMessage.Size = new System.Drawing.Size(164, 25);
            this.textMessage.TabIndex = 23;
            // 
            // textIP
            // 
            this.textIP.BorderColor = System.Drawing.Color.Black;
            this.textIP.BorderThickness = 2;
            this.textIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIP.DefaultText = "192.168.1.13:9000";
            this.textIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIP.DisabledState.Parent = this.textIP;
            this.textIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIP.FocusedState.Parent = this.textIP;
            this.textIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textIP.ForeColor = System.Drawing.Color.Black;
            this.textIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textIP.HoverState.Parent = this.textIP;
            this.textIP.Location = new System.Drawing.Point(721, 494);
            this.textIP.Name = "textIP";
            this.textIP.PasswordChar = '\0';
            this.textIP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textIP.PlaceholderText = "";
            this.textIP.SelectedText = "";
            this.textIP.SelectionStart = 17;
            this.textIP.ShadowDecoration.Parent = this.textIP;
            this.textIP.Size = new System.Drawing.Size(164, 25);
            this.textIP.TabIndex = 24;
            // 
            // textTurn
            // 
            this.textTurn.BorderColor = System.Drawing.Color.Black;
            this.textTurn.BorderThickness = 2;
            this.textTurn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTurn.DefaultText = "Server turn";
            this.textTurn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textTurn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textTurn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTurn.DisabledState.Parent = this.textTurn;
            this.textTurn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textTurn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTurn.FocusedState.Parent = this.textTurn;
            this.textTurn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textTurn.ForeColor = System.Drawing.Color.Black;
            this.textTurn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textTurn.HoverState.Parent = this.textTurn;
            this.textTurn.Location = new System.Drawing.Point(721, 412);
            this.textTurn.Name = "textTurn";
            this.textTurn.PasswordChar = '\0';
            this.textTurn.PlaceholderText = "";
            this.textTurn.SelectedText = "";
            this.textTurn.SelectionStart = 11;
            this.textTurn.ShadowDecoration.Parent = this.textTurn;
            this.textTurn.Size = new System.Drawing.Size(164, 25);
            this.textTurn.TabIndex = 25;
            // 
            // textClientIp
            // 
            this.textClientIp.BorderColor = System.Drawing.Color.Black;
            this.textClientIp.BorderThickness = 2;
            this.textClientIp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textClientIp.DefaultText = "";
            this.textClientIp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textClientIp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textClientIp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textClientIp.DisabledState.Parent = this.textClientIp;
            this.textClientIp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textClientIp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textClientIp.FocusedState.Parent = this.textClientIp;
            this.textClientIp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textClientIp.ForeColor = System.Drawing.Color.Black;
            this.textClientIp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textClientIp.HoverState.Parent = this.textClientIp;
            this.textClientIp.Location = new System.Drawing.Point(721, 537);
            this.textClientIp.Name = "textClientIp";
            this.textClientIp.PasswordChar = '\0';
            this.textClientIp.PlaceholderText = "";
            this.textClientIp.SelectedText = "";
            this.textClientIp.ShadowDecoration.Parent = this.textClientIp;
            this.textClientIp.Size = new System.Drawing.Size(164, 25);
            this.textClientIp.TabIndex = 28;
            // 
            // textInfo
            // 
            this.textInfo.BorderColor = System.Drawing.Color.Black;
            this.textInfo.BorderThickness = 2;
            this.textInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textInfo.DefaultText = "";
            this.textInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInfo.DisabledState.Parent = this.textInfo;
            this.textInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInfo.FocusedState.Parent = this.textInfo;
            this.textInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textInfo.ForeColor = System.Drawing.Color.Black;
            this.textInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textInfo.HoverState.Parent = this.textInfo;
            this.textInfo.Location = new System.Drawing.Point(891, 622);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.PasswordChar = '\0';
            this.textInfo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textInfo.PlaceholderText = "";
            this.textInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textInfo.SelectedText = "";
            this.textInfo.ShadowDecoration.Parent = this.textInfo;
            this.textInfo.Size = new System.Drawing.Size(156, 64);
            this.textInfo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(891, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "TURN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Server_caro.Properties.Resources.G2_Esportslogo_square;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(959, 329);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(88, 77);
            this.panel7.TabIndex = 44;
            // 
            // btnReturn
            // 
            this.btnReturn.BorderRadius = 11;
            this.btnReturn.BorderThickness = 2;
            this.btnReturn.CheckedState.Parent = this.btnReturn;
            this.btnReturn.CustomImages.Parent = this.btnReturn;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.DisabledState.Parent = this.btnReturn;
            this.btnReturn.Enabled = false;
            this.btnReturn.FillColor = System.Drawing.Color.Cyan;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.HoverState.Parent = this.btnReturn;
            this.btnReturn.Image = global::Server_caro.Properties.Resources.back;
            this.btnReturn.Location = new System.Drawing.Point(819, 622);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.ShadowDecoration.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(55, 42);
            this.btnReturn.TabIndex = 30;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 11;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Server_caro.Properties.Resources.categories;
            this.guna2Button1.Location = new System.Drawing.Point(697, 622);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(96, 42);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "Newgame";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Server_caro.Properties.Resources.VCT_Challengers_logo;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(685, 537);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 25);
            this.panel6.TabIndex = 26;
            // 
            // BtnConnect
            // 
            this.BtnConnect.BorderRadius = 11;
            this.BtnConnect.BorderThickness = 2;
            this.BtnConnect.CheckedState.Parent = this.BtnConnect;
            this.BtnConnect.CustomImages.Parent = this.BtnConnect;
            this.BtnConnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnConnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnConnect.DisabledState.Parent = this.BtnConnect;
            this.BtnConnect.FillColor = System.Drawing.Color.Cyan;
            this.BtnConnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnConnect.ForeColor = System.Drawing.Color.Black;
            this.BtnConnect.HoverState.Parent = this.BtnConnect;
            this.BtnConnect.Image = global::Server_caro.Properties.Resources.TX_CompetitiveTier_Large_19;
            this.BtnConnect.Location = new System.Drawing.Point(819, 574);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.ShadowDecoration.Parent = this.BtnConnect;
            this.BtnConnect.Size = new System.Drawing.Size(55, 42);
            this.BtnConnect.TabIndex = 27;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BorderRadius = 11;
            this.btnCreate.BorderThickness = 2;
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.DisabledState.Parent = this.btnCreate;
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Image = global::Server_caro.Properties.Resources.admin;
            this.btnCreate.Location = new System.Drawing.Point(697, 574);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(55, 42);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Server_caro.Properties.Resources._902px_Gambit_Esports_2020_logo_svg;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(685, 412);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 25);
            this.panel5.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Server_caro.Properties.Resources.Cloud9logo_profile;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(685, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 25);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Server_caro.Properties.Resources.Fnaticlogo_square;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(685, 452);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 25);
            this.panel4.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::Server_caro.Properties.Resources.Valorant_pink_version_logo_svg;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(685, 345);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 38);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Server_caro.Properties.Resources.agents_group_31d7ce5a;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(685, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 311);
            this.panel2.TabIndex = 2;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1059, 696);
            this.Controls.Add(this.ListClientIP);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textClientIp);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textTurn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Server";
            this.Text = "TCP/Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox ListClientIP;
        private Guna.UI2.WinForms.Guna2TextBox textMessage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox textIP;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox textTurn;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button BtnConnect;
        private Guna.UI2.WinForms.Guna2TextBox textClientIp;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox textInfo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
    }
}

