

using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Entities
{
    public class NumberSequence
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Module { get; set; }
        [Required]
        public string Prefix { get; set; }
        public int LastNumber { get; set; }
    }
}
