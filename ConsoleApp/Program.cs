using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistanceLayerNoGeneric.Repositories;
using Entities.School;
using MyDatabase;
using PersistanceGeneric.Repositories;
using ProjectRepository = PersistanceGeneric.Repositories.ProjectRepository;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            ProjectRepository projectService = new ProjectRepository(context);

            var projects = projectService.GetProjectsOrderBy();

            foreach (var pro in projects)
            {
                Console.WriteLine(pro.Title);
            }


           


        }
    }
}
