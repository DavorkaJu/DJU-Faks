using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace NBATeams.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Player")]

        [Required]
        public String Name { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }

        public Team Team { get; set; }

        public String Position { get; set; }

        public int Age { get; set; }

  
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Height { get; set;}

        public int Weight { get; set; }
        public String College { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Points { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Rebounds { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Assists { get; set; }



    }

}
       
