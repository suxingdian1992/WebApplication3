namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication3.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// �˷���������Ǩ�Ƶ�ʱ�������ִ�У�ע�⣬�˷�����д���֮���ڰ���������ִ��
        /// add-migration Initial��Ὺʼ��ʼ�����ݿ⣬�����״�Ǩ�Ʊ���ִ�еĶ�����֮��
        /// ��ִ��update-database�������������
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(WebApplication3.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //Enable-Migrations -ContextTypeName WebApplication3.Models.MovieDBContext
            //���������Ҫ��nut������������̨�����룬��벿�ֱַ�����Ŀ���ƣ�ģ�ͣ�����ģ�����ƣ�����ȷ����ʼ�����ݿ��ʱ���Ƿ���Ҫ�ڿ���ֱ�ӽ���һ�±��
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "PG",
                    Price = 7.99M
                },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = "PG",
                     Price = 9.99M
                 },

               new Movie
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Rating = "PG",
                   Price = 3.99M
               }
           );

        }

    }
}
