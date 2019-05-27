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

        public IDbSet<Articles> Articles { get; set; }
        public IDbSet<Comments> Comments { get; set; }
        public IDbSet<Forms> Forms { get; set; }

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
                    "Test hteme 1",
                    "Test name 1",
                    "Me and You",
                    "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Beatae," +
                    " blanditiis eum, reprehenderit ex maxime perferendis nostrum debitis" +
                    " corrupti labore, repellendus incidunt aliquid atque. Neque exercitationem" +
                    " nostrum alias harum vel dolorem?Optio dolor reiciendis quam repellendus maxime" +
                    " soluta dolore magni alias quaerat animi provident aspernatur possimus, perferendis autem deleniti molestias voluptates laudantium perspiciatis libero natus. Vel soluta voluptatum est necessitatibus dicta?"
                    },
                new Articles(
                    "Test hteme 1",
                    "Test name 2",
                    "Only You",
                    "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Beatae," +
                    " blanditiis eum, reprehenderit ex maxime perferendis nostrum debitis" +
                    " corrupti labore, repellendus incidunt aliquid atque. Neque exercitationem" +
                    " nostrum alias harum vel dolorem?Optio dolor reiciendis quam repellendus maxime" +
                    " soluta dolore magni alias quaerat animi provident aspernatur possimus, perferendis autem deleniti molestias voluptates laudantium perspiciatis libero natus. Vel soluta voluptatum est necessitatibus dicta?"
                    ),
                new Articles(
                    "Test hteme 2",
                    "Test name 3",
                    "Only Me",
                    "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Beatae," +
                    " blanditiis eum, reprehenderit ex maxime perferendis nostrum debitis" +
                    " corrupti labore, repellendus incidunt aliquid atque. Neque exercitationem" +
                    " nostrum alias harum vel dolorem?Optio dolor reiciendis quam repellendus maxime" +
                    " soluta dolore magni alias quaerat animi provident aspernatur possimus, perferendis autem deleniti molestias voluptates laudantium perspiciatis libero natus. Vel soluta voluptatum est necessitatibus dicta?"
                    )
                #endregion
            };

            articles.ForEach(std => context.Articles.Add(std));
            context.SaveChanges();
        }
    }
}
