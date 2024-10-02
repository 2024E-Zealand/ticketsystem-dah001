using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC:Vehicle
    {
        /// <summary>
        /// Returnerer en fast pris på MC.
        /// </summary>
        /// <returns>Prisen for MC, er 125.</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returnerer MC køretøjstype.
        /// </summary>
        /// <param name="MC">En MC-instans, som repræsenterer køretøjet.</param>
        /// <returns>En streng, der angiver køretøjstypen som "MC".</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
