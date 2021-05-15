﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }

        
        public DateTime HeadingDate { get; set; }             // key ile kısıtlamaya gerek yok


        public int CategoryID  { get; set; }             //İlişkili tablonun anahtar sütunu ismi ile aynı olacak : Category tablosundaki CategoryID ismi ile.
        public virtual Category Category { get; set; }

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }


        public ICollection<Content> Contents { get; set; }
    }
}
