using System.ComponentModel.DataAnnotations;


namespace BakeryHelper.DataAccess.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
