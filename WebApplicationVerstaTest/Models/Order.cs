using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace WebApplicationVerstaTest.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Поле 'Город отправителя' не может быть пустым!")]
        public string SenderCity { get; set; } = string.Empty;
        [Required(ErrorMessage = "Поле 'Адрес отправителя' не может быть пустым!")]
        public string SenderAddress { get; set; } = string.Empty;
        [Required(ErrorMessage = "Поле 'Город получателя' не может быть пустым!")]
        public string ReceiverCity { get; set; } = string.Empty;
        [Required(ErrorMessage = "Поле 'Адрес получателя' не может быть пустым!")]
        public string ReceiverAddress { get; set; } = string.Empty;
        [Required(ErrorMessage = " Поле 'Вес груза' не может быть пустым!")]
        public double OrderWeight { get; set; } = 0.0;
        [Required(ErrorMessage = "Поле 'Дата забора груза' не может быть пустым!")]
        public DateOnly PickupDate { get; set; } = DateOnly.MinValue;

        //[NotMapped] 
        //public string PublicOrderNumber => GeneratePublicOrderNumber();

        //private string GeneratePublicOrderNumber()
        //{
        //    using (SHA256 sha256 = SHA256.Create())
        //    {
        //        byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(OrderId.ToString()));
        //        ulong numericValue = BitConverter.ToUInt64(hashBytes, 0) % 1000000000000; 
        //        return numericValue.ToString("D12");
        //    }
        //}
    }
}
