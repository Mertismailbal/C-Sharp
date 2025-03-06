using FPStore.Core.Abstracts;
using FPStore.Core.Models.Identity;
using FPStore.Core.Models.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPStore.Core.Models
{
    public class Review : BaseEntity
    {
        // Üye bilgisi
        public int MemberId { get; set; }
        public ApplicationUser Member { get; set; }

        // Mağaza ürün bilgisi
        public int StoreProductId { get; set; }
        public StoreProduct StoreProduct { get; set; }

        [MaxLength(500, ErrorMessage = "Yorum 500 karakterden uzun olamaz")]
        public string Comment { get; set; }

        [Range(1, 5, ErrorMessage = "Puan 1-5 arasında olmalıdır")]
        public int? Rating { get; set; }

        public DateTime CommentDate { get; set; }

        // Mağaza admin yanıtı
        [MaxLength(500)]
        public string StoreResponse { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int? ResponderAdminId { get; set; }
        public ApplicationUser ResponderAdmin { get; set; }

        public Review()
        {
            CommentDate = DateTime.Now;
        }
    }
}
