
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteLogiin.DataModel
{
    public class DataForGrid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public string email { get; set; }


    }
}
