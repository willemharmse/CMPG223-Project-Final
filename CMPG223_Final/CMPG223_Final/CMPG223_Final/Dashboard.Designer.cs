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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlQuotes = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.lstQuote = new System.Windows.Forms.ListBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCarModel = new System.Windows.Forms.ComboBox();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.cmbCarColour = new System.Windows.Forms.ComboBox();
            this.cmbCarMakes = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.pnlPayments = new System.Windows.Forms.Panel();
            this.lblQuotes = new System.Windows.Forms.Label();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblMaintain = new System.Windows.Forms.Label();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblMakeReports = new System.Windows.Forms.Label();
            this.pnlMaintain = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblChooseTable = new System.Windows.Forms.Label();
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblMaintainData = new System.Windows.Forms.Label();
            this.cbxServiceType = new System.Windows.Forms.ComboBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.pnlQuotes.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlMaintain.SuspendLayout();
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
            this.pnlQuotes.Controls.Add(this.cbxServiceType);
            this.pnlQuotes.Controls.Add(this.lblServiceType);
            this.pnlQuotes.Controls.Add(this.btnPrint);
            this.pnlQuotes.Controls.Add(this.btnQuote);
            this.pnlQuotes.Controls.Add(this.lstQuote);
            this.pnlQuotes.Controls.Add(this.lblCar);
            this.pnlQuotes.Controls.Add(this.cmbCarModel);
            this.pnlQuotes.Controls.Add(this.lblCarModel);
            this.pnlQuotes.Controls.Add(this.cmbCarColour);
            this.pnlQuotes.Controls.Add(this.cmbCarMakes);
            this.pnlQuotes.Controls.Add(this.textBox4);
            this.pnlQuotes.Controls.Add(this.lblService);
            this.pnlQuotes.Controls.Add(this.label10);
            this.pnlQuotes.Controls.Add(this.lblColour);
            this.pnlQuotes.Controls.Add(this.lblCarMake);
            this.pnlQuotes.Location = new System.Drawing.Point(75, 99);
            this.pnlQuotes.Name = "pnlQuotes";
            this.pnlQuotes.Size = new System.Drawing.Size(949, 486);
            this.pnlQuotes.TabIndex = 2;
            this.pnlQuotes.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(790, 443);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(115, 31);
            this.btnPrint.TabIndex = 41;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
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
            this.cmbCarModel.Location = new System.Drawing.Point(92, 146);
            this.cmbCarModel.Name = "cmbCarModel";
            this.cmbCarModel.Size = new System.Drawing.Size(161, 20);
            this.cmbCarModel.TabIndex = 37;
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.ForeColor = System.Drawing.Color.White;
            this.lblCarModel.Location = new System.Drawing.Point(90, 128);
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
            this.cmbCarColour.Location = new System.Drawing.Point(92, 189);
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
            this.cmbCarMakes.Location = new System.Drawing.Point(92, 101);
            this.cmbCarMakes.Name = "cmbCarMakes";
            this.cmbCarMakes.Size = new System.Drawing.Size(161, 20);
            this.cmbCarMakes.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(91, 276);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(162, 119);
            this.textBox4.TabIndex = 27;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.White;
            this.lblService.Location = new System.Drawing.Point(90, 261);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(147, 12);
            this.lblService.TabIndex = 26;
            this.lblService.Text = "Additional Service Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(90, 385);
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
            this.lblColour.Location = new System.Drawing.Point(90, 171);
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
            this.lblCarMake.Location = new System.Drawing.Point(90, 82);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(57, 12);
            this.lblCarMake.TabIndex = 14;
            this.lblCarMake.Text = "Car Make";
            // 
            // pnlPayments
            // 
            this.pnlPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlPayments.Location = new System.Drawing.Point(71, 102);
            this.pnlPayments.Name = "pnlPayments";
            this.pnlPayments.Size = new System.Drawing.Size(949, 486);
            this.pnlPayments.TabIndex = 41;
            this.pnlPayments.Visible = false;
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
            this.lblPayments.Location = new System.Drawing.Point(240, 59);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(301, 37);
            this.lblPayments.TabIndex = 4;
            this.lblPayments.Text = "Receive Payments";
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
            this.pnlReports.Controls.Add(this.btnReport);
            this.pnlReports.Controls.Add(this.listBox1);
            this.pnlReports.Controls.Add(this.lblMakeReports);
            this.pnlReports.Location = new System.Drawing.Point(71, 102);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(949, 486);
            this.pnlReports.TabIndex = 42;
            this.pnlReports.Visible = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(83, 411);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(162, 31);
            this.btnReport.TabIndex = 52;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(377, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 398);
            this.listBox1.TabIndex = 51;
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
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(193, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 31);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblChooseTable
            // 
            this.lblChooseTable.AutoSize = true;
            this.lblChooseTable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseTable.ForeColor = System.Drawing.Color.White;
            this.lblChooseTable.Location = new System.Drawing.Point(45, 70);
            this.lblChooseTable.Name = "lblChooseTable";
            this.lblChooseTable.Size = new System.Drawing.Size(81, 12);
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
            "Name",
            "Description",
            "Date",
            "Time",
            "Venue",
            "Capacity"});
            this.cbxTable.Location = new System.Drawing.Point(46, 94);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(247, 20);
            this.cbxTable.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 23);
            this.dataGridView1.Name = "dataGridView1";
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
            // cbxServiceType
            // 
            this.cbxServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbxServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxServiceType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServiceType.ForeColor = System.Drawing.Color.White;
            this.cbxServiceType.FormattingEnabled = true;
            this.cbxServiceType.Location = new System.Drawing.Point(92, 234);
            this.cbxServiceType.Name = "cbxServiceType";
            this.cbxServiceType.Size = new System.Drawing.Size(161, 20);
            this.cbxServiceType.TabIndex = 43;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.ForeColor = System.Drawing.Color.White;
            this.lblServiceType.Location = new System.Drawing.Point(90, 216);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(77, 12);
            this.lblServiceType.TabIndex = 42;
            this.lblServiceType.Text = "Service Type";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMPG223_Final.Properties.Resources.CMPG_223_background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 639);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlQuotes.ResumeLayout(false);
            this.pnlQuotes.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            this.pnlMaintain.ResumeLayout(false);
            this.pnlMaintain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlQuotes;
        private System.Windows.Forms.TextBox textBox4;
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ListBox listBox1;
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
    }
}