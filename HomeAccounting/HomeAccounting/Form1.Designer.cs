namespace HomeAccounting
{
    partial class FrmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxMenu = new System.Windows.Forms.GroupBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnIncomes = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
            this.grpBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(102, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(245, 45);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Wyjdź";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxMenu
            // 
            this.grpBoxMenu.Controls.Add(this.btnCharts);
            this.grpBoxMenu.Controls.Add(this.btnExit);
            this.grpBoxMenu.Controls.Add(this.btnPayment);
            this.grpBoxMenu.Controls.Add(this.btnIncomes);
            this.grpBoxMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxMenu.Location = new System.Drawing.Point(0, 0);
            this.grpBoxMenu.Name = "grpBoxMenu";
            this.grpBoxMenu.Size = new System.Drawing.Size(447, 437);
            this.grpBoxMenu.TabIndex = 3;
            this.grpBoxMenu.TabStop = false;
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPayment.Location = new System.Drawing.Point(102, 143);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(245, 45);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Wydatki";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnIncomes
            // 
            this.btnIncomes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncomes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIncomes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncomes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIncomes.ForeColor = System.Drawing.Color.Lavender;
            this.btnIncomes.Location = new System.Drawing.Point(102, 92);
            this.btnIncomes.Name = "btnIncomes";
            this.btnIncomes.Size = new System.Drawing.Size(245, 45);
            this.btnIncomes.TabIndex = 0;
            this.btnIncomes.Text = "Przychody";
            this.btnIncomes.UseVisualStyleBackColor = false;
            this.btnIncomes.Click += new System.EventHandler(this.btnIncomes_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCharts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCharts.Location = new System.Drawing.Point(101, 196);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(245, 45);
            this.btnCharts.TabIndex = 3;
            this.btnCharts.Text = "Wykres";
            this.btnCharts.UseVisualStyleBackColor = true;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(447, 437);
            this.Controls.Add(this.grpBoxMenu);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "FrmMain";
            this.Text = "Domowa księgowość";
            this.grpBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIncomes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.GroupBox grpBoxMenu;
        private System.Windows.Forms.Button btnCharts;
    }
}

