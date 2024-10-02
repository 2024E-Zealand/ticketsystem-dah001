using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TicketClassLibrary
{
    public abstract class Vehicle
    {
        private string _licenseplate;
        /// <summary>
        /// Repræsenterer nummerpladen for bilen, som´ikke kan være længere end 7 tegn.
        /// </summary>
        public string Licenseplate
        {
            get { return _licenseplate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Licenseplate må ikke være null og må ikke være længere end 7 tegn langt");
                }
                _licenseplate = value;
            }
        }

        /// <summary>
        /// Repræsenterer datoen for bilen, fx registreringsdato.
        /// </summary>
        public DateTime Date { get; set; }

        // Nyt egenskab for at indikere om Brobizz anvendes
        public bool HasBrobizz { get; set; } = false;

        /// <summary>
        /// Abstrakte metoder som skal implementeres i de afledte klasser
        /// </summary>
        /// <returns></returns>
        public abstract double Price();
        public abstract string VehicleType();

    }
}
