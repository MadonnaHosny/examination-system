﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace OnlineExaminationSystem.Entities;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Hours { get; set; }

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Topic> Topics { get; set; } = new List<Topic>();

    public virtual ICollection<Instructor> Ins { get; set; } = new List<Instructor>();

    public virtual ICollection<Student> Sts { get; set; } = new List<Student>();
}