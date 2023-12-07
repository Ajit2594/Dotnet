using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Booksweb.Models;

public class Category
{
    [Key]
    public int Id { get; set;}
    [DisplayName("Name")]
    [Required]
    [MaxLength(20)]
    public string Name { get; set; }
[Range(1,20,ErrorMessage ="must be between 1 -20")]
    [DisplayName("Dispaly Order  ap")]
    public int DisplayOrder { get; set; }
}