﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Models;

public partial class StudentContext : DbContext
{
    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.Skills)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudDepartment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentId).ValueGeneratedOnAdd();
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}