using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaskataDDD.Infrastructure.Notifications
{
    public class Notification
    {
        public Notification() { 
        
        }

        [NotMapped]
        public string NameProperty { get; set; }
        [NotMapped]
        public string Message {  get; set; }
        [NotMapped]
        public List<Notification> Notifications { get; set; }

        public Boolean ValidatPropertyString(string value, string nameProperty)
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifications.Add(new Notification()
                {
                    Message = "Obrigatory Field!",
                    NameProperty = nameProperty
                });

                return false;
            }

            return true;
        }

        public Boolean ValidatPropertyDecimal(decimal value, string nameProperty)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifications.Add(new Notification()
                {
                    Message = "value cannot be 0",
                    NameProperty = nameProperty
                });

                return false;
            }

            return true;
        }
    }
}
