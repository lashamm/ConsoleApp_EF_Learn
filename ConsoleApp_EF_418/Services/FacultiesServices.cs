using ConsoleApp_EF_418.Data;
using ConsoleApp_EF_418.Models;
using System.Threading.Tasks;

namespace ConsoleApp_EF_418.Services
{
    internal class FacultiesServices : IFacultiesServices
    {
        private readonly UniversityDbContext context = new UniversityDbContext();

        public async Task Create(Faculty faculty)
        {
            await context.Faculties.AddAsync(faculty);

            await context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            await context.Faculties.FindAsync(id);

            context.Faculties.Remove(await context.Faculties.FindAsync(id)!);
            await context.SaveChangesAsync();
        }

        public List<Faculty> GetAllFaculty()
        {
             return context.Faculties.ToList();
        }

        public async Task<Faculty?> GetById(int id)
        {

            return await context.Faculties.FindAsync(id);
        }

        public async Task Update(int id, Faculty faculty)
        {
            await context.Faculties.FindAsync(id);
            await context.SaveChangesAsync();
        }

        void IFacultiesServices.DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        void IFacultiesServices.Update(int id, Faculty faculty)
        {
            throw new NotImplementedException();
        }
    }
}
