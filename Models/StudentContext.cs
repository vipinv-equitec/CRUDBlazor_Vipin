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

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Skill>(entity =>
        {
            entity.Property(e => e.SkillName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

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

            entity.HasMany(d => d.SkillsNavigation).WithMany(p => p.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentSkill",
                    r => r.HasOne<Skill>().WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__StudentSk__Skill__59063A47"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__StudentSk__Stude__5812160E"),
                    j =>
                    {
                        j.HasKey("StudentId", "SkillId").HasName("PK__StudentS__5F3F228130178CC7");
                        j.ToTable("StudentSkills");
                    });
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}