namespace Admin_NSPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [Key]
        [StringLength(50)]
        [Display(Name ="Mã đơn hàng")]
        public string MaDonHang { get; set; }
        [Display(Name  = "Ngày lập")]
        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }
        [Display(Name = "Thông tin KH")]
        [StringLength(50)]
        public string MaTaiKhoan { get; set; }
        [Display(Name = "Thanh toán")]
        [StringLength(50)]
        public string ThanhToan { get; set; }
        [Display(Name = "Giao hàng")]
        [StringLength(50)]
        public string GiaoHang { get; set; }
        [Display(Name = "Tổng tiền")]
        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }
        [Display(Name = "Thông tin KH")]
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
