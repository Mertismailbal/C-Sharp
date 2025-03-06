using FPStore.Core.Abstracts;
using FPStore.Core.Enums;
using FPStore.Core.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPStore.Core.Models
{
    public class Order : BaseEntity
    {
        // Siparişi veren kullanıcı (Member)
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        // Hangi mağazadan alındı
        public int StoreId { get; set; }
        public Store.Store Store { get; set; }

        // Sipariş durumu ve ödeme bilgileri
        public OrderStatus Status { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Adres bilgileri
        public int AddressId { get; set; }
        public Address Address { get; set; }

        // Sipariş içeriği
        public ICollection<OrderItem> OrderItems { get; set; }

        // Fatura
        public Invoice Invoice { get; set; }

        // Toplam tutar (veritabanında saklanacak)
        public double TotalAmount { get; set; }

        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            Status = OrderStatus.Pending;
            CreatedDate = DateTime.Now;
        }
    }
}
