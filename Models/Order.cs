using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VerstaTestVatnik.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("Номер заказа")]
        public int Id { get; set; }

        [DisplayName("Город отправителя")]
        [Required(ErrorMessage = "Город отправителя должен быть введён!")]
        public string SenderCity { get; set; }
        
        [DisplayName("Адрес отправителя")]
        [Required(ErrorMessage = "Адрес отправителя должен быть введён!")]
        public string SenderAddress { get; set; }

        [DisplayName("Город получателя")]
        [Required(ErrorMessage = "Город получателя должен быть введён!")]
        public string RecepientCity { get; set; }

        [DisplayName("Адрес получателя")]
        [Required(ErrorMessage = "Адрес получателя должен быть введён!")]
        public string RecepientAddress { get; set; }

        [DisplayName("Вес")]
        [Required(ErrorMessage = "Вес должен быть введён!")]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public decimal Weight { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Дата")]
        [Required(ErrorMessage = "Дата должна быть введена!")]
        public DateTime Date { get; set; }

    }
}
