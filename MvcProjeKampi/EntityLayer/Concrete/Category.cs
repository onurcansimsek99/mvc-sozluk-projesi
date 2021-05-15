using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int  CategoryID { get; set; }

        [StringLength(50)]
        public string   CategoryName { get; set; }

        [StringLength(200)]
        public string   CategoryDescription { get; set; }

        public bool   CategoryStatus { get; set; }        //silme işlemi yerine durumu aktif pasif yapmak için kullanıyoruz. [String length ile kısıtlamaya gerek yok]


        public ICollection<Heading> Headings { get; set; }
        
    }
}
