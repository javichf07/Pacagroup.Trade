namespace Pacagroup.Trade.Domain.Commons
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTime Create {  get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }

    }
}
