using System;

namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_4_10
{
    public class EquipmentBorrow
    {
        public string BorrowId { get; set; }          // Mã phiếu
        public string StudentId { get; set; }         // Mã sinh viên
        public string StudentName { get; set; }       // Họ tên sinh viên
        public string EquipmentName { get; set; }     // Thiết bị
        public int Quantity { get; set; }             // Số lượng
        public DateTime BorrowDate { get; set; }       // Ngày mượn
        public DateTime DueDate { get; set; }          // Hạn trả
        public DateTime? ActualReturnDate { get; set; }// Ngày trả thực tế
        public string Status { get; set; }            // Đang mượn, Đã trả, Quá hạn

        public EquipmentBorrow() { }

        public EquipmentBorrow(string borrowId, string studentId, string studentName,
                               string equipmentName, int quantity, DateTime borrowDate,
                               DateTime dueDate, DateTime? actualReturnDate, string status)
        {
            BorrowId = borrowId;
            StudentId = studentId;
            StudentName = studentName;
            EquipmentName = equipmentName;
            Quantity = quantity;
            BorrowDate = borrowDate;
            DueDate = dueDate;
            ActualReturnDate = actualReturnDate;
            Status = status;
        }

        public void UpdateOverdueStatus()
        {
            if (Status != "Đã trả")
            {
                if (DueDate.Date < DateTime.Now.Date)
                {
                    Status = "Quá hạn";
                }
                else
                {
                    Status = "Đang mượn";
                }
            }
        }
    }
}