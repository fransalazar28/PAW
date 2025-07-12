using PAW.Models;
using PAW.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW.Core.Extensions
{
    public static class EntityExtensions
    {
        public static void AddAudit(this  IEntity entity, string user)
        {
            if (entity.IsDirty)
            {
               if  (entity.TempID <= 0)
                {
                    entity.CreatedDate = DateTime.Now;
                    entity.CreatedBy = user;
                }
                else
                {
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedBy = user;
                }
            }

        }
        public static void AddLogging(this IEntity entity, LoggingType loggingType)
        {

            if (loggingType == LoggingType.Create)
            {
                Debug.WriteLine("Creating object!");
                return;
            }

            if (loggingType == LoggingType.Update)
            {
                Debug.WriteLine("Updating object!");
                return;
            }

            if (loggingType == LoggingType.Delete)
            {
                Debug.WriteLine("Deleting object!");
                return;
            }

            if (loggingType == LoggingType.Read)
            {
                Debug.WriteLine("Reading object!");
                return;
            }

        }
    }
}
