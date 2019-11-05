using System.ComponentModel.DataAnnotations.Schema;

namespace ef101.Controllers
{
    public class PersonEntity
    {
        // [Column(Order=1, TypeName="serial")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}