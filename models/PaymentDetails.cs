using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentDetails.models
{
    public class PaymentDetailsModel
    {
        [Key]
        public int paymentId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string cardName { get; set; } = "";

        [Column(TypeName = "nvarchar(16)")]
        public string cardNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(5)")]
        public string expiredDate { get; set; } = "";

        [Column(TypeName = "nvarchar(3)")]
        public string privacyNumber { get; set; } = "";
    }
}
