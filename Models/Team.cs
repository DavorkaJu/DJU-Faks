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
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Team")]
        [Required]
        public String Name { get; set; }
       
    }
}
