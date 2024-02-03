using KaskataDDD.Infrastructure.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaskataDDD.Infrastructure.Entities
{
    [Table("TB_NEWS")]
    public class News : Notification
    {
        [Column("NWS_ID")]
        public int Id { get; set; }
        [Column("NWS_TITLE")]
        public string Title { get; set; }
        [Column("NWS_DESCRIPTION")]
        public string Description { get; set; }
        [Column("NWS_STATUS")]
        public Boolean Status { get; set; }
        [Column("NWS_DATE_CREATED")]
        public DateTime Created { get; set; }
        [Column("NWS_DATE_UPDATE")]
        public DateTime Updated { get; set; }

    }
}
