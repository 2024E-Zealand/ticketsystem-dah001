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
        /// Returnerer en fast pris på MC 125 kr.
        /// </summary>
        /// <returns>Prisen for MC, er 125.</returns>
        public override double Price()
        {
            double basePrice = 125;

            // Giv 5% rabat, hvis Brobizz bruges
            if (HasBrobizz)
            {
                basePrice *= 0.95; // 5% rabat
            }

            return basePrice;
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
