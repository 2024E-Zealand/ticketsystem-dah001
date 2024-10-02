namespace TicketClassLibrary
{
    public class Car
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
        /// Returnerer en fast pris på bilen.
        /// </summary>
        /// <returns>Prisen for bilen, er 240.</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returnerer bilens køretøjstype.
        /// </summary>
        /// <param name="car">En bil-instans, som repræsenterer køretøjet.</param>
        /// <returns>En streng, der angiver køretøjstypen som "Car".</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
