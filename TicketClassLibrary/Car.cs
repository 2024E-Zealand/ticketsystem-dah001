namespace TicketClassLibrary
{
    public class Car:Vehicle
    {
        
        /// <summary>
        /// Returnerer en fast pris på bilen.
        /// </summary>
        /// <returns>Prisen for bilen, er 240.</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returnerer bilens køretøjstype.
        /// </summary>
        /// <param name="car">En bil-instans, som repræsenterer køretøjet.</param>
        /// <returns>En streng, der angiver køretøjstypen som "Car".</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
