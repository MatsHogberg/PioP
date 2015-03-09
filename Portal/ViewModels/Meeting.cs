
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioPortal.ViewModels
{
    public class Meeting
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public DateTime StartTime { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public Site Site { get; set; }
    }
}
