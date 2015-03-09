using System;
using System.Collections.Generic;

namespace PioPortal.ViewModels
{
    public class Project
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string  Name { get; set; }

        public Customer Customer { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Manager BusinessManager { get; set; }

        public Manager ProjectManager { get; set; }

        public List<Meeting> Meetings { get; set; }

        public Site Site { get; set; }

        public int? AdminLevel { get; set; }

    }
}
