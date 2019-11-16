﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBPopulator
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LMSEntities : DbContext
    {
        public LMSEntities()
            : base("name=LMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AssignmentDetail> AssignmentDetails { get; set; }
        public virtual DbSet<AssignmentGrade> AssignmentGrades { get; set; }
        public virtual DbSet<AssignmentType> AssignmentTypes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseMat> CourseMats { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<GradeWeight> GradeWeights { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<LetterGradeScale> LetterGradeScales { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<SectionAssignment> SectionAssignments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Zipcode> Zipcodes { get; set; }
    
        [DbFunction("LMSEntities", "students_in_section")]
        public virtual IQueryable<students_in_section_Result> students_in_section(Nullable<int> sctn)
        {
            var sctnParameter = sctn.HasValue ?
                new ObjectParameter("sctn", sctn) :
                new ObjectParameter("sctn", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<students_in_section_Result>("[LMSEntities].[students_in_section](@sctn)", sctnParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_Create_Assignment_Entries(Nullable<int> assignment_id, Nullable<int> section_id)
        {
            var assignment_idParameter = assignment_id.HasValue ?
                new ObjectParameter("assignment_id", assignment_id) :
                new ObjectParameter("assignment_id", typeof(int));
    
            var section_idParameter = section_id.HasValue ?
                new ObjectParameter("section_id", section_id) :
                new ObjectParameter("section_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Create_Assignment_Entries", assignment_idParameter, section_idParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_Update_Student_Grade(Nullable<int> student_id, Nullable<int> assignment_id, Nullable<double> grade)
        {
            var student_idParameter = student_id.HasValue ?
                new ObjectParameter("student_id", student_id) :
                new ObjectParameter("student_id", typeof(int));
    
            var assignment_idParameter = assignment_id.HasValue ?
                new ObjectParameter("assignment_id", assignment_id) :
                new ObjectParameter("assignment_id", typeof(int));
    
            var gradeParameter = grade.HasValue ?
                new ObjectParameter("grade", grade) :
                new ObjectParameter("grade", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Update_Student_Grade", student_idParameter, assignment_idParameter, gradeParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int update_html(string html, Nullable<int> section_id)
        {
            var htmlParameter = html != null ?
                new ObjectParameter("html", html) :
                new ObjectParameter("html", typeof(string));
    
            var section_idParameter = section_id.HasValue ?
                new ObjectParameter("section_id", section_id) :
                new ObjectParameter("section_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("update_html", htmlParameter, section_idParameter);
        }
    }
}
