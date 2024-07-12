using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class News
    {
        public int RN { get; set; }
        [Key]
        public int ID { get; set; }

        [MaxLength(255)]
        public string TIEU_DE { get; set; }

        public string MO_TA { get; set; }

        public int LUOT_XEM { get; set; }

        public DateTime NGAY_TAO { get; set; }

        [MaxLength(255)]
        public string NGUOI_TAO { get; set; }

        public string NOI_DUNG { get; set; }

        [MaxLength(255)]
        public string TRICH_DAN { get; set; }

        public bool DA_XOA { get; set; }

        public int ID_HINH_ANH { get; set; }

        [MaxLength(255)]
        public string HINHANH { get; set; }

        public bool IS_TIN_NOI_BAT { get; set; }

        public int LOAI { get; set; }

        [MaxLength(255)]
        public string HASHTAG { get; set; }

        public int ID_QUANHUYEN { get; set; }
    }
}
