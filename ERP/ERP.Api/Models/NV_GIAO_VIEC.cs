//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NV_GIAO_VIEC
    {
        public int ID { get; set; }
        public string TIEU_DE_CONG_VIEC { get; set; }
        public System.DateTime NGAY_GIAO_VIEC { get; set; }
        public string NOI_DUNG_CONG_VIEC { get; set; }
        public string THOI_GIAN_HOAN_THANH { get; set; }
        public string NGUOI_GIAO_VIEC { get; set; }
        public string NHAN_VIEN_THUC_HIEN { get; set; }
        public bool HUY_CONG_VIEC { get; set; }
        public string TRANG_THAI { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN { get; set; }
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN1 { get; set; }
    }
}