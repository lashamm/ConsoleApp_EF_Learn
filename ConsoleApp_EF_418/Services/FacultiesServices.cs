using ConsoleApp_EF_418.Data;
using ConsoleApp_EF_418.Models;
using System.Threading.Tasks;

namespace ConsoleApp_EF_418.Services
{
    internal class FacultiesServices : IFacultiesServices
    {
        private readonly UniversityDbContext context = new UniversityDbContext();

        /// <summary>
        /// This method creates faculty.
        /// </summary>
        /// <param name="faculty">New faculty</param>
        /// <returns></returns>
        public async Task Create(Faculty faculty)
        {
            await context.Faculties.AddAsync(faculty);

            await context.SaveChangesAsync();
        }

        /// <summary>
        /// This method deletes faculty by ID.
        /// </summary>
        /// <param name="id">Deleting faculty</param>
        /// <returns></returns>
        public async Task DeleteById(int id)
        {
            await context.Faculties.FindAsync(id);

            context.Faculties.Remove(await context.Faculties.FindAsync(id)!);
            await context.SaveChangesAsync();
        }

        /// <summary>
        /// This method gets list of faculties.
        /// </summary>
        /// <returns></returns>
        public List<Faculty> GetAllFaculty()
        {
             return context.Faculties.ToList();
        }

        /// <summary>
        /// This method gets faculty by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Faculty?> GetById(int id)
        {

            return await context.Faculties.FindAsync(id);
        }

        /// <summary>
        /// This method updates faculty.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="faculty"></param>
        /// <returns></returns>
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
