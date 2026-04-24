namespace lab14
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudRoom = new System.Windows.Forms.NumericUpDown();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilterSort = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoom)).BeginInit();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1040, 118);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(29, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Гостьова книга готелю";
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.btnAdd);
            this.pnlInput.Controls.Add(this.nudRoom);
            this.pnlInput.Controls.Add(this.dtpDeparture);
            this.pnlInput.Controls.Add(this.dtpArrival);
            this.pnlInput.Controls.Add(this.txtFullName);
            this.pnlInput.Controls.Add(this.lblRoom);
            this.pnlInput.Controls.Add(this.lblDeparture);
            this.pnlInput.Controls.Add(this.lblArrival);
            this.pnlInput.Controls.Add(this.lblFullName);
            this.pnlInput.Controls.Add(this.lblInputTitle);
            this.pnlInput.Location = new System.Drawing.Point(32, 146);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(330, 406);
            this.pnlInput.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(28, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(274, 44);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Додати запис";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudRoom
            // 
            this.nudRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudRoom.Location = new System.Drawing.Point(28, 276);
            this.nudRoom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudRoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRoom.Name = "nudRoom";
            this.nudRoom.Size = new System.Drawing.Size(274, 25);
            this.nudRoom.TabIndex = 8;
            this.nudRoom.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDeparture.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparture.Location = new System.Drawing.Point(28, 215);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(274, 25);
            this.dtpDeparture.TabIndex = 7;
            // 
            // dtpArrival
            // 
            this.dtpArrival.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpArrival.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrival.Location = new System.Drawing.Point(28, 154);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(274, 25);
            this.dtpArrival.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(28, 93);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(274, 25);
            this.txtFullName.TabIndex = 5;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.lblRoom.Location = new System.Drawing.Point(25, 253);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(152, 17);
            this.lblRoom.TabIndex = 4;
            this.lblRoom.Text = "Який номер відвідував";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDeparture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.lblDeparture.Location = new System.Drawing.Point(25, 192);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(140, 17);
            this.lblDeparture.TabIndex = 3;
            this.lblDeparture.Text = "Коли покинув готель";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblArrival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.lblArrival.Location = new System.Drawing.Point(25, 131);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(89, 17);
            this.lblArrival.TabIndex = 2;
            this.lblArrival.Text = "Коли прибув";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.lblFullName.Location = new System.Drawing.Point(25, 70);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(30, 17);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "ПІБ";
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblInputTitle.Location = new System.Drawing.Point(23, 23);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(171, 25);
            this.lblInputTitle.TabIndex = 0;
            this.lblInputTitle.Text = "Новий відвідувач";
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnLoadJson);
            this.pnlActions.Controls.Add(this.btnSaveJson);
            this.pnlActions.Controls.Add(this.btnLoadXml);
            this.pnlActions.Controls.Add(this.btnSaveXml);
            this.pnlActions.Controls.Add(this.btnClear);
            this.pnlActions.Controls.Add(this.btnFilterSort);
            this.pnlActions.Controls.Add(this.btnShowAll);
            this.pnlActions.Controls.Add(this.btnDemo);
            this.pnlActions.Location = new System.Drawing.Point(386, 146);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(622, 140);
            this.pnlActions.TabIndex = 2;
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.BackColor = System.Drawing.Color.White;
            this.btnLoadJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadJson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnLoadJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadJson.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLoadJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnLoadJson.Location = new System.Drawing.Point(428, 79);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(128, 38);
            this.btnLoadJson.TabIndex = 7;
            this.btnLoadJson.Text = "Завантажити JSON";
            this.btnLoadJson.UseVisualStyleBackColor = false;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSaveJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveJson.FlatAppearance.BorderSize = 0;
            this.btnSaveJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveJson.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveJson.ForeColor = System.Drawing.Color.White;
            this.btnSaveJson.Location = new System.Drawing.Point(287, 79);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(125, 38);
            this.btnSaveJson.TabIndex = 6;
            this.btnSaveJson.Text = "Зберегти JSON";
            this.btnSaveJson.UseVisualStyleBackColor = false;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.BackColor = System.Drawing.Color.White;
            this.btnLoadXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnLoadXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadXml.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLoadXml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnLoadXml.Location = new System.Drawing.Point(143, 79);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(128, 38);
            this.btnLoadXml.TabIndex = 5;
            this.btnLoadXml.Text = "Завантажити XML";
            this.btnLoadXml.UseVisualStyleBackColor = false;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.btnSaveXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveXml.FlatAppearance.BorderSize = 0;
            this.btnSaveXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveXml.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveXml.ForeColor = System.Drawing.Color.White;
            this.btnSaveXml.Location = new System.Drawing.Point(26, 79);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(101, 38);
            this.btnSaveXml.TabIndex = 4;
            this.btnSaveXml.Text = "Серiалiзацiя";
            this.btnSaveXml.UseVisualStyleBackColor = false;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnClear.Location = new System.Drawing.Point(477, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilterSort
            // 
            this.btnFilterSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFilterSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterSort.FlatAppearance.BorderSize = 0;
            this.btnFilterSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterSort.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterSort.ForeColor = System.Drawing.Color.White;
            this.btnFilterSort.Location = new System.Drawing.Point(260, 24);
            this.btnFilterSort.Name = "btnFilterSort";
            this.btnFilterSort.Size = new System.Drawing.Size(201, 38);
            this.btnFilterSort.TabIndex = 2;
            this.btnFilterSort.Text = "Більше години + сортування";
            this.btnFilterSort.UseVisualStyleBackColor = false;
            this.btnFilterSort.Click += new System.EventHandler(this.btnFilterSort_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.White;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnShowAll.Location = new System.Drawing.Point(143, 24);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(101, 38);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Усі записи";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.Color.White;
            this.btnDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDemo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnDemo.Location = new System.Drawing.Point(26, 24);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(101, 38);
            this.btnDemo.TabIndex = 0;
            this.btnDemo.Text = "Демо-дані";
            this.btnDemo.UseVisualStyleBackColor = false;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToAddRows = false;
            this.dgvGuests.AllowUserToDeleteRows = false;
            this.dgvGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuests.BackgroundColor = System.Drawing.Color.White;
            this.dgvGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGuests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGuests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuests.ColumnHeadersHeight = 38;
            this.dgvGuests.EnableHeadersVisualStyles = false;
            this.dgvGuests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvGuests.Location = new System.Drawing.Point(386, 304);
            this.dgvGuests.MultiSelect = false;
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.ReadOnly = true;
            this.dgvGuests.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.dgvGuests.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGuests.RowTemplate.Height = 34;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(622, 248);
            this.dgvGuests.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblStatus.Location = new System.Drawing.Point(32, 575);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblStatus.Size = new System.Drawing.Size(976, 40);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Готово";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvGuests);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гостьова книга готелю";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoom)).EndInit();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudRoom;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.Button btnSaveJson;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFilterSort;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Label lblStatus;
    }
}
