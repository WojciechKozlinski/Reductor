using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reductor.Engine.Models
{
    public class Content
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContentID { get; set;}
        [Key]
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }

    }
}
