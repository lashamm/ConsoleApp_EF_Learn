namespace ConsoleApp_EF_418.Models
{
    internal class Course
    {
        public int Id { get; set; }

        public string Title { get; set; }

        //public string Description { get; set; }

        public int Credits { get; set; }

        public string Degree { get; set; } // enum
    }
}
