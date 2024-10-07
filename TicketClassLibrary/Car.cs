namespace TicketClassLibrary
{
    public class Car : Vehicle
    {

        /// <summary>
        /// Returnerer en fast pris på bilen.
        /// </summary>
        /// <returns>Prisen for bilen, er 240, uden brobizz, med brobizz får man yderligere 5%.</returns>
       
        public override double Price()
        {
            return 240;
        }

        public double WeekendDiscount()
        {
            var price = Price();

            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)

            {
                price *= 0.80;
            }

            if (HasBrobizz)
            {
                price *= 0.95;
            }

            return price;
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
