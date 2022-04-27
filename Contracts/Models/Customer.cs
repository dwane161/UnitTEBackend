using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerApi.Contracts.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
 
        public string FirstName { get; set; }
 
        public string LastName { get; set; }

        public string BirthDate { get; set; }

        public string Genre { get; set; }

        public string Email { get; set; }

        public string ContactNumbers { get; set; }
    }
}
