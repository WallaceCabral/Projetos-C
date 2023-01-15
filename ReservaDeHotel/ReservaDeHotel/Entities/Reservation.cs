using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaDeHotel.Entities.Exceptions;

namespace ReservaDeHotel.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { 
        }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DominioExceptions("Error na reserva: a data de checkout precisa ser apos a data de checkin");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DominioExceptions("ERROR NA RESERVA: As datas da reserva,precisam ser datas futuras");
            }
            if (checkout <= checkin)
            {
                throw new DominioExceptions("Error na reserva: a data de checkout precisa ser apos a data de checkin");
            }

            Checkin = checkout;
            Checkout = checkin;
        }
        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", CheckIn: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", Checkout: "
                + Checkout.ToString("dd/MM/yyyy")   
                + ", "
                + Duration()
                + " Nights";
        }



    }
}
