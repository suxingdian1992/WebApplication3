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

        //获取一个字段的最大最小值范围，最长60，最短3
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        //显示名字为发布日期，带空格，数据类型为date，格式为：{0:yyyy-MM-dd}
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        //设定正则表达式要求，只允许输入大小写字母，此项为必输项，长度最大为60
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        //票价范围在1到100之间
        //显示数据类型为货币
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        //此处正则表达式引入只允许输入大小写字母，首字母必须大写，长度为5
        //此处引入全新属性评级选项，记得使用快捷键重新构造程序Ctrl + Shift + B
        //此处修改结束之后去控制器movie中编辑和创建中修改过滤器
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}