﻿// <auto-generated />
using System;
using AssessmentAnswers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssessmentAnswers.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231017104607_AdjustingAssessmentTrueFalseTable")]
    partial class AdjustingAssessmentTrueFalseTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AssessmentAnswers.Models.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AssessmentQuestionId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentQuestionId");

                    b.ToTable("AssessmentAnswers");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentEnrol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssessmentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentId");

                    b.HasIndex("UserId");

                    b.ToTable("AssessmentEnrols");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentMatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AssessmentQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentQuestionId");

                    b.ToTable("AssessmentMatch");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AssessmentQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentQuestionId");

                    b.ToTable("AssessmentOptions");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AssessmentQuestions");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentQuestionRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssessmentId")
                        .HasColumnType("int");

                    b.Property<int>("AssessmentQuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentId");

                    b.ToTable("AssessmentQuestionRelations");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AssessmentQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentQuestionId");

                    b.ToTable("AssessmentText");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentTrueFalse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AssessmentQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentQuestionId");

                    b.ToTable("AssessmentTrueFalse");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentAnswer", b =>
                {
                    b.HasOne("AssessmentAnswers.Models.AssessmentQuestion", null)
                        .WithMany("AssessmentAnswers")
                        .HasForeignKey("AssessmentQuestionId");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentEnrol", b =>
                {
                    b.HasOne("AssessmentAnswers.Models.Assessment", null)
                        .WithMany("AssessmentEnrols")
                        .HasForeignKey("AssessmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssessmentAnswers.Models.User", null)
                        .WithMany("AssessmentEnrols")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentMatch", b =>
                {
                    b.HasOne("AssessmentAnswers.Models.AssessmentQuestion", null)
                        .WithMany("AssessmentMatch")
                        .HasForeignKey("AssessmentQuestionId");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentOption", b =>
                {
                    b.HasOne("AssessmentAnswers.Models.AssessmentQuestion", null)
                        .WithMany("AssessmentOptions")
                        .HasForeignKey("AssessmentQuestionId");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentQuestionRelation", b =>
                {
                    b.HasOne("AssessmentAnswers.Models.Assessment", null)
                        .WithMany("AssessmentQuestionRelation")
                        .HasForeignKey("AssessmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentText", b =>
                {
                    b.HasOne("AssessmentAnswers.Models.AssessmentQuestion", null)
                        .WithMany("AssessmentText")
                        .HasForeignKey("AssessmentQuestionId");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentTrueFalse", b =>
                {
                    b.HasOne("AssessmentAnswers.Models.AssessmentQuestion", null)
                        .WithMany("AssessmentTrueFalse")
                        .HasForeignKey("AssessmentQuestionId");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.Assessment", b =>
                {
                    b.Navigation("AssessmentEnrols");

                    b.Navigation("AssessmentQuestionRelation");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.AssessmentQuestion", b =>
                {
                    b.Navigation("AssessmentAnswers");

                    b.Navigation("AssessmentMatch");

                    b.Navigation("AssessmentOptions");

                    b.Navigation("AssessmentText");

                    b.Navigation("AssessmentTrueFalse");
                });

            modelBuilder.Entity("AssessmentAnswers.Models.User", b =>
                {
                    b.Navigation("AssessmentEnrols");
                });
#pragma warning restore 612, 618
        }
    }
}
