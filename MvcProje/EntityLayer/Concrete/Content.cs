using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(100)]
        public string ContentValue { get; set; }

        public DateTime ContentTime { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
