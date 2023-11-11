namespace Orfarm.Models.Base
{
    public class CommonProp
    {
        public CommonProp()
        {
            CreatedAt = DateTime.Now;
        }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}
