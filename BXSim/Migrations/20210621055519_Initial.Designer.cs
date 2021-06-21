﻿// <auto-generated />
using System;
using BXSim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BXSim.Migrations
{
    [DbContext(typeof(BXSimDbContext))]
    [Migration("20210621055519_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("BXSim.Data.Quiz", b =>
                {
                    b.Property<int>("QuizID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Answers")
                        .HasColumnType("TEXT");

                    b.Property<string>("Explanation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Options")
                        .HasColumnType("TEXT");

                    b.Property<int?>("QuizScenarioID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Statement")
                        .HasColumnType("TEXT");

                    b.Property<string>("StatementPartial")
                        .HasColumnType("TEXT");

                    b.HasKey("QuizID");

                    b.HasIndex("QuizScenarioID");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("BXSim.Data.QuizScenario", b =>
                {
                    b.Property<int>("QuizScenarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ScenarioPartial")
                        .HasColumnType("TEXT");

                    b.HasKey("QuizScenarioID");

                    b.ToTable("QuizScenarios");
                });

            modelBuilder.Entity("BXSim.Data.Quiz", b =>
                {
                    b.HasOne("BXSim.Data.QuizScenario", null)
                        .WithMany("Quizzes")
                        .HasForeignKey("QuizScenarioID");
                });

            modelBuilder.Entity("BXSim.Data.QuizScenario", b =>
                {
                    b.Navigation("Quizzes");
                });
#pragma warning restore 612, 618
        }
    }
}
