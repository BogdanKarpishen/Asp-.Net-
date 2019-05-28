using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace BlogDatabase
{
    public class BlogDBContext : DbContext
    {

        public BlogDBContext()
            :base("BlogDbContext")
        { }

        public DbSet<Articles> Articles { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Forms> Forms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        

    }
    //TODO TНе забыть поменять класс после дебага
    public class BlogDbContextInitializer:
        DropCreateDatabaseAlways<BlogDBContext>
    {
        protected override void Seed(BlogDBContext context)
        {
            var articles = new List<Articles>
            {
                //TODO тестовые данные
                #region
                new Articles {
                    Theme = "Test theme 1",
                    Name = "Test name 1",
                    Creator = "Me and You",
                    Date = DateTime.UtcNow,
                    Text = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Beatae," +
                    " blanditiis eum, reprehenderit ex maxime perferendis nostrum debitis" +
                    " corrupti labore, repellendus incidunt aliquid atque. Neque exercitationem" +
                    " nostrum alias harum vel dolorem?Optio dolor reiciendis quam repellendus maxime" +
                    " soluta dolore magni alias quaerat animi provident aspernatur possimus, perferendis autem deleniti molestias voluptates laudantium perspiciatis libero natus. Vel soluta voluptatum est necessitatibus dicta?"
                    },
                new Articles{
                    Theme = "Test theme 1",
                    Name = "Test name 2",
                    Creator = "Only You",
                    Date = DateTime.UtcNow,
                    Text = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Beatae," +
                    " blanditiis eum, reprehenderit ex maxime perferendis nostrum debitis" +
                    " corrupti labore, repellendus incidunt aliquid atque. Neque exercitationem" +
                    " nostrum alias harum vel dolorem?Optio dolor reiciendis quam repellendus maxime" +
                    " soluta dolore magni alias quaerat animi provident aspernatur possimus, perferendis autem deleniti molestias voluptates laudantium perspiciatis libero natus. Vel soluta voluptatum est necessitatibus dicta?"
                            },
                new Articles{
                    Theme = "Test hteme 2",
                    Name = "Test name 3",
                    Creator = "Only Me",
                    Date = DateTime.UtcNow,
                    Text = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Beatae," +
                    " blanditiis eum, reprehenderit ex maxime perferendis nostrum debitis" +
                    " corrupti labore, repellendus incidunt aliquid atque. Neque exercitationem" +
                    " nostrum alias harum vel dolorem?Optio dolor reiciendis quam repellendus maxime" +
                    " soluta dolore magni alias quaerat animi provident aspernatur possimus, perferendis autem deleniti molestias voluptates laudantium perspiciatis libero natus. Vel soluta voluptatum est necessitatibus dicta?"
                        }
                #endregion
            };
            var form = new List<Forms>
            {
                new Forms
                {
                    FirstName = "Test",
                    SecondName = "Test",
                    City = "Test",
                    SecretName = new string[]{"Test" },
                    Weapons = new string[]{"Test" }
                }

        };
            form.ForEach(std => context.Forms.Add(std));
            articles.ForEach(std => context.Articles.Add(std));
            
            context.SaveChanges();
        }
    }
}
