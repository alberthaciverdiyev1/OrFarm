using Orfarm.Models.Base;

namespace Orfarm.Models.Transport
{
    public class Images:CommonProp
    {
        public string Image { get; set; }
        public bool? IsPrimary { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
