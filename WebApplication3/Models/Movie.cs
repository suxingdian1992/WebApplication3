using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class Movie
    {
        //生成迁移基础架构之后则整个项目正式进入codefirst模式，此处以代码优先思维进行数据库模型构造
        //在这里更改模型等同于修改数据库表字段，一定注意，更改之后一定记得重新生成基础架构然后重新灌入数据。
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        //此处引入全新属性评级选项，记得使用快捷键重新构造程序Ctrl + Shift + B
        //此处修改结束之后去控制器movie中编辑和创建中修改过滤器
        public string Rating { get; set; }
    }
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}