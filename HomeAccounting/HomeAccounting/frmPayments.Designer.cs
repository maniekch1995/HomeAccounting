namespace HomeAccounting
{
    partial class frmPayments
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
            this.gridViewPayments = new System.Windows.Forms.DataGridView();
            this.IdPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tmptmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValuePayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpFiltres = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnChart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSortType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValueFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOperand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.btnRemoveFiltr = new System.Windows.Forms.Button();
            this.btnFiltr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamePayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickPayments = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPayments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpFiltres.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewPayments
            // 
            this.gridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPayment,
            this.Tmptmp,
            this.ValuePayment,
            this.PlaceName,
            this.ShopName,
            this.TypeName,
            this.DatePayment});
            this.gridViewPayments.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridViewPayments.Location = new System.Drawing.Point(593, 0);
            this.gridViewPayments.Name = "gridViewPayments";
            this.gridViewPayments.Size = new System.Drawing.Size(597, 622);
            this.gridViewPayments.TabIndex = 0;
            this.gridViewPayments.DoubleClick += new System.EventHandler(this.gridViewPayments_DoubleClick);
            // 
            // IdPayment
            // 
            this.IdPayment.DataPropertyName = "IdPayment";
            this.IdPayment.HeaderText = "IdPłatności";
            this.IdPayment.Name = "IdPayment";
            this.IdPayment.Visible = false;
            // 
            // Tmptmp
            // 
            this.Tmptmp.DataPropertyName = "Tmstmp";
            this.Tmptmp.HeaderText = "ZnacznikCzasowy";
            this.Tmptmp.Name = "Tmptmp";
            this.Tmptmp.Visible = false;
            // 
            // ValuePayment
            // 
            this.ValuePayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ValuePayment.DataPropertyName = "ValuePayment";
            this.ValuePayment.HeaderText = "Wartość Płatności";
            this.ValuePayment.MaxInputLength = 12;
            this.ValuePayment.Name = "ValuePayment";
            this.ValuePayment.ReadOnly = true;
            this.ValuePayment.Width = 110;
            // 
            // PlaceName
            // 
            this.PlaceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlaceName.DataPropertyName = "PlaceName";
            this.PlaceName.HeaderText = "Miejsce Płatności";
            this.PlaceName.MaxInputLength = 200;
            this.PlaceName.Name = "PlaceName";
            this.PlaceName.ReadOnly = true;
            this.PlaceName.Width = 106;
            // 
            // ShopName
            // 
            this.ShopName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ShopName.DataPropertyName = "ShopName";
            this.ShopName.HeaderText = "Nazwa ";
            this.ShopName.MaxInputLength = 200;
            this.ShopName.Name = "ShopName";
            this.ShopName.ReadOnly = true;
            this.ShopName.Width = 68;
            // 
            // TypeName
            // 
            this.TypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "Typ Płatności";
            this.TypeName.MaxInputLength = 200;
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            this.TypeName.Width = 90;
            // 
            // DatePayment
            // 
            this.DatePayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DatePayment.DataPropertyName = "DatePayment";
            this.DatePayment.HeaderText = "Data Płatności";
            this.DatePayment.MaxInputLength = 200;
            this.DatePayment.Name = "DatePayment";
            this.DatePayment.ReadOnly = true;
            this.DatePayment.Width = 95;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpFiltres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNamePayment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickPayments);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblPlace);
            this.groupBox1.Controls.Add(this.lblValue);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtPlace);
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 622);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // grpFiltres
            // 
            this.grpFiltres.Controls.Add(this.groupBox2);
            this.grpFiltres.Controls.Add(this.txtValueFilter);
            this.grpFiltres.Controls.Add(this.label5);
            this.grpFiltres.Controls.Add(this.cmbOperand);
            this.grpFiltres.Controls.Add(this.label4);
            this.grpFiltres.Controls.Add(this.label8);
            this.grpFiltres.Controls.Add(this.cmbField);
            this.grpFiltres.Controls.Add(this.btnRemoveFiltr);
            this.grpFiltres.Controls.Add(this.btnFiltr);
            this.grpFiltres.Controls.Add(this.label3);
            this.grpFiltres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpFiltres.Location = new System.Drawing.Point(3, 240);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Size = new System.Drawing.Size(587, 379);
            this.grpFiltres.TabIndex = 27;
            this.grpFiltres.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbSortType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 203);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpDateTo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dtpDateFrom);
            this.groupBox3.Controls.Add(this.btnChart);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 113);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Data od:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(217, 45);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(156, 20);
            this.dtpDateFrom.TabIndex = 24;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(394, 45);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(116, 20);
            this.btnChart.TabIndex = 13;
            this.btnChart.Text = "Generuj";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(219, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Wykres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Typ:";
            // 
            // cmbSortType
            // 
            this.cmbSortType.FormattingEnabled = true;
            this.cmbSortType.Location = new System.Drawing.Point(220, 60);
            this.cmbSortType.Name = "cmbSortType";
            this.cmbSortType.Size = new System.Drawing.Size(156, 21);
            this.cmbSortType.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(222, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sortowanie";
            // 
            // txtValueFilter
            // 
            this.txtValueFilter.Location = new System.Drawing.Point(223, 106);
            this.txtValueFilter.Name = "txtValueFilter";
            this.txtValueFilter.Size = new System.Drawing.Size(156, 20);
            this.txtValueFilter.TabIndex = 17;
            this.txtValueFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValueFilter_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Operator";
            // 
            // cmbOperand
            // 
            this.cmbOperand.FormattingEnabled = true;
            this.cmbOperand.Location = new System.Drawing.Point(223, 79);
            this.cmbOperand.Name = "cmbOperand";
            this.cmbOperand.Size = new System.Drawing.Size(156, 21);
            this.cmbOperand.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Wartość:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pole: ";
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(223, 52);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(156, 21);
            this.cmbField.TabIndex = 3;
            this.cmbField.SelectedIndexChanged += new System.EventHandler(this.cmbField_SelectedIndexChanged);
            // 
            // btnRemoveFiltr
            // 
            this.btnRemoveFiltr.Location = new System.Drawing.Point(304, 144);
            this.btnRemoveFiltr.Name = "btnRemoveFiltr";
            this.btnRemoveFiltr.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFiltr.TabIndex = 2;
            this.btnRemoveFiltr.Text = "Czyść";
            this.btnRemoveFiltr.UseVisualStyleBackColor = true;
            this.btnRemoveFiltr.Click += new System.EventHandler(this.btnRemoveFiltr_Click);
            // 
            // btnFiltr
            // 
            this.btnFiltr.Location = new System.Drawing.Point(142, 144);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(75, 23);
            this.btnFiltr.TabIndex = 1;
            this.btnFiltr.Text = "Filtruj";
            this.btnFiltr.UseVisualStyleBackColor = true;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(233, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filtry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nazwa:";
            // 
            // txtNamePayment
            // 
            this.txtNamePayment.Location = new System.Drawing.Point(226, 106);
            this.txtNamePayment.Name = "txtNamePayment";
            this.txtNamePayment.Size = new System.Drawing.Size(156, 20);
            this.txtNamePayment.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(191, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Operacje na danych";
            // 
            // dateTimePickPayments
            // 
            this.dateTimePickPayments.Location = new System.Drawing.Point(226, 158);
            this.dateTimePickPayments.Name = "dateTimePickPayments";
            this.dateTimePickPayments.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickPayments.TabIndex = 24;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(187, 158);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Data:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(226, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(192, 135);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(28, 13);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Typ:";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(177, 83);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(46, 13);
            this.lblPlace.TabIndex = 19;
            this.lblPlace.Text = "Miejsce:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(170, 57);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(50, 13);
            this.lblValue.TabIndex = 18;
            this.lblValue.Text = "Wartość:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(226, 132);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(156, 20);
            this.txtType.TabIndex = 17;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(226, 80);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(156, 20);
            this.txtPlace.TabIndex = 15;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(226, 54);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(156, 20);
            this.txtValue.TabIndex = 14;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(307, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Czyść";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Data do:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(217, 71);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(156, 20);
            this.dtpDateTo.TabIndex = 26;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1190, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridViewPayments);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmPayments";
            this.Text = "Wydatki";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPayments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFiltres.ResumeLayout(false);
            this.grpFiltres.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewPayments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickPayments;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tmptmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValuePayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamePayment;
        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSortType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValueFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOperand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Button btnRemoveFiltr;
        private System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
    }
}