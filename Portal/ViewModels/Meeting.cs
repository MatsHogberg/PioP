
using System;

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
