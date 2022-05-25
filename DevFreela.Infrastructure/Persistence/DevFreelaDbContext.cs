using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha descrição de projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha descrição de projeto 2 ", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha descrição de projeto 3 ", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Ana", "ana@teste.com.br", new DateTime(1992, 1, 1)),
                new User("Bruno", "bruno@teste.com.br", new DateTime(1950, 1, 1)),
                new User("Carlos", "carlos@teste.com.br", new DateTime(1980, 1, 1)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}