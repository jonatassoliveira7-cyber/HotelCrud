using System.ComponentModel.DataAnnotations;

namespace HotelCrud.Models
{
    public class Hospede
    {
        public int id { get; set; }
    public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }


    }
}