using ConsoleApp_EF_418.Models;

namespace ConsoleApp_EF_418.Services
{
    internal interface IFacultiesServices
    {
        /// <summary>
        /// This method creates faculty.
        /// </summary>
        /// <param name="faculty"> New faculty </param>
        Task Create(Faculty faculty);

        /// <summary>
        /// This method updates faculty.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="faculty"></param>
        void  Update(int id, Faculty faculty);

        /// <summary>
        /// Gets faculty id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        Task<Faculty?> GetById(int id);

        /// <summary>
        /// Gets list of faculties
        /// </summary>
        /// <returns></returns>
        List<Faculty> GetAllFaculty();

        /// <summary>
        /// This method deletes faculty by ID. 
        /// </summary>
        /// <param name="id">Faculty ID</param>
        void DeleteById(int id);
    }
}
