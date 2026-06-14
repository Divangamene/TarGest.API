using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarGestAPI.Domain.Entities.Enum;

namespace TarGestAPI.Domain.Entities
{
    public class Tasks
    {
        [Key]
        public int idTask { get; set; }
        public string descriptionTask { get; set; } = string.Empty;
        public string titleTask { get; set; } = string.Empty;
        public DateTime timeStartTask { get; set; }= DateTime.Now;


    }
}
