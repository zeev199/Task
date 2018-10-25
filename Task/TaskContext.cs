using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.model;

namespace Task
{
    class TaskContext : DbContext
    {
        public TaskContext() : base(@"Data Source=AJUR3\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }
        public DbSet<TblUser> TblUser { get; set; }
        public DbSet<TblTask> TblTask { get; set; }
        public DbSet<TblTaskAddress> TblTaskAddress { get; set; }
        public DbSet<TblTaskConnection> TblTaskConnections { get; set; }
        public DbSet<TblTaskItems> TblTaskItems { get; set; }
        public DbSet<TblWork> TblWorks { get; set; }
        public DbSet<TblShift> TblShifts { get; set; }
        public DbSet<TblShiftPermanent> TblShiftsPermanent { get; set; }
        public DbSet<TblEzor> TblEzor { get; set; }
        public DbSet<TblEzorCity> TblEzorCity { get; set; }
        public DbSet<TblDriver> TblDriver { get; set; }
        public DbSet<TblCar> TblCar { get; set; }


        public DbSet<TypeTask> TypeTask { get; set; }
        public DbSet<TypeAddress> TypeAddress { get; set; }
        public DbSet<TypeDepartment> TypeDepartment { get; set; }
        public DbSet<TypeItem> TypeItem { get; set; }
        public DbSet<TypeWorkStatus> TypeWorkStatus { get; set; }
        public DbSet<TypeCar> TypeCar { get; set; }
        public DbSet<TypeConnection> TypeConnection { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblUser>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_IUser", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UUser", "dbo"))
                    .Delete(sp => sp.HasName("sp_DUser", "dbo")));
            modelBuilder.Entity<TblTask>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_ITask", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UTask", "dbo"))
                    .Delete(sp => sp.HasName("sp_DTask", "dbo")));
            modelBuilder.Entity<TblTaskAddress>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_ITaskAddress", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UTaskAddress", "dbo"))
                    .Delete(sp => sp.HasName("sp_DTaskAddress", "dbo")));
            modelBuilder.Entity<TblTaskConnection>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_ITaskConnection", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UTaskConnection", "dbo"))
                    .Delete(sp => sp.HasName("sp_DTaskConnection", "dbo")));
            modelBuilder.Entity<TblTaskItems>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_ITaskItems", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UTaskItems", "dbo"))
                    .Delete(sp => sp.HasName("sp_DTaskItems", "dbo")));
            modelBuilder.Entity<TblWork>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_IWork", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UWork", "dbo"))
                    .Delete(sp => sp.HasName("sp_DWork", "dbo")));
            modelBuilder.Entity<TblShift>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_IShift", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UShift", "dbo"))
                    .Delete(sp => sp.HasName("sp_DShift", "dbo")));
            modelBuilder.Entity<TblShiftPermanent>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_IShiftPermanent", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UShiftPermanent", "dbo"))
                    .Delete(sp => sp.HasName("sp_DShiftPermanent", "dbo")));
            modelBuilder.Entity<TblEzor>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_IEzor", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UEzor", "dbo"))
                    .Delete(sp => sp.HasName("sp_DEzor", "dbo")));
            modelBuilder.Entity<TblEzorCity>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_IEzorCity", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UEzorCity", "dbo"))
                    .Delete(sp => sp.HasName("sp_DEzorCity", "dbo")));
            modelBuilder.Entity<TblDriver>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_IDriver", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UDriver", "dbo"))
                    .Delete(sp => sp.HasName("sp_DDriver", "dbo")));
            modelBuilder.Entity<TblCar>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_ICar", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UCar", "dbo"))
                    .Delete(sp => sp.HasName("sp_DCar", "dbo")));

            modelBuilder.Entity<TypeTask>()
                          .MapToStoredProcedures(p =>
                   p.Insert(sp => sp.HasName("sp_ITypeTask", "dbo")
                          .Result(rs => rs.ID, "Id"))
                    .Update(sp => sp.HasName("sp_UTypeTask", "dbo"))
                    .Delete(sp => sp.HasName("sp_DTypeTask", "dbo")));
            

















        }
    }
}
