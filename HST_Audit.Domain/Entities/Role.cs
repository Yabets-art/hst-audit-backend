namespace HST_Audit.Domain.Entities
{
    public class Role
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }
    }
}