using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLibrary.Model
{
    public class Ticket : AirlineObject
    {
        #region properties
        public decimal Cost { get; set; }
        public TicketType Type { get; set; }
        #endregion

        public override string[] TableHeader
        {
            get
            {
                return new string[]
                {
                    nameof(this.ID), nameof(this.Cost), nameof(this.Type) 
                };
            }
        }

        public override string[,] TableView
        {
            get
            {
                return new string[,]
                {
                    { TableHeader[0], this.ID.ToString() },
                    { TableHeader[1], this.Cost.ToString() },
                    { TableHeader[2], this.Type.ToString() },
                };
            }
        }

        public override bool IsValid() {
            return true;
        }
    }

    public enum TicketType
    {
        Business,
        Economy
    }
}
