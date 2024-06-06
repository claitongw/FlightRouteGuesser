using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRouteGuesser.Core.Entities
{
    public class BaseEntity
    {
        protected BaseEntity() { }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ChangedDate { get; set; }
        public Guid ExternalId { get; set; }
    }
}
