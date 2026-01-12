using ConsoleApp_EF_418.Models;
using ConsoleApp_EF_418.Services;

// EF Core:
// SqlServer
// Tools
// Design

//codeshare.io/GA04bx

//UniversityDbContext context = new UniversityDbContext();

//Student student = new Student()
//{
//    Name = "John",
//    Surname = "Doe",
//    Email = "john@mail.com",
//    FacultyId = 1,
//};

//Faculty faculty = new Faculty()
//{
//    Name = "Law",
//    Description = "Law Description.",
//    Dean = "John Doe",
//};

//context.Faculties.Add(faculty);
//context.Add(faculty);

//context.Students.Add(student);
//context.SaveChanges();


Faculty faculty = new Faculty()
{
    Name = "Law",
    Description = "Law Description.",
    Dean = "John Doe",
};

FacultiesServices facultiesServices = new FacultiesServices();
await facultiesServices.Create(faculty);
