using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.model
{
    public abstract class Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateInsert { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
    public abstract class BaseUser : Base
    {
        public TblUser UserUpdate { get; set; }
    }
    public abstract class BaseType : BaseUser
    {
        public string Description { get; set; }
    }
    public class TblUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
        public TblUser UserUpdate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
