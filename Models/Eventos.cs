using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBancoDeDados.Models
{
    [Table("Eventos")]
    public class Eventos
    {
        [Column("EventosId")]
        [Display(Name = "Código do Evento")]

        public int Id { get; set; }

        [Column("NomeEventoId")]
        [Display(Name = "Nome do Evento")]

        public string NomeEventos { get; set; } = string.Empty;

        [Column("DataEventoId")]
        [Display(Name = "Data do Evento")]

        public DateTime DataEvento { get; set; } = DateTime.MinValue;

        [Column("DescricaoId")]
        [Display(Name = "Descrição do Evento")]

        public string DescricaoId { get; set; } = string.Empty;
    }
}