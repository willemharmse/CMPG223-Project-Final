namespace CMPG223_Final
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlQuotes = new System.Windows.Forms.Panel();
            this.btnAcceptQuote = new System.Windows.Forms.Button();
            this.btnRemoveServiceType = new System.Windows.Forms.Button();
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.lstListServiceTypes = new System.Windows.Forms.ListBox();
            this.cbxServiceType = new System.Windows.Forms.ComboBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.lstQuote = new System.Windows.Forms.ListBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCarModel = new System.Windows.Forms.ComboBox();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.cmbCarColour = new System.Windows.Forms.ComboBox();
            this.cmbCarMakes = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.pnlPayments = new System.Windows.Forms.Panel();
            this.btnProcessPay = new System.Windows.Forms.Button();
            this.txtExpireDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuotes = new System.Windows.Forms.Label();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblMaintain = new System.Windows.Forms.Label();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.gbReports = new System.Windows.Forms.GroupBox();
            this.rbtnPopularService = new System.Windows.Forms.RadioButton();
            this.rbtnPopularMake = new System.Windows.Forms.RadioButton();
            this.btnReport = new System.Windows.Forms.Button();
            this.lstReportOutput = new System.Windows.Forms.ListBox();
            this.lblMakeReports = new System.Windows.Forms.Label();
            this.pnlMaintain = new System.Windows.Forms.Panel();
            this.nudSearchValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSUUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblChooseTable = new System.Windows.Forms.Label();
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblMaintainData = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlQuotes.SuspendLayout();
            this.pnlPayments.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.gbReports.SuspendLayout();
            this.pnlMaintain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearchValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(375, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pro-Tech Auto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(972, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "                                                                               ";
            // 
            // pnlQuotes
            // 
            this.pnlQuotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlQuotes.Controls.Add(this.btnAcceptQuote);
            this.pnlQuotes.Controls.Add(this.btnRemoveServiceType);
            this.pnlQuotes.Controls.Add(this.btnAddServiceType);
            this.pnlQuotes.Controls.Add(this.lstListServiceTypes);
            this.pnlQuotes.Controls.Add(this.cbxServiceType);
            this.pnlQuotes.Controls.Add(this.lblServiceType);
            this.pnlQuotes.Controls.Add(this.btnEmail);
            this.pnlQuotes.Controls.Add(this.btnQuote);
            this.pnlQuotes.Controls.Add(this.lstQuote);
            this.pnlQuotes.Controls.Add(this.lblCar);
            this.pnlQuotes.Controls.Add(this.cmbCarModel);
            this.pnlQuotes.Controls.Add(this.lblCarModel);
            this.pnlQuotes.Controls.Add(this.cmbCarColour);
            this.pnlQuotes.Controls.Add(this.cmbCarMakes);
            this.pnlQuotes.Controls.Add(this.lblService);
            this.pnlQuotes.Controls.Add(this.label10);
            this.pnlQuotes.Controls.Add(this.lblColour);
            this.pnlQuotes.Controls.Add(this.lblCarMake);
            this.pnlQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlQuotes.Location = new System.Drawing.Point(75, 99);
            this.pnlQuotes.Name = "pnlQuotes";
            this.pnlQuotes.Size = new System.Drawing.Size(949, 486);
            this.pnlQuotes.TabIndex = 2;
            this.pnlQuotes.Visible = false;
            // 
            // btnAcceptQuote
            // 
            this.btnAcceptQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAcceptQuote.Enabled = false;
            this.btnAcceptQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptQuote.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptQuote.ForeColor = System.Drawing.Color.White;
            this.btnAcceptQuote.Location = new System.Drawing.Point(610, 443);
            this.btnAcceptQuote.Name = "btnAcceptQuote";
            this.btnAcceptQuote.Size = new System.Drawing.Size(162, 31);
            this.btnAcceptQuote.TabIndex = 47;
            this.btnAcceptQuote.Text = "Accept Quote";
            this.btnAcceptQuote.UseVisualStyleBackColor = false;
            this.btnAcceptQuote.Click += new System.EventHandler(this.btnAcceptQuote_Click);
            // 
            // btnRemoveServiceType
            // 
            this.btnRemoveServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRemoveServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveServiceType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveServiceType.ForeColor = System.Drawing.Color.White;
            this.btnRemoveServiceType.Location = new System.Drawing.Point(177, 252);
            this.btnRemoveServiceType.Name = "btnRemoveServiceType";
            this.btnRemoveServiceType.Size = new System.Drawing.Size(76, 27);
            this.btnRemoveServiceType.TabIndex = 46;
            this.btnRemoveServiceType.Text = "Remove";
            this.btnRemoveServiceType.UseVisualStyleBackColor = false;
            this.btnRemoveServiceType.Click += new System.EventHandler(this.btnRemoveServiceType_Click);
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServiceType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServiceType.ForeColor = System.Drawing.Color.White;
            this.btnAddServiceType.Location = new System.Drawing.Point(91, 252);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(80, 27);
            this.btnAddServiceType.TabIndex = 45;
            this.btnAddServiceType.Text = "Add";
            this.btnAddServiceType.UseVisualStyleBackColor = false;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // lstListServiceTypes
            // 
            this.lstListServiceTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lstListServiceTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListServiceTypes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.lstListServiceTypes.ForeColor = System.Drawing.Color.White;
            this.lstListServiceTypes.FormattingEnabled = true;
            this.lstListServiceTypes.ItemHeight = 12;
            this.lstListServiceTypes.Location = new System.Drawing.Point(92, 304);
            this.lstListServiceTypes.Name = "lstListServiceTypes";
            this.lstListServiceTypes.Size = new System.Drawing.Size(161, 122);
            this.lstListServiceTypes.TabIndex = 44;
            // 
            // cbxServiceType
            // 
            this.cbxServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxServiceType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServiceType.ForeColor = System.Drawing.Color.White;
            this.cbxServiceType.FormattingEnabled = true;
            this.cbxServiceType.Location = new System.Drawing.Point(92, 223);
            this.cbxServiceType.Name = "cbxServiceType";
            this.cbxServiceType.Size = new System.Drawing.Size(161, 20);
            this.cbxServiceType.TabIndex = 43;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.ForeColor = System.Drawing.Color.White;
            this.lblServiceType.Location = new System.Drawing.Point(90, 205);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(77, 12);
            this.lblServiceType.TabIndex = 42;
            this.lblServiceType.Text = "Service Type";
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEmail.Enabled = false;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.White;
            this.btnEmail.Location = new System.Drawing.Point(790, 443);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(115, 31);
            this.btnEmail.TabIndex = 41;
            this.btnEmail.Text = "Email Quote";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuote.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuote.ForeColor = System.Drawing.Color.White;
            this.btnQuote.Location = new System.Drawing.Point(91, 443);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(162, 31);
            this.btnQuote.TabIndex = 40;
            this.btnQuote.Text = "Generate Quote";
            this.btnQuote.UseVisualStyleBackColor = false;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // lstQuote
            // 
            this.lstQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lstQuote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstQuote.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQuote.ForeColor = System.Drawing.Color.White;
            this.lstQuote.FormattingEnabled = true;
            this.lstQuote.ItemHeight = 18;
            this.lstQuote.Location = new System.Drawing.Point(385, 36);
            this.lstQuote.Name = "lstQuote";
            this.lstQuote.Size = new System.Drawing.Size(520, 398);
            this.lstQuote.TabIndex = 39;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.ForeColor = System.Drawing.Color.White;
            this.lblCar.Location = new System.Drawing.Point(59, 36);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(230, 24);
            this.lblCar.TabIndex = 38;
            this.lblCar.Text = "Insert car details here";
            // 
            // cmbCarModel
            // 
            this.cmbCarModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbCarModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCarModel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarModel.ForeColor = System.Drawing.Color.White;
            this.cmbCarModel.FormattingEnabled = true;
            this.cmbCarModel.Location = new System.Drawing.Point(92, 135);
            this.cmbCarModel.Name = "cmbCarModel";
            this.cmbCarModel.Size = new System.Drawing.Size(161, 20);
            this.cmbCarModel.TabIndex = 37;
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.ForeColor = System.Drawing.Color.White;
            this.lblCarModel.Location = new System.Drawing.Point(90, 117);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(61, 12);
            this.lblCarModel.TabIndex = 36;
            this.lblCarModel.Text = "Car Model";
            // 
            // cmbCarColour
            // 
            this.cmbCarColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbCarColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCarColour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarColour.ForeColor = System.Drawing.Color.White;
            this.cmbCarColour.FormattingEnabled = true;
            this.cmbCarColour.Location = new System.Drawing.Point(92, 178);
            this.cmbCarColour.Name = "cmbCarColour";
            this.cmbCarColour.Size = new System.Drawing.Size(161, 20);
            this.cmbCarColour.TabIndex = 35;
            // 
            // cmbCarMakes
            // 
            this.cmbCarMakes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbCarMakes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCarMakes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarMakes.ForeColor = System.Drawing.Color.White;
            this.cmbCarMakes.FormattingEnabled = true;
            this.cmbCarMakes.Location = new System.Drawing.Point(92, 90);
            this.cmbCarMakes.Name = "cmbCarMakes";
            this.cmbCarMakes.Size = new System.Drawing.Size(161, 20);
            this.cmbCarMakes.TabIndex = 34;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.White;
            this.lblService.Location = new System.Drawing.Point(90, 289);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(80, 12);
            this.lblService.TabIndex = 26;
            this.lblService.Text = "Service Items";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(90, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "                                       ";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.ForeColor = System.Drawing.Color.White;
            this.lblColour.Location = new System.Drawing.Point(90, 160);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(65, 12);
            this.lblColour.TabIndex = 16;
            this.lblColour.Text = "Car Colour";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMake.ForeColor = System.Drawing.Color.White;
            this.lblCarMake.Location = new System.Drawing.Point(90, 71);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(57, 12);
            this.lblCarMake.TabIndex = 14;
            this.lblCarMake.Text = "Car Make";
            // 
            // pnlPayments
            // 
            this.pnlPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlPayments.Controls.Add(this.btnProcessPay);
            this.pnlPayments.Controls.Add(this.txtExpireDate);
            this.pnlPayments.Controls.Add(this.label11);
            this.pnlPayments.Controls.Add(this.label12);
            this.pnlPayments.Controls.Add(this.txtCVV);
            this.pnlPayments.Controls.Add(this.label8);
            this.pnlPayments.Controls.Add(this.label9);
            this.pnlPayments.Controls.Add(this.txtCard);
            this.pnlPayments.Controls.Add(this.label6);
            this.pnlPayments.Controls.Add(this.label7);
            this.pnlPayments.Controls.Add(this.label5);
            this.pnlPayments.Controls.Add(this.label4);
            this.pnlPayments.Location = new System.Drawing.Point(71, 102);
            this.pnlPayments.Name = "pnlPayments";
            this.pnlPayments.Size = new System.Drawing.Size(949, 486);
            this.pnlPayments.TabIndex = 41;
            this.pnlPayments.Visible = false;
            // 
            // btnProcessPay
            // 
            this.btnProcessPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnProcessPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessPay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPay.ForeColor = System.Drawing.Color.White;
            this.btnProcessPay.Location = new System.Drawing.Point(370, 348);
            this.btnProcessPay.Name = "btnProcessPay";
            this.btnProcessPay.Size = new System.Drawing.Size(243, 64);
            this.btnProcessPay.TabIndex = 55;
            this.btnProcessPay.Text = "Process Payment";
            this.btnProcessPay.UseVisualStyleBackColor = false;
            this.btnProcessPay.Click += new System.EventHandler(this.btnProcessPay_Click);
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtExpireDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpireDate.ForeColor = System.Drawing.Color.White;
            this.txtExpireDate.Location = new System.Drawing.Point(370, 265);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.Size = new System.Drawing.Size(230, 24);
            this.txtExpireDate.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(367, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Expiration Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(367, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(246, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "                                       ";
            // 
            // txtCVV
            // 
            this.txtCVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.ForeColor = System.Drawing.Color.White;
            this.txtCVV.Location = new System.Drawing.Point(370, 185);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(230, 24);
            this.txtCVV.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(367, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "CVV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(367, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "                                       ";
            // 
            // txtCard
            // 
            this.txtCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.ForeColor = System.Drawing.Color.White;
            this.txtCard.Location = new System.Drawing.Point(370, 108);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(230, 24);
            this.txtCard.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(367, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Card Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(367, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "                                       ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(214, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(532, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "Your banking details will not be saved by the system. It will only be used for th" +
    "is one transaction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(307, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 40);
            this.label4.TabIndex = 16;
            this.label4.Text = "Payment of Service";
            // 
            // lblQuotes
            // 
            this.lblQuotes.AutoSize = true;
            this.lblQuotes.BackColor = System.Drawing.Color.Transparent;
            this.lblQuotes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotes.ForeColor = System.Drawing.Color.White;
            this.lblQuotes.Location = new System.Drawing.Point(77, 59);
            this.lblQuotes.Name = "lblQuotes";
            this.lblQuotes.Size = new System.Drawing.Size(127, 37);
            this.lblQuotes.TabIndex = 3;
            this.lblQuotes.Text = "Quotes";
            this.lblQuotes.Click += new System.EventHandler(this.lblQuotes_Click);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.BackColor = System.Drawing.Color.Transparent;
            this.lblPayments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayments.ForeColor = System.Drawing.Color.White;
            this.lblPayments.Location = new System.Drawing.Point(255, 59);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(252, 37);
            this.lblPayments.TabIndex = 4;
            this.lblPayments.Text = "Pay for Service";
            this.lblPayments.Click += new System.EventHandler(this.lblPayments_Click);
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.BackColor = System.Drawing.Color.Transparent;
            this.lblReports.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.ForeColor = System.Drawing.Color.White;
            this.lblReports.Location = new System.Drawing.Point(590, 59);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(140, 37);
            this.lblReports.TabIndex = 5;
            this.lblReports.Text = "Reports";
            this.lblReports.Click += new System.EventHandler(this.lblReports_Click);
            // 
            // lblMaintain
            // 
            this.lblMaintain.AutoSize = true;
            this.lblMaintain.BackColor = System.Drawing.Color.Transparent;
            this.lblMaintain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintain.ForeColor = System.Drawing.Color.White;
            this.lblMaintain.Location = new System.Drawing.Point(790, 59);
            this.lblMaintain.Name = "lblMaintain";
            this.lblMaintain.Size = new System.Drawing.Size(230, 37);
            this.lblMaintain.TabIndex = 6;
            this.lblMaintain.Text = "Maintain Data";
            this.lblMaintain.Click += new System.EventHandler(this.lblMaintain_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlReports.Controls.Add(this.gbReports);
            this.pnlReports.Controls.Add(this.btnReport);
            this.pnlReports.Controls.Add(this.lstReportOutput);
            this.pnlReports.Controls.Add(this.lblMakeReports);
            this.pnlReports.Location = new System.Drawing.Point(71, 102);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(949, 486);
            this.pnlReports.TabIndex = 42;
            this.pnlReports.Visible = false;
            // 
            // gbReports
            // 
            this.gbReports.Controls.Add(this.rbtnPopularService);
            this.gbReports.Controls.Add(this.rbtnPopularMake);
            this.gbReports.Location = new System.Drawing.Point(83, 94);
            this.gbReports.Name = "gbReports";
            this.gbReports.Size = new System.Drawing.Size(210, 170);
            this.gbReports.TabIndex = 53;
            this.gbReports.TabStop = false;
            // 
            // rbtnPopularService
            // 
            this.rbtnPopularService.AutoSize = true;
            this.rbtnPopularService.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPopularService.ForeColor = System.Drawing.Color.White;
            this.rbtnPopularService.Location = new System.Drawing.Point(27, 104);
            this.rbtnPopularService.Name = "rbtnPopularService";
            this.rbtnPopularService.Size = new System.Drawing.Size(163, 19);
            this.rbtnPopularService.TabIndex = 1;
            this.rbtnPopularService.TabStop = true;
            this.rbtnPopularService.Text = "Most Popular Service";
            this.rbtnPopularService.UseVisualStyleBackColor = true;
            // 
            // rbtnPopularMake
            // 
            this.rbtnPopularMake.AutoSize = true;
            this.rbtnPopularMake.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPopularMake.ForeColor = System.Drawing.Color.White;
            this.rbtnPopularMake.Location = new System.Drawing.Point(27, 40);
            this.rbtnPopularMake.Name = "rbtnPopularMake";
            this.rbtnPopularMake.Size = new System.Drawing.Size(147, 19);
            this.rbtnPopularMake.TabIndex = 0;
            this.rbtnPopularMake.TabStop = true;
            this.rbtnPopularMake.Text = "Most Popular Make";
            this.rbtnPopularMake.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(100, 411);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(162, 31);
            this.btnReport.TabIndex = 52;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lstReportOutput
            // 
            this.lstReportOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lstReportOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstReportOutput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReportOutput.ForeColor = System.Drawing.Color.White;
            this.lstReportOutput.FormattingEnabled = true;
            this.lstReportOutput.ItemHeight = 18;
            this.lstReportOutput.Location = new System.Drawing.Point(377, 44);
            this.lstReportOutput.Name = "lstReportOutput";
            this.lstReportOutput.Size = new System.Drawing.Size(520, 398);
            this.lstReportOutput.TabIndex = 51;
            // 
            // lblMakeReports
            // 
            this.lblMakeReports.AutoSize = true;
            this.lblMakeReports.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeReports.ForeColor = System.Drawing.Color.White;
            this.lblMakeReports.Location = new System.Drawing.Point(87, 44);
            this.lblMakeReports.Name = "lblMakeReports";
            this.lblMakeReports.Size = new System.Drawing.Size(162, 24);
            this.lblMakeReports.TabIndex = 50;
            this.lblMakeReports.Text = "Choose Report";
            // 
            // pnlMaintain
            // 
            this.pnlMaintain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlMaintain.Controls.Add(this.nudSearchValue);
            this.pnlMaintain.Controls.Add(this.label2);
            this.pnlMaintain.Controls.Add(this.txtSearch);
            this.pnlMaintain.Controls.Add(this.lblSUUsername);
            this.pnlMaintain.Controls.Add(this.label3);
            this.pnlMaintain.Controls.Add(this.btnUpdate);
            this.pnlMaintain.Controls.Add(this.btnDelete);
            this.pnlMaintain.Controls.Add(this.lblChooseTable);
            this.pnlMaintain.Controls.Add(this.cbxTable);
            this.pnlMaintain.Controls.Add(this.dataGridView1);
            this.pnlMaintain.Controls.Add(this.btnInsert);
            this.pnlMaintain.Controls.Add(this.lblMaintainData);
            this.pnlMaintain.Location = new System.Drawing.Point(71, 102);
            this.pnlMaintain.Name = "pnlMaintain";
            this.pnlMaintain.Size = new System.Drawing.Size(949, 486);
            this.pnlMaintain.TabIndex = 43;
            this.pnlMaintain.Visible = false;
            // 
            // nudSearchValue
            // 
            this.nudSearchValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.nudSearchValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.nudSearchValue.ForeColor = System.Drawing.Color.White;
            this.nudSearchValue.Location = new System.Drawing.Point(46, 330);
            this.nudSearchValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSearchValue.Name = "nudSearchValue";
            this.nudSearchValue.Size = new System.Drawing.Size(247, 23);
            this.nudSearchValue.TabIndex = 62;
            this.nudSearchValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "General Search by Number";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(47, 271);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 18);
            this.txtSearch.TabIndex = 58;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSUUsername
            // 
            this.lblSUUsername.AutoSize = true;
            this.lblSUUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUUsername.ForeColor = System.Drawing.Color.White;
            this.lblSUUsername.Location = new System.Drawing.Point(44, 249);
            this.lblSUUsername.Name = "lblSUUsername";
            this.lblSUUsername.Size = new System.Drawing.Size(158, 15);
            this.lblSUUsername.TabIndex = 59;
            this.lblSUUsername.Text = "General Search by Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "                                                               ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(46, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 31);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(193, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 31);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblChooseTable
            // 
            this.lblChooseTable.AutoSize = true;
            this.lblChooseTable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseTable.ForeColor = System.Drawing.Color.White;
            this.lblChooseTable.Location = new System.Drawing.Point(45, 70);
            this.lblChooseTable.Name = "lblChooseTable";
            this.lblChooseTable.Size = new System.Drawing.Size(95, 15);
            this.lblChooseTable.TabIndex = 55;
            this.lblChooseTable.Text = "Choose Table";
            // 
            // cbxTable
            // 
            this.cbxTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTable.ForeColor = System.Drawing.Color.White;
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.Items.AddRange(new object[] {
            "Admin",
            "CarColour",
            "CarMake",
            "CarModel",
            "Clients",
            "Mechanic",
            "Service",
            "Vehicle",
            "Service_on_Vehicle"});
            this.cbxTable.Location = new System.Drawing.Point(46, 94);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(247, 20);
            this.cbxTable.TabIndex = 54;
            this.cbxTable.SelectedIndexChanged += new System.EventHandler(this.cbxTable_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(401, 23);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(523, 437);
            this.dataGridView1.TabIndex = 53;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(46, 134);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 31);
            this.btnInsert.TabIndex = 52;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblMaintainData
            // 
            this.lblMaintainData.AutoSize = true;
            this.lblMaintainData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainData.ForeColor = System.Drawing.Color.White;
            this.lblMaintainData.Location = new System.Drawing.Point(79, 20);
            this.lblMaintainData.Name = "lblMaintainData";
            this.lblMaintainData.Size = new System.Drawing.Size(148, 24);
            this.lblMaintainData.TabIndex = 50;
            this.lblMaintainData.Text = "Maintain Data";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(902, 596);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(122, 31);
            this.btnLogOut.TabIndex = 54;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(71, 596);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(98, 31);
            this.btnHelp.TabIndex = 55;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPG223_Final.Properties.Resources.CMPG_223_background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 639);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblMaintain);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.lblQuotes);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlQuotes);
            this.Controls.Add(this.pnlMaintain);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.pnlPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlQuotes.ResumeLayout(false);
            this.pnlQuotes.PerformLayout();
            this.pnlPayments.ResumeLayout(false);
            this.pnlPayments.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            this.gbReports.ResumeLayout(false);
            this.gbReports.PerformLayout();
            this.pnlMaintain.ResumeLayout(false);
            this.pnlMaintain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSearchValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlQuotes;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.ComboBox cmbCarMakes;
        private System.Windows.Forms.ComboBox cmbCarModel;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.ComboBox cmbCarColour;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblQuotes;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblMaintain;
        private System.Windows.Forms.ListBox lstQuote;
        private System.Windows.Forms.Panel pnlPayments;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ListBox lstReportOutput;
        private System.Windows.Forms.Label lblMakeReports;
        private System.Windows.Forms.Panel pnlMaintain;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblChooseTable;
        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblMaintainData;
        private System.Windows.Forms.ComboBox cbxServiceType;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Button btnAddServiceType;
        private System.Windows.Forms.ListBox lstListServiceTypes;
        private System.Windows.Forms.Button btnRemoveServiceType;
        private System.Windows.Forms.Button btnAcceptQuote;
        private System.Windows.Forms.GroupBox gbReports;
        private System.Windows.Forms.RadioButton rbtnPopularMake;
        private System.Windows.Forms.RadioButton rbtnPopularService;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSUUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSearchValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcessPay;
        private System.Windows.Forms.TextBox txtExpireDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}