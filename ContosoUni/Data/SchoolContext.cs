using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;
using ContosoUni.Models;

    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Student { get; set; } = default!;

public DbSet<ContosoUniversity.Models.Course> Course { get; set; } = default!;

public DbSet<ContosoUniversity.Models.Enrollment> Enrollment { get; set; } = default!;

public DbSet<ContosoUni.Models.Department> Department { get; set; } = default!;

public DbSet<ContosoUni.Models.Instructor> Instructor { get; set; } = default!;

public DbSet<ContosoUni.Models.OfficeAssignment> OfficeAssignment { get; set; } = default!;

public DbSet<ContosoUni.Models.CourseAssignment> CourseAssignment { get; set; } = default!;
    }
