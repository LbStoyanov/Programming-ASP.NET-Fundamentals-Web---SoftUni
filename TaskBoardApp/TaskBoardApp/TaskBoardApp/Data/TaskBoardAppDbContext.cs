﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TaskBoardApp.Data.Entities;
using Task = TaskBoardApp.Data.Entities.Task;


// ReSharper disable All

namespace TaskBoardApp.Data
{
    public class TaskBoardAppDbContext : IdentityDbContext<User>
    {
        private User GuestUser { get; set; }
        private Board OpenBoard { get; set; }
        private Board InProgressBoard { get; set; }
        private Board DoneBoard { get; set; }


        public TaskBoardAppDbContext(DbContextOptions<TaskBoardAppDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Task>()
                .HasOne(t => t.Board)
                .WithMany(b => b.Tasks)
                .HasForeignKey(t => t.BoardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<User>()
                .HasData(this.GuestUser);

            builder
                .Entity<Board>()
                .HasData(this.OpenBoard, this.InProgressBoard, this.DoneBoard);

            builder
                .Entity<Task>()
                .HasData(new Task()
                    {
                        Id = 1,
                        Title = "Prepare for ASP.NET Fundamentals exam",
                        CreatedOn = DateTime.Now.AddMonths(-1),
                        OwnerId = this.GuestUser.Id,
                        BoardId = this.OpenBoard.Id
                    },
                    new Task()
                    {
                        Id = 2,
                        Title = "Improve EF Core skills",
                        Description = "Learn using EF Core and MS SQL Server Managment Studio",
                        CreatedOn = DateTime.Now.AddMonths(-5),
                        OwnerId = this.GuestUser.Id,
                        BoardId  = this.DoneBoard.Id,
                    },
                    new Task()
                    {
                        Id = 3,
                        Title = "Improve ASP.NET Core skills",
                        Description = "Learn using ASP.NET Core Identity",
                        CreatedOn = DateTime.Now.AddDays(-10),
                        OwnerId = this.GuestUser.Id,
                        BoardId = this.InProgressBoard.Id,
                    },
                    new Task()
                    {
                        Id = 4,
                        Title = "Prepare for C# Web Exam",
                        Description = "Prepare by solving old Mid and Final exams",
                        CreatedOn = DateTime.Now.AddMonths(-5),
                        OwnerId = this.GuestUser.Id,
                        BoardId = this.DoneBoard.Id,
                    });

            base.OnModelCreating(builder);
        }
    }

    
}