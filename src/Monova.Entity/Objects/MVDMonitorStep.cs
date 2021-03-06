using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monova.Entity
{
    [Table("MonitorStep")]
    public class MVDMonitorStep
    {
        [Key]
        public Guid MonitorStepId { get; set; }
        public Guid MonitorId { get; set; }
        public MVDMonitorStepTypes Type { get; set; }
        public string Settings { get; set; }
    }

    public enum MVDMonitorStepTypes : short
    {
        Request = 1,
        StatusCode = 2,
        HeaderExits = 3,
        BodyContains = 4
    }
}