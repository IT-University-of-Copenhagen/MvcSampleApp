using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MvcSampleApp.Models
{
    public class MessageContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }

    public class Message
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }

        [Required]
        [Display(Name = "Your name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "The message")]
        [DataType(DataType.MultilineText)]
        public string MessageText { get; set; }
    }
}
