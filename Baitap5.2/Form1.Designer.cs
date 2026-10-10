namespace Baitap5._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.GroupBox groupBoxTotals;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtFinal;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboCategory = new ComboBox();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            lblAvailable = new Label();
            lblSelected = new Label();
            groupBoxTotals = new GroupBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            lblDiscount = new Label();
            nudDiscount = new NumericUpDown();
            lblFinal = new Label();
            txtFinal = new TextBox();
            groupBoxTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).BeginInit();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(456, 7);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(250, 28);
            cboCategory.TabIndex = 0;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(346, 45);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.SelectionMode = SelectionMode.MultiExtended;
            lstAvailableServices.Size = new Size(360, 244);
            lstAvailableServices.TabIndex = 1;
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(821, 45);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.SelectionMode = SelectionMode.MultiExtended;
            lstSelectedServices.Size = new Size(359, 244);
            lstSelectedServices.TabIndex = 2;
            lstSelectedServices.DoubleClick += lstSelectedServices_DoubleClick;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(715, 90);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(90, 30);
            btnSelect.TabIndex = 3;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(715, 153);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(90, 30);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(715, 214);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(90, 30);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(346, 15);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(104, 20);
            lblAvailable.TabIndex = 6;
            lblAvailable.Text = "Dịch vụ sẵn có";
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(821, 15);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(115, 20);
            lblSelected.TabIndex = 7;
            lblSelected.Text = "Dịch vụ đã chọn";
            // 
            // groupBoxTotals
            // 
            groupBoxTotals.Controls.Add(lblTotal);
            groupBoxTotals.Controls.Add(txtTotal);
            groupBoxTotals.Controls.Add(lblDiscount);
            groupBoxTotals.Controls.Add(nudDiscount);
            groupBoxTotals.Controls.Add(lblFinal);
            groupBoxTotals.Controls.Add(txtFinal);
            groupBoxTotals.Location = new Point(12, 295);
            groupBoxTotals.Name = "groupBoxTotals";
            groupBoxTotals.Size = new Size(1322, 135);
            groupBoxTotals.TabIndex = 8;
            groupBoxTotals.TabStop = false;
            groupBoxTotals.Text = "Thanh toán";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(16, 29);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(156, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Tổng tiền (chưa giảm)";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(229, 22);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(200, 27);
            txtTotal.TabIndex = 1;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(16, 60);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(137, 20);
            lblDiscount.TabIndex = 2;
            lblDiscount.Text = "Tỷ lệ chiết khấu (%)";
            // 
            // nudDiscount
            // 
            nudDiscount.Location = new Point(229, 55);
            nudDiscount.Name = "nudDiscount";
            nudDiscount.Size = new Size(80, 27);
            nudDiscount.TabIndex = 3;
            nudDiscount.ValueChanged += nudDiscount_ValueChanged;
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(16, 93);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(186, 20);
            lblFinal.TabIndex = 4;
            lblFinal.Text = "Thành tiền phải thanh toán";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(229, 86);
            txtFinal.Name = "txtFinal";
            txtFinal.ReadOnly = true;
            txtFinal.Size = new Size(200, 27);
            txtFinal.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 450);
            Controls.Add(groupBoxTotals);
            Controls.Add(lblSelected);
            Controls.Add(lblAvailable);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lstSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(cboCategory);
            Name = "Form1";
            Text = "BÀI 5.2 - Bảng tính tiền";
            groupBoxTotals.ResumeLayout(false);
            groupBoxTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
