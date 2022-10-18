using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sukiya.Models
{
    public partial class SukiyaContextDB : DbContext
    {
        public SukiyaContextDB()
            : base("name=SukiyaContextDB1")
        {
        }

        public virtual DbSet<Ban> Ban { get; set; }
        public virtual DbSet<BangChamCong> BangChamCong { get; set; }
        public virtual DbSet<CT_LichLam> CT_LichLam { get; set; }
        public virtual DbSet<CT_Mon> CT_Mon { get; set; }
        public virtual DbSet<CT_PhieuGoiMon> CT_PhieuGoiMon { get; set; }
        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<HopDong> HopDong { get; set; }
        public virtual DbSet<LichLamViec> LichLamViec { get; set; }
        public virtual DbSet<LoaiMon> LoaiMon { get; set; }
        public virtual DbSet<Mon> Mon { get; set; }
        public virtual DbSet<NguyenVatLieu> NguyenVatLieu { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhieuGoiMon> PhieuGoiMon { get; set; }
        public virtual DbSet<PhieuTraLuong> PhieuTraLuong { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .HasMany(e => e.PhieuGoiMon)
                .WithRequired(e => e.Ban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BangChamCong>()
                .Property(e => e.LuongCoBan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BangChamCong>()
                .HasMany(e => e.PhieuTraLuong)
                .WithRequired(e => e.BangChamCong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_PhieuGoiMon>()
                .Property(e => e.Size)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.NhanVien)
                .WithRequired(e => e.ChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LichLamViec>()
                .HasMany(e => e.CT_LichLam)
                .WithRequired(e => e.LichLamViec)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiMon>()
                .HasMany(e => e.Mon)
                .WithRequired(e => e.LoaiMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Mon>()
                .Property(e => e.Size)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.CT_Mon)
                .WithRequired(e => e.Mon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.CT_PhieuGoiMon)
                .WithRequired(e => e.Mon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguyenVatLieu>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NguyenVatLieu>()
                .HasMany(e => e.CT_Mon)
                .WithRequired(e => e.NguyenVatLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoCCCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BangChamCong)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.CT_LichLam)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDon)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HopDong)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuGoiMon>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuGoiMon>()
                .HasMany(e => e.CT_PhieuGoiMon)
                .WithRequired(e => e.PhieuGoiMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuGoiMon>()
                .HasMany(e => e.HoaDon)
                .WithRequired(e => e.PhieuGoiMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuTraLuong>()
                .Property(e => e.TienPhuCap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuTraLuong>()
                .Property(e => e.TienLuong)
                .HasPrecision(19, 4);
        }
    }
}
