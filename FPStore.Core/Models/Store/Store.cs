using FPStore.Core.Abstracts;
using FPStore.Core.Models.Identity;
using System.ComponentModel.DataAnnotations;

namespace FPStore.Core.Models.Store
{
    public class Store : BaseEntity
    {
        // Temel bilgiler
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        // Vergi/Fatura bilgileri
        [Required]
        public string TaxNumber { get; set; }
        [Required]
        public string TaxOffice { get; set; }
        public string CompanyType { get; set; }
        [Required]
        public string CompanyTitle { get; set; }
        public string IdentityNumber { get; set; }

        // Admin ilişkisi
        [Required]
        public string AdminId { get; set; }
        public ApplicationUser Admin { get; set; }

        // Onay ve durum bilgileri
        public bool IsApproved { get; set; } = false;  // Varsayılan olarak onaysız
        public DateTime? ApprovalDate { get; set; }    // Onay tarihi
        public string ApprovedById { get; set; }       // Onaylayan SuperAdmin
        public ApplicationUser ApprovedBy { get; set; }
        public bool IsActive { get; set; } = false;    // Varsayılan olarak pasif

        // İletişim ve adres
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public StoreAddress Address { get; set; }

        // Komisyon
        public decimal CommissionRate { get; set; }

        // İlişkiler
        public ICollection<StoreProduct> StoreProducts { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
