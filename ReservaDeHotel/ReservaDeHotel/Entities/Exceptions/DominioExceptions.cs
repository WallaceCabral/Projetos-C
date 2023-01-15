using System;


namespace ReservaDeHotel.Entities.Exceptions
{
   class DominioExceptions: ApplicationException
    {
        public DominioExceptions(string messagem) : base(messagem)
        {

        }
    }
}
