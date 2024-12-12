using Ecop.DAL.Models;
using Ecop.PL.Data.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Ecop.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Court> Courts { get; set; }
        public DbSet<Judge> Judges { get; set; }
        public DbSet<Policeman> Policemans { get; set; }
        public DbSet<TrafficViolation> TrafficViolations { get; set; }
        public DbSet<CourtDecisions> CourtDecisions { get; set; }
        public DbSet<PolicemanDecision> PolicemanDecisions { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            builder.Entity<Car>()
             .HasOne(c => c.Citizen)  // علاقة "One-to-Many" من Car إلى Citizen
             .WithMany(citizen => citizen.Cars)  // كل Citizen يمكنه امتلاك العديد من السيارات
             .HasForeignKey(c => c.CitizenId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TrafficViolation>()
            .HasOne(c => c.Citizen)  // الشكوى تكون مرتبطة بمواطن واحد
            .WithMany(c => c.TrafficViolations)  // كل مواطن يمكنه تقديم العديد من الشكاوى
            .HasForeignKey(c => c.CitizenId).OnDelete(DeleteBehavior.Cascade);  // المفتاح الأجنبي الذي يشير إلى المواطن
            builder.Entity<PolicemanDecision>()
              .HasOne(d => d.Policeman)  // القرار مرتبط بشرطي واحد فقط
              .WithMany(o => o.Decisions)  // الشرطي يمكنه تقديم عدة قرارات
              .HasForeignKey(d => d.PolicemanDecisionId).OnDelete(DeleteBehavior.Cascade);  // المفتاح الأجنبي المرتبط بالشرطي
            builder.Entity<TrafficViolation>()
               .HasOne(v => v.Decision)  // كل مخالفة مرتبطة بقرار واحد فقط
               .WithOne(d => d.TrafficViolation)  // وكل قرار مرتبط بمخالفة واحدة فقط
               .HasForeignKey<TrafficViolation>(v => v.DecisionId);  // المفتاح الأجنبي في المخالفة
            builder.Entity<PolicemanDecision>()
               .HasOne(d => d.TrafficViolation)  // كل قرار مرتبط بمخالفة واحدة فقط
               .WithOne(v => v.Decision)  // وكل مخالفة مرتبطة بقرار واحد فقط
               .HasForeignKey<PolicemanDecision>(d => d.Violationid);  // المفتاح الأجنبي في القرار




            // تحديد العلاقة One-to-Many بين Court و JudicialDecision
            builder.Entity<CourtDecisions>()
                .HasOne(jd => jd.Court)  // القرار مرتبط بمحكمة واحدة فقط
                .WithMany(c => c.CourtDecisions)  // المحكمة يمكنها إصدار عدة قرارات
                .HasForeignKey(jd => jd.Courtid).OnDelete(DeleteBehavior.Cascade); // المفتاح الأجنبي المرتبط بالمحكمة
            builder.Entity<PolicemanDecision>()
          .HasOne(pd => pd.CourtDecision)  // كل قرار شرطي مرتبط بقرار محكمة واحد فقط
          .WithOne(cd => cd.PoliceDecision)  // وكل قرار محكمة مرتبط بقرار شرطي واحد فقط
          .HasForeignKey<PolicemanDecision>(pd => pd.CourtDecisionId);  // المفتاح الأجنبي في قرار الشرطي
            builder.Entity<CourtDecisions>()
                .HasOne(cd => cd.PoliceDecision)  // كل قرار محكمة مرتبط بقرار شرطي واحد فقط
                .WithOne(pd => pd.CourtDecision)  // وكل قرار شرطي مرتبط بقرار محكمة واحد فقط
                .HasForeignKey<CourtDecisions>(cd => cd.PoliceDecisionId);  // المفتاح الأجنبي في قرار المحكمة

            builder.Entity<TrafficViolation>()
           .HasOne(vs => vs.CourtDecision)  // كل حالة مخالفة مرتبطة بقرار قاضي واحد فقط
           .WithOne(cd => cd.ViolationStatus)  // وكل قرار قاضي مرتبط بحالة مخالفة واحدة فقط
           .HasForeignKey<TrafficViolation>(vs => vs.CourtDecisionId).OnDelete(DeleteBehavior.Restrict);  // المفتاح الأجنبي في حالة المخالفة

            builder.Entity<CourtDecisions>()
                .HasOne(cd => cd.ViolationStatus)  // كل قرار قاضي مرتبط بحالة مخالفة واحدة فقط
                .WithOne(vs => vs.CourtDecision)  // وكل حالة مخالفة مرتبطة بقرار قاضي واحد فقط
                .HasForeignKey<CourtDecisions>(cd => cd.Violationid);  // المفتاح الأجنبي في قرار القاضي

            builder.Entity<Judge>()
            .HasMany(j => j.CourtDecisions)  // القاضي يمكن أن يحكم في العديد من المخالفات
            .WithOne(v => v.Judge)  // كل مخالفة تتعلق بقاضي واحد فقط
            .HasForeignKey(v => v.JudgeId).OnDelete(DeleteBehavior.Cascade); // المفتاح الأجنبي في جدول المخالفات

            // تعريف العلاقة بين Citizen و ApplicationUser
            builder.Entity<Citizen>()
                .HasOne(c => c.User)
                .WithMany() // إذا لم يكن هناك قائمة مواطنين في المستخدم
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Policeman>()
               .HasOne(c => c.User)
               .WithMany() // إذا لم يكن هناك قائمة مواطنين في المستخدم
               .HasForeignKey(c => c.UserId)
               .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Judge>()
             .HasOne(c => c.User)
             .WithMany() // إذا لم يكن هناك قائمة مواطنين في المستخدم
             .HasForeignKey(c => c.UserId)
             .OnDelete(DeleteBehavior.Cascade);

          
            // استدعاء Seed Data
            // SeedData.Initialize(builder);
            // تعريف أدوار المستخدمين (Admin, Citizen, Policeman, Judge)
            var roleAdminId = Guid.NewGuid().ToString();
            var roleCitizenId = Guid.NewGuid().ToString();
            var rolePolicmanId = Guid.NewGuid().ToString();
            var roleJudgeId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = roleAdminId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = roleCitizenId, Name = "Citizen", NormalizedName = "CITIZEN" },
                new IdentityRole { Id = rolePolicmanId, Name = "Policeman", NormalizedName = "POLICEMAN" },
                new IdentityRole { Id = roleJudgeId, Name = "Judge", NormalizedName = "JUDGE" }
            );

            // إنشاء مستخدمين منفصلين لكل فئة
            var hasher = new PasswordHasher<ApplicationUser>();

            var AdminUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true
            };
            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "Admin@123");

            var CitizenUser1 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Braa",
                NormalizedUserName = "Braa",
                Email = "braa@gmail.com",
                NormalizedEmail = "BRAA@GMAIL.COM",
                EmailConfirmed = true
            };
            CitizenUser1.PasswordHash = hasher.HashPassword(CitizenUser1, "Braa@123");

            var CitizenUser2 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Osama",
                NormalizedUserName = "OSAMA",
                Email = "Osama@gmail.com",
                NormalizedEmail = "OSAMA@GMAIL.COM",
                EmailConfirmed = true
            };
            CitizenUser2.PasswordHash = hasher.HashPassword(CitizenUser2, "Osama@123");

          

            var PolicmanUser1 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Mohammed",
                NormalizedUserName = "MOHAMMED",
                Email = "Mohammed@gmail.com",
                NormalizedEmail = "MOHAMMED@GMAIL.COM",
                EmailConfirmed = true
            };
            PolicmanUser1.PasswordHash = hasher.HashPassword(PolicmanUser1, "Mohammed@123");
            var PolicmanUser2 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Noor",
                NormalizedUserName = "NOOR",
                Email = "Noor@gmail.com",
                NormalizedEmail = "Noor@GMAIL.COM",
                EmailConfirmed = true
            };
            PolicmanUser2.PasswordHash = hasher.HashPassword(PolicmanUser2, "Noor@123");
            var JudgeUser1 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Ali",
                NormalizedUserName = "ALI",
                Email = "Ali@gmail.com",
                NormalizedEmail = "ALI@GMAIL.COM",
                EmailConfirmed = true
            };
            JudgeUser1.PasswordHash = hasher.HashPassword(JudgeUser1, "Ali@123");

            var JudgeUser2 = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Hadi",
                NormalizedUserName = "HADI",
                Email = "Hadi@gmail.com",
                NormalizedEmail = "HADI@GMAIL.COM",
                EmailConfirmed = true
            };
            JudgeUser2.PasswordHash = hasher.HashPassword(JudgeUser2, "Hadi@123");

        
            // إضافة المستخدمين إلى قاعدة البيانات
            builder.Entity<ApplicationUser>().HasData(AdminUser, CitizenUser1, CitizenUser2, PolicmanUser1, PolicmanUser2, JudgeUser1, JudgeUser2);

            // ربط المستخدمين بالأدوار المناسبة
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = roleAdminId, UserId = AdminUser.Id },
                new IdentityUserRole<string> { RoleId = roleCitizenId, UserId = CitizenUser1.Id },
                new IdentityUserRole<string> { RoleId = roleCitizenId, UserId = CitizenUser2.Id },
                new IdentityUserRole<string> { RoleId = rolePolicmanId, UserId = PolicmanUser1.Id },
                new IdentityUserRole<string> { RoleId = rolePolicmanId, UserId = PolicmanUser2.Id },
                new IdentityUserRole<string> { RoleId = roleJudgeId, UserId = JudgeUser1.Id },
                new IdentityUserRole<string> { RoleId = roleJudgeId, UserId = JudgeUser2.Id }
                
            );

            // إضافة بيانات المواطنين وربطهم بمستخدميهم
            builder.Entity<Citizen>().HasData(
                new Citizen
                {
                    CitizenId = 1,
                    Name = "Braa",
                    Phone = "1231231234",
                    Address = "Tubas",
                    Email = "braa@gmail.com",
                    Password = "Braa@123",
                    Camera_id = "cam123",
                    UserId = CitizenUser1.Id // ربط المواطن بالمستخدم 1
                },
                new Citizen
                {
                    CitizenId = 2,
                    Name = "Osama",
                    Email = "Osama@gmail.com",
                    Password = "Osama@123",
                    Phone = "3213214321",
                    Address = "Tulkarm",
                    Camera_id = "cam456",
                    UserId = CitizenUser2.Id // ربط المواطن بالمستخدم 2
                }
            );

            // إضافة بيانات الشرطة وربطهم بمستخدميهم
            builder.Entity<Policeman>().HasData(
                new Policeman
                {
                    PolicemanId = 1,
                    Name = "Mohammed",
                    Badge_Number = "12345",
                    Email = "Mohammed@gmail.com",
                    Password ="Mohammed@123",
                    Phone = "0123456789",
                    UserId = PolicmanUser1.Id // ربط الشرطي بالمستخدم 1
                },
                new Policeman
                {
                    PolicemanId = 2,
                    Name = "Noor",
                    Badge_Number = "54321",
                    Email = "Noor@gmail.com",
                    Password = "Noor@123",
                    Phone = "0987654321",
                    UserId = PolicmanUser2.Id // ربط الشرطي بالمستخدم 2
                }
            );

            // إضافة بيانات القضاة وربطهم بمستخدميهم
            builder.Entity<Judge>().HasData(
                new Judge
                {
                    JudgeId = 1,
                    Name = "Ali",
                    Email = "Ali@gmail.com",
                    Password = "Ali@123",
                    Phone = "1234567890",
                    Address = "Jenin",
                    UserId = JudgeUser1.Id // ربط القاضي بالمستخدم 1
                },
                new Judge
                {
                    JudgeId = 2,
                    Name = "Hadi",
                    Email = "Hadi@gmail.com",
                    Password = "Hadi@123",
                    Phone = "0987654321",
                    Address = "Nablus",
                    UserId = JudgeUser2.Id // ربط القاضي بالمستخدم 2
                }
                
            );


        }




    }
}
