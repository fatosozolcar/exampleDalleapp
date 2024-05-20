using MextFullstackSaaS.Domain.Common;
using MextFullstackSaaS.Domain.Identity;

namespace MextFullstackSaaS.Domain.Entities{
    
    public class Order:EntityBase<Guid>
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string IconDescription { get; set; }

        public string ColorCode { get; set; }

        public string AiModelTypes { get; set; }

        public string DesignType { get; set; }

        public int Quantity { get; set; }
    }
    
}