namespace Fsv.Common.Entities
{
    public class Verification : EntityWithId
    {
        public long Id { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public Customer Customer { get; set; }
    }
}
