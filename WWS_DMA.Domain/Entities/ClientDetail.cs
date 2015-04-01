using System;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WWS_DMA.Domain.Entities
{
    public class ClientDetail
    {
        [Key]
        public int ClientID { get; set; }

        [MaxLength(20), MinLength(2)]
        public string Name { get; set; }

        [MaxLength(30), MinLength(2)]
        public string Country { get; set; }
    }
}
