using System;

namespace Teste.Models
{
    public class Competition
    {
        public int ID { get; set; }
        public int ApiId { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string Name { get; set; }
        public string CurrentSeasonId { get; set; }
        public string CurrentSeasonStartDate { get; set; }
        public string CurrentSeasonEndDate { get; set; }
        public string CurrentSeasonMatchDay { get; set; }
    }
}