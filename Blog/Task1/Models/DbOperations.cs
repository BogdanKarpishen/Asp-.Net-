using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogDatabase;

namespace Task1.Models
{
    public class DbOperations<T>: IDisposable 
    {
        BlogDBContext blogDbContext = new BlogDBContext();
        
        /// <summary>
        /// Add row to DataBase depends on typeof T
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            switch (item)
            {
                case Articles a:
                    {
                        blogDbContext.Articles.Add(a);

                        break;
                    }
                case Comments c:
                    {
                        blogDbContext.Comments.Add(c);

                        break;
                    }
                case Forms f:
                    {
                        blogDbContext.Forms.Add(f);

                        break;
                    }
            }
            blogDbContext.SaveChanges();
        }

        public List<T> SelectAll()
        {
            Type type = typeof(T);
            switch (type.Name)
            {
                case "Articles":
                    {
                        var str = blogDbContext.Articles.ToList() as List<T>;
                        return blogDbContext.Articles.ToList() as List<T>;
                    }
                case "Comments":
                    {
                        return blogDbContext.Comments.ToList() as List<T>;
                    }
                case "Forms":
                    {
                        return blogDbContext.Forms.ToList() as List<T>;
                    }
                default:
                    return null;
            }
        }

        public void Edit(T item)
        {
            
            switch (item)
            {
                case Articles a:
                    {
                        Articles article =
                        blogDbContext.Articles.Where(m => m.Id == a.Id).First();

                        article.Name = a.Name;
                        article.Tags = a.Tags;
                        article.Date = a.Date;
                        article.Creator = a.Creator;
                        article.Text = a.Text;
                        break;

                        /*db.Users.Attach(updatedUser);
                        var entry = db.Entry(updatedUser);
                        entry.Property(e => e.Email).IsModified = true;
                        // other changed properties
                        db.SaveChanges();*/
                    }
                case Comments c:
                    {
                        Comments article =
                        blogDbContext.Comments.Where(m => m.Id == c.Id).First();

                        article = c;
                        article.Name = c.Name;
                        article.CreationDate = c.CreationDate;
                        article.Review = c.Review;
                        break;
                    }
                case Forms f:
                    {
                        int b = blogDbContext.Articles.Count();
                        int a = blogDbContext.Forms.Count();
                        Forms article =
                        blogDbContext.Forms.First();
                        article.FirstName = f.FirstName;
                        article.SecondName = f.SecondName;
                        article.SecretName = f.SecretName;
                        article.Weapons = f.Weapons;
                        break;
                    }
            }
            blogDbContext.SaveChanges();

        }

        public void Delete(int id)
        {
            var item = blogDbContext.Articles.Where(m => m.Id == id).First();
            item.Tags.Clear();
            blogDbContext.Articles.Remove(item);


            blogDbContext.SaveChanges();
        }

        public void Dispose()
        {
            blogDbContext.Dispose();
        }
    }
}