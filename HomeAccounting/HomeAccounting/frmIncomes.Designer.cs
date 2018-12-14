namespace HomeAccounting
{
    partial class frmIncomes
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
            this.gridViewIncomes = new System.Windows.Forms.DataGridView();
            this.IdIncomes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueOfIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpIncomes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicekIncome = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpFiltres = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSortType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValueFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOperand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.btnRemoveFiltr = new System.Windows.Forms.Button();
            this.btnFiltr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncomes)).BeginInit();
            this.grpIncomes.SuspendLayout();
            this.grpFiltres.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewIncomes
            // 
            this.gridViewIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewIncomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIncomes,
            this.ValueOfIncome,
            this.NameIncome,
            this.TypeIncome,
            this.DateIncome});
            this.gridViewIncomes.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridViewIncomes.Location = new System.Drawing.Point(494, 0);
            this.gridViewIncomes.Name = "gridViewIncomes";
            this.gridViewIncomes.Size = new System.Drawing.Size(690, 614);
            this.gridViewIncomes.TabIndex = 0;
            this.gridViewIncomes.DoubleClick += new System.EventHandler(this.gridViewIncomes_DoubleClick);
            // 
            // IdIncomes
            // 
            this.IdIncomes.DataPropertyName = "IdIncomes";
            this.IdIncomes.HeaderText = "IdPrzychodu";
            this.IdIncomes.Name = "IdIncomes";
            this.IdIncomes.ReadOnly = true;
            this.IdIncomes.Visible = false;
            // 
            // ValueOfIncome
            // 
            this.ValueOfIncome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValueOfIncome.DataPropertyName = "ValueOfIncome";
            this.ValueOfIncome.HeaderText = "Kwota Przychodu";
            this.ValueOfIncome.MaxInputLength = 10;
            this.ValueOfIncome.Name = "ValueOfIncome";
            this.ValueOfIncome.ReadOnly = true;
            // 
            // NameIncome
            // 
            this.NameIncome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameIncome.DataPropertyName = "NameIncome";
            this.NameIncome.HeaderText = "Nazwa Przychodu";
            this.NameIncome.MaxInputLength = 200;
            this.NameIncome.Name = "NameIncome";
            this.NameIncome.ReadOnly = true;
            // 
            // TypeIncome
            // 
            this.TypeIncome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeIncome.DataPropertyName = "TypeIncome";
            this.TypeIncome.HeaderText = "Typ Przychodu";
            this.TypeIncome.MaxInputLength = 200;
            this.TypeIncome.Name = "TypeIncome";
            this.TypeIncome.ReadOnly = true;
            // 
            // DateIncome
            // 
            this.DateIncome.DataPropertyName = "DateIncome";
            this.DateIncome.HeaderText = "Data Przychodu";
            this.DateIncome.MaxInputLength = 30;
            this.DateIncome.Name = "DateIncome";
            this.DateIncome.ReadOnly = true;
            // 
            // grpIncomes
            // 
            this.grpIncomes.Controls.Add(this.label2);
            this.grpIncomes.Controls.Add(this.dateTimePicekIncome);
            this.grpIncomes.Controls.Add(this.lblDate);
            this.grpIncomes.Controls.Add(this.grpFiltres);
            this.grpIncomes.Controls.Add(this.btnSave);
            this.grpIncomes.Controls.Add(this.btnDelete);
            this.grpIncomes.Controls.Add(this.lblType);
            this.grpIncomes.Controls.Add(this.lblName);
            this.grpIncomes.Controls.Add(this.lblValue);
            this.grpIncomes.Controls.Add(this.txtType);
            this.grpIncomes.Controls.Add(this.txtName);
            this.grpIncomes.Controls.Add(this.txtValue);
            this.grpIncomes.Controls.Add(this.btnCancel);
            this.grpIncomes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpIncomes.Location = new System.Drawing.Point(0, 0);
            this.grpIncomes.Name = "grpIncomes";
            this.grpIncomes.Size = new System.Drawing.Size(494, 614);
            this.grpIncomes.TabIndex = 1;
            this.grpIncomes.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(125, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operacje na danych";
            // 
            // dateTimePicekIncome
            // 
            this.dateTimePicekIncome.Location = new System.Drawing.Point(160, 132);
            this.dateTimePicekIncome.Name = "dateTimePicekIncome";
            this.dateTimePicekIncome.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicekIncome.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(121, 132);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Data:";
            // 
            // grpFiltres
            // 
            this.grpFiltres.Controls.Add(this.groupBox1);
            this.grpFiltres.Controls.Add(this.txtValueFilter);
            this.grpFiltres.Controls.Add(this.label5);
            this.grpFiltres.Controls.Add(this.cmbOperand);
            this.grpFiltres.Controls.Add(this.label4);
            this.grpFiltres.Controls.Add(this.label3);
            this.grpFiltres.Controls.Add(this.cmbField);
            this.grpFiltres.Controls.Add(this.btnRemoveFiltr);
            this.grpFiltres.Controls.Add(this.btnFiltr);
            this.grpFiltres.Controls.Add(this.label1);
            this.grpFiltres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpFiltres.Location = new System.Drawing.Point(3, 204);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Size = new System.Drawing.Size(488, 407);
            this.grpFiltres.TabIndex = 9;
            this.grpFiltres.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbSortType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 211);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpDateTo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpDateFrom);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 104);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(306, 572);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(116, 23);
            this.btnChart.TabIndex = 13;
            this.btnChart.Text = "Generuj";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Typ:";
            // 
            // cmbSortType
            // 
            this.cmbSortType.FormattingEnabled = true;
            this.cmbSortType.Location = new System.Drawing.Point(148, 48);
            this.cmbSortType.Name = "cmbSortType";
            this.cmbSortType.Size = new System.Drawing.Size(156, 21);
            this.cmbSortType.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(150, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sortowanie";
            // 
            // txtValueFilter
            // 
            this.txtValueFilter.Location = new System.Drawing.Point(157, 106);
            this.txtValueFilter.Name = "txtValueFilter";
            this.txtValueFilter.Size = new System.Drawing.Size(156, 20);
            this.txtValueFilter.TabIndex = 17;
            this.txtValueFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValueFilter_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Operator";
            // 
            // cmbOperand
            // 
            this.cmbOperand.FormattingEnabled = true;
            this.cmbOperand.Location = new System.Drawing.Point(157, 79);
            this.cmbOperand.Name = "cmbOperand";
            this.cmbOperand.Size = new System.Drawing.Size(156, 21);
            this.cmbOperand.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Wartość:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pole: ";
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(157, 52);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(156, 21);
            this.cmbField.TabIndex = 3;
            this.cmbField.SelectedValueChanged += new System.EventHandler(this.cmbField_SelectedValueChanged);
            // 
            // btnRemoveFiltr
            // 
            this.btnRemoveFiltr.Location = new System.Drawing.Point(238, 144);
            this.btnRemoveFiltr.Name = "btnRemoveFiltr";
            this.btnRemoveFiltr.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFiltr.TabIndex = 2;
            this.btnRemoveFiltr.Text = "Czyść";
            this.btnRemoveFiltr.UseVisualStyleBackColor = true;
            this.btnRemoveFiltr.Click += new System.EventHandler(this.btnRemoveFiltr_Click);
            // 
            // btnFiltr
            // 
            this.btnFiltr.Location = new System.Drawing.Point(76, 144);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(75, 23);
            this.btnFiltr.TabIndex = 1;
            this.btnFiltr.Text = "Filtruj";
            this.btnFiltr.UseVisualStyleBackColor = true;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(167, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtry";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(160, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(126, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(28, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Typ:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(111, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nazwa:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(104, 57);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(50, 13);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Wartość:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(160, 106);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(156, 20);
            this.txtType.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(160, 54);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(156, 20);
            this.txtValue.TabIndex = 1;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Czyść";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Data do:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(145, 70);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(156, 20);
            this.dtpDateTo.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Data od:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(145, 44);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(156, 20);
            this.dtpDateFrom.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 20);
            this.button1.TabIndex = 28;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(147, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Wykres";
            // 
            // frmIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 614);
            this.Controls.Add(this.grpIncomes);
            this.Controls.Add(this.gridViewIncomes);
            this.Controls.Add(this.btnChart);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmIncomes";
            this.Text = "Przychody";
            this.Load += new System.EventHandler(this.frmIncomes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIncomes)).EndInit();
            this.grpIncomes.ResumeLayout(false);
            this.grpIncomes.PerformLayout();
            this.grpFiltres.ResumeLayout(false);
            this.grpFiltres.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewIncomes;
        private System.Windows.Forms.GroupBox grpIncomes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnRemoveFiltr;
        private System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIncomes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueOfIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIncome;
        private System.Windows.Forms.DateTimePicker dateTimePicekIncome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOperand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValueFilter;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSortType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}