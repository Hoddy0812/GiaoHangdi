﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiaoHangne.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GiaoHangEntities : DbContext
    {
        public GiaoHangEntities()
            : base("name=GiaoHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CapNhatDanhSachNhanVien> CapNhatDanhSachNhanViens { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LapDanhSachXe> LapDanhSachXes { get; set; }
        public virtual DbSet<LichSuDonHang> LichSuDonHangs { get; set; }
        public virtual DbSet<MaUuDai> MaUuDais { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThongKeDoanhThu> ThongKeDoanhThus { get; set; }
        public virtual DbSet<ThongKeThuNhap> ThongKeThuNhaps { get; set; }
    }
}
