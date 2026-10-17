using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_10
{
    public partial class FormEquipmentCheckout : Form
    {
        private BindingList<EquipmentBorrow> masterList = new BindingList<EquipmentBorrow>();
        private BindingSource bsBorrows = new BindingSource();

        public FormEquipmentCheckout()
        {
            InitializeComponent();
        }

        private void FormEquipmentCheckout_Load(object sender, EventArgs e)
        {
            errorProviderApp.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            InitDropdownData();
            LoadSampleData();

            bsBorrows.DataSource = masterList;
            dgvBorrows.DataSource = bsBorrows;

            UpdateOverdueAndStatusCount();
            ClearInputForm();
        }

        private void InitDropdownData()
        {
            cboEquipment.Items.AddRange(new string[] {
                "Oscilloscope Tektronix 100MHz",
                "Bộ thực hành Vi điều khiển STM32",
                "Máy phát hàm Siglent",
                "Đồng hồ đo VOM Fluke",
                "Máy hàn trạm Atten 60W",
                "Cảm biến Siêu âm / Hồng ngoại Kit"
            });
            if (cboEquipment.Items.Count > 0) cboEquipment.SelectedIndex = 0;

            string[] statuses = new string[] { "Đang mượn", "Đã trả", "Quá hạn" };
            cboStatus.Items.AddRange(statuses);
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.Add("Tất cả");
            cboFilterStatus.Items.AddRange(statuses);
            cboFilterStatus.SelectedIndex = 0;
        }

        private void LoadSampleData()
        {
            masterList.Add(new EquipmentBorrow("PM001", "24810320314", "Nguyễn Vũ Nhật Minh",
                "Oscilloscope Tektronix 100MHz", 1, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(3), null, "Đang mượn"));

            masterList.Add(new EquipmentBorrow("PM002", "24810320100", "Trần Văn Nam",
                "Đồng hồ đo VOM Fluke", 2, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-3), null, "Quá hạn"));

            masterList.Add(new EquipmentBorrow("PM003", "24810320205", "Lê Thị Hồng",
                "Bộ thực hành Vi điều khiển STM32", 1, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-1), DateTime.Now.AddDays(-1), "Đã trả"));

            CheckOverdueItems();
        }

        private void CheckOverdueItems()
        {
            foreach (var item in masterList)
            {
                item.UpdateOverdueStatus();
            }
        }

        private void UpdateOverdueAndStatusCount()
        {
            CheckOverdueItems();
            int total = masterList.Count;
            int overdueCount = masterList.Count(x => x.Status == "Quá hạn");
            int displayed = bsBorrows.Count;

            lblStatusCount.Text = $"Hiển thị: {displayed} phiếu | Tổng hệ thống: {total} phiếu | Số phiếu quá hạn: {overdueCount}";
        }

        private void dgvBorrows_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBorrows.CurrentRow != null && dgvBorrows.CurrentRow.DataBoundItem is EquipmentBorrow item)
            {
                txtBorrowId.Text = item.BorrowId;
                txtBorrowId.ReadOnly = true;

                txtStudentId.Text = item.StudentId;
                txtStudentName.Text = item.StudentName;
                cboEquipment.SelectedItem = item.EquipmentName;
                nudQuantity.Value = item.Quantity > 0 ? item.Quantity : 1;

                dtpBorrowDate.Value = item.BorrowDate;
                dtpDueDate.Value = item.DueDate;

                if (item.ActualReturnDate.HasValue)
                {
                    chkHasReturned.Checked = true;
                    dtpActualReturnDate.Value = item.ActualReturnDate.Value;
                    dtpActualReturnDate.Enabled = true;
                }
                else
                {
                    chkHasReturned.Checked = false;
                    dtpActualReturnDate.Value = DateTime.Now;
                    dtpActualReturnDate.Enabled = false;
                }

                cboStatus.SelectedItem = item.Status;
                errorProviderApp.Clear();
            }
        }

        private void chkHasReturned_CheckedChanged(object sender, EventArgs e)
        {
            dtpActualReturnDate.Enabled = chkHasReturned.Checked;
            if (chkHasReturned.Checked)
            {
                dtpActualReturnDate.Value = DateTime.Now;
                cboStatus.SelectedItem = "Đã trả";
            }
            else
            {
                if (dtpDueDate.Value.Date < DateTime.Now.Date)
                    cboStatus.SelectedItem = "Quá hạn";
                else
                    cboStatus.SelectedItem = "Đang mượn";
            }
        }

        private bool ValidateForm(bool isNew)
        {
            bool isValid = true;
            errorProviderApp.Clear();

            errorProviderApp.SetIconAlignment(dtpDueDate, ErrorIconAlignment.MiddleLeft);
            errorProviderApp.SetIconPadding(dtpDueDate, 4);

            errorProviderApp.SetIconAlignment(dtpActualReturnDate, ErrorIconAlignment.MiddleLeft);
            errorProviderApp.SetIconPadding(dtpActualReturnDate, 4);

            if (string.IsNullOrWhiteSpace(txtBorrowId.Text))
            {
                errorProviderApp.SetError(txtBorrowId, "Mã phiếu mượn không được để trống!");
                isValid = false;
            }
            else if (isNew && masterList.Any(x => x.BorrowId.Equals(txtBorrowId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProviderApp.SetError(txtBorrowId, "Mã phiếu mượn đã tồn tại trong hệ thống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                errorProviderApp.SetError(txtStudentId, "Mã sinh viên không được để trống!");
                isValid = false;
            }

            if (cboEquipment.SelectedItem == null || string.IsNullOrWhiteSpace(cboEquipment.Text))
            {
                errorProviderApp.SetError(cboEquipment, "Vui lòng chọn thiết bị mượn!");
                isValid = false;
            }

            if (nudQuantity.Value <= 0)
            {
                errorProviderApp.SetError(nudQuantity, "Số lượng mượn phải lớn hơn 0!");
                isValid = false;
            }

            if (dtpDueDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                errorProviderApp.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn!");
                isValid = false;
            }

            if (chkHasReturned.Checked && dtpActualReturnDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                errorProviderApp.SetError(dtpActualReturnDate, "Ngày trả thực tế không được trước ngày mượn!");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(isNew: true)) return;

            DateTime? actualReturn = chkHasReturned.Checked ? (DateTime?)dtpActualReturnDate.Value : null;
            string status = cboStatus.SelectedItem.ToString();

            EquipmentBorrow item = new EquipmentBorrow(
                txtBorrowId.Text.Trim(),
                txtStudentId.Text.Trim(),
                txtStudentName.Text.Trim(),
                cboEquipment.SelectedItem.ToString(),
                (int)nudQuantity.Value,
                dtpBorrowDate.Value,
                dtpDueDate.Value,
                actualReturn,
                status
            );

            item.UpdateOverdueStatus();
            masterList.Add(item);

            FilterBorrows(null, null);
            MessageBox.Show("Thêm phiếu mượn thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBorrows.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm(isNew: false)) return;

            string id = txtBorrowId.Text.Trim();
            EquipmentBorrow item = masterList.FirstOrDefault(x => x.BorrowId == id);
            if (item != null)
            {
                item.StudentId = txtStudentId.Text.Trim();
                item.StudentName = txtStudentName.Text.Trim();
                item.EquipmentName = cboEquipment.SelectedItem.ToString();
                item.Quantity = (int)nudQuantity.Value;
                item.BorrowDate = dtpBorrowDate.Value;
                item.DueDate = dtpDueDate.Value;

                if (chkHasReturned.Checked)
                {
                    item.ActualReturnDate = dtpActualReturnDate.Value;
                    item.Status = "Đã trả";
                }
                else
                {
                    item.ActualReturnDate = null;
                    item.UpdateOverdueStatus();
                }

                bsBorrows.ResetBindings(false);
                UpdateOverdueAndStatusCount();
                MessageBox.Show("Cập nhật phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBorrows.CurrentRow == null || !(dgvBorrows.CurrentRow.DataBoundItem is EquipmentBorrow item))
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa phiếu mượn [{item.BorrowId}] của sinh viên [{item.StudentName}]?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                masterList.Remove(item);
                FilterBorrows(null, null);
                MessageBox.Show("Đã xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputForm();
        }

        private void ClearInputForm()
        {
            txtBorrowId.ReadOnly = false;
            txtBorrowId.Clear();
            txtStudentId.Clear();
            txtStudentName.Clear();

            if (cboEquipment.Items.Count > 0) cboEquipment.SelectedIndex = 0;
            nudQuantity.Value = 1;

            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(7);

            chkHasReturned.Checked = false;
            dtpActualReturnDate.Value = DateTime.Now;
            dtpActualReturnDate.Enabled = false;

            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;

            dgvBorrows.ClearSelection();
            errorProviderApp.Clear();
        }

        private void FilterBorrows(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string status = cboFilterStatus.SelectedItem != null ? cboFilterStatus.SelectedItem.ToString() : "Tất cả";

            CheckOverdueItems();

            var filtered = masterList.Where(x =>
                (string.IsNullOrEmpty(keyword) || x.StudentId.ToLower().Contains(keyword) || x.EquipmentName.ToLower().Contains(keyword)) &&
                (status == "Tất cả" || x.Status == status)
            ).ToList();

            bsBorrows.DataSource = new BindingList<EquipmentBorrow>(filtered);
            UpdateOverdueAndStatusCount();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterStatus.SelectedIndex = 0;
            bsBorrows.DataSource = masterList;
            UpdateOverdueAndStatusCount();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (bsBorrows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu phiếu mượn để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV File (*.csv)|*.csv",
                FileName = $"MuonTraThietBi_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine("Mã Phiếu,Mã Sinh Viên,Họ Tên,Thiết Bị,Số Lượng,Ngày Mượn,Hạn Trả,Ngày Trả Thực Tế,Trạng Thái");

                        foreach (EquipmentBorrow item in bsBorrows)
                        {
                            string actualDateStr = item.ActualReturnDate.HasValue ? item.ActualReturnDate.Value.ToString("dd/MM/yyyy") : "";
                            string line = $"\"{item.BorrowId}\",\"{item.StudentId}\",\"{item.StudentName}\",\"{item.EquipmentName}\",\"{item.Quantity}\",\"{item.BorrowDate:dd/MM/yyyy}\",\"{item.DueDate:dd/MM/yyyy}\",\"{actualDateStr}\",\"{item.Status}\"";
                            sw.WriteLine(line);
                        }
                    }

                    MessageBox.Show("Xuất danh sách phiếu mượn ra CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xuất file CSV: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}