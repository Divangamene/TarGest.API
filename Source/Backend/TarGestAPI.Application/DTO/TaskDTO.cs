using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarGestAPI.Application.DTO
{
    public class TaskDTO
    {
        public int idTask { get; set; }
        public string descriptionTask { get; set; } = string.Empty;
        public string titleTask { get; set; } = string.Empty;
        public DateTime timeStartTask { get; set; } = DateTime.Now;

    }
}
