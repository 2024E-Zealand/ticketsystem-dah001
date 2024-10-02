using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Repræsenterer nummerpladen for bilen.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Repræsenterer datoen for bilen, fx registreringsdato.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Abstrakte metoder som skal implementeres i de afledte klasser
        /// </summary>
        /// <returns></returns>
        public abstract double Price();
        public abstract string VehicleType();

    }
}
