namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_10
{
    partial class FormEquipmentCheckout
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
            this.components = new System.ComponentModel.Container();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.tblInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblBorrowId = new System.Windows.Forms.Label();
            this.txtBorrowId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.chkHasReturned = new System.Windows.Forms.CheckBox();
            this.dtpActualReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.dgvBorrows = new System.Windows.Forms.DataGridView();
            this.colBorrowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActualReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStripApp = new System.Windows.Forms.StatusStrip();
            this.lblStatusCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStudentInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);

            this.grpInput.SuspendLayout();
            this.tblInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).BeginInit();
            this.statusStripApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();

            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.tblInput);
            this.grpInput.Controls.Add(this.pnlButtons);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInput.Location = new System.Drawing.Point(10, 10);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(1164, 215);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông Tin Phiếu Mượn Thiết Bị";

            // 
            // tblInput
            // 
            this.tblInput.ColumnCount = 6;
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInput.Controls.Add(this.lblBorrowId, 0, 0);
            this.tblInput.Controls.Add(this.txtBorrowId, 1, 0);
            this.tblInput.Controls.Add(this.lblStudentId, 2, 0);
            this.tblInput.Controls.Add(this.txtStudentId, 3, 0);
            this.tblInput.Controls.Add(this.lblStudentName, 4, 0);
            this.tblInput.Controls.Add(this.txtStudentName, 5, 0);
            this.tblInput.Controls.Add(this.lblEquipment, 0, 1);
            this.tblInput.Controls.Add(this.cboEquipment, 1, 1);
            this.tblInput.Controls.Add(this.lblQuantity, 2, 1);
            this.tblInput.Controls.Add(this.nudQuantity, 3, 1);
            this.tblInput.Controls.Add(this.lblBorrowDate, 4, 1);
            this.tblInput.Controls.Add(this.dtpBorrowDate, 5, 1);
            this.tblInput.Controls.Add(this.lblDueDate, 0, 2);
            this.tblInput.Controls.Add(this.dtpDueDate, 1, 2);
            this.tblInput.Controls.Add(this.chkHasReturned, 2, 2);
            this.tblInput.Controls.Add(this.dtpActualReturnDate, 3, 2);
            this.tblInput.Controls.Add(this.lblStatus, 4, 2);
            this.tblInput.Controls.Add(this.cboStatus, 5, 2);
            this.tblInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.tblInput.Location = new System.Drawing.Point(3, 19);
            this.tblInput.Name = "tblInput";
            this.tblInput.RowCount = 3;
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblInput.Size = new System.Drawing.Size(1158, 115);
            this.tblInput.TabIndex = 0;

            // Controls inside tblInput
            this.lblBorrowId.Text = "Mã phiếu (*):"; this.lblBorrowId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBorrowId.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblStudentId.Text = "Mã sinh viên (*):"; this.lblStudentId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStudentId.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblStudentName.Text = "Họ tên SV:"; this.lblStudentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.lblEquipment.Text = "Thiết bị (*):"; this.lblEquipment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipment.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.Text = "Số lượng (*):"; this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudQuantity.Minimum = 1; this.nudQuantity.Maximum = 100;
            this.nudQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblBorrowDate.Text = "Ngày mượn:"; this.lblBorrowDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.lblDueDate.Text = "Hạn trả (*):"; this.lblDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.chkHasReturned.Text = "Đã trả thực tế:"; this.chkHasReturned.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHasReturned.CheckedChanged += new System.EventHandler(this.chkHasReturned_CheckedChanged);
            this.dtpActualReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpActualReturnDate.Enabled = false;
            this.dtpActualReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblStatus.Text = "Trạng thái:"; this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnExportCsv);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlButtons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.pnlButtons.Location = new System.Drawing.Point(3, 160);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlButtons.Size = new System.Drawing.Size(1158, 52);
            this.pnlButtons.TabIndex = 1;

            this.btnAdd.Text = "Thêm phiếu"; this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen; this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Cập nhật"; this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue; this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Xóa"; this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.BackColor = System.Drawing.Color.Crimson; this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Làm mới"; this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnExportCsv.Text = "Xuất CSV"; this.btnExportCsv.Size = new System.Drawing.Size(100, 35);
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);

            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.lblSearch);
            this.grpFilter.Controls.Add(this.txtSearch);
            this.grpFilter.Controls.Add(this.lblFilterStatus);
            this.grpFilter.Controls.Add(this.cboFilterStatus);
            this.grpFilter.Controls.Add(this.btnResetFilter);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpFilter.Location = new System.Drawing.Point(10, 225);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1164, 60);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Tìm Kiếm & Bố Lọc Tra Cứu";

            this.lblSearch.Text = "Từ khóa (Mã SV/Thiết bị):"; this.lblSearch.Location = new System.Drawing.Point(15, 25); this.lblSearch.AutoSize = true; this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.txtSearch.Location = new System.Drawing.Point(175, 22); this.txtSearch.Size = new System.Drawing.Size(200, 23); this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.txtSearch.TextChanged += new System.EventHandler(this.FilterBorrows);

            this.lblFilterStatus.Text = "Trạng thái:"; this.lblFilterStatus.Location = new System.Drawing.Point(410, 25); this.lblFilterStatus.AutoSize = true; this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.cboFilterStatus.Location = new System.Drawing.Point(480, 22); this.cboFilterStatus.Size = new System.Drawing.Size(140, 23); this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.FilterBorrows);

            this.btnResetFilter.Text = "Xóa lọc"; this.btnResetFilter.Location = new System.Drawing.Point(640, 21); this.btnResetFilter.Size = new System.Drawing.Size(85, 26); this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            // 
            // dgvBorrows
            // 
            this.dgvBorrows.AllowUserToAddRows = false;
            this.dgvBorrows.AllowUserToDeleteRows = false;
            this.dgvBorrows.AutoGenerateColumns = false;
            this.dgvBorrows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colBorrowId,
                this.colStudentId,
                this.colStudentName,
                this.colEquipmentName,
                this.colQuantity,
                this.colBorrowDate,
                this.colDueDate,
                this.colActualReturnDate,
                this.colStatus
            });
            this.dgvBorrows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrows.Location = new System.Drawing.Point(10, 285);
            this.dgvBorrows.MultiSelect = false;
            this.dgvBorrows.Name = "dgvBorrows";
            this.dgvBorrows.ReadOnly = true;
            this.dgvBorrows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrows.Size = new System.Drawing.Size(1164, 340);
            this.dgvBorrows.TabIndex = 2;
            this.dgvBorrows.SelectionChanged += new System.EventHandler(this.dgvBorrows_SelectionChanged);

            // 
            // Columns
            // 
            this.colBorrowId.DataPropertyName = "BorrowId"; this.colBorrowId.HeaderText = "Mã Phiếu";
            this.colStudentId.DataPropertyName = "StudentId"; this.colStudentId.HeaderText = "Mã Sinh Viên";
            this.colStudentName.DataPropertyName = "StudentName"; this.colStudentName.HeaderText = "Họ Tên SV";
            this.colEquipmentName.DataPropertyName = "EquipmentName"; this.colEquipmentName.HeaderText = "Tên Thiết Bị";
            this.colQuantity.DataPropertyName = "Quantity"; this.colQuantity.HeaderText = "Số Lượng";
            this.colBorrowDate.DataPropertyName = "BorrowDate"; this.colBorrowDate.DefaultCellStyle.Format = "dd/MM/yyyy"; this.colBorrowDate.HeaderText = "Ngày Mượn";
            this.colDueDate.DataPropertyName = "DueDate"; this.colDueDate.DefaultCellStyle.Format = "dd/MM/yyyy"; this.colDueDate.HeaderText = "Hạn Trả";
            this.colActualReturnDate.DataPropertyName = "ActualReturnDate"; this.colActualReturnDate.DefaultCellStyle.Format = "dd/MM/yyyy"; this.colActualReturnDate.HeaderText = "Ngày Trả Thực Tế";
            this.colStatus.DataPropertyName = "Status"; this.colStatus.HeaderText = "Trạng Thái";

            // 
            // statusStripApp
            // 
            this.statusStripApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatusCount,
                this.lblStudentInfo
            });
            this.statusStripApp.Location = new System.Drawing.Point(10, 625);
            this.statusStripApp.Name = "statusStripApp";
            this.statusStripApp.Size = new System.Drawing.Size(1164, 22);
            this.statusStripApp.TabIndex = 3;

            this.lblStatusCount.Name = "lblStatusCount";
            this.lblStatusCount.Size = new System.Drawing.Size(600, 17);
            this.lblStatusCount.Spring = true;
            this.lblStatusCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(350, 17);
            this.lblStudentInfo.Text = "Sinh viên: Nguyễn Vũ Nhật Minh - 24810320314";
            this.lblStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // FormEquipmentCheckout
            // 
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.dgvBorrows);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.statusStripApp);
            this.Padding = new System.Windows.Forms.Padding(10);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormEquipmentCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Equipment Checkout - NGUYỄN VŨ NHẬT MINH - D19QTANM1";
            this.Load += new System.EventHandler(this.FormEquipmentCheckout_Load);

            this.grpInput.ResumeLayout(false);
            this.tblInput.ResumeLayout(false);
            this.tblInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).EndInit();
            this.statusStripApp.ResumeLayout(false);
            this.statusStripApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel tblInput;
        private System.Windows.Forms.Label lblBorrowId;
        private System.Windows.Forms.TextBox txtBorrowId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.CheckBox chkHasReturned;
        private System.Windows.Forms.DateTimePicker dtpActualReturnDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;

        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExportCsv;

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Button btnResetFilter;

        private System.Windows.Forms.DataGridView dgvBorrows;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActualReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        private System.Windows.Forms.StatusStrip statusStripApp;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
        private System.Windows.Forms.ToolStripStatusLabel lblStudentInfo;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}