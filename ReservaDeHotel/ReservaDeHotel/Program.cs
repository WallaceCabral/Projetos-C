using ReservaDeHotel.Entities;
using ReservaDeHotel.Entities.Exceptions;


//Programa principal onde será inserido os dados  do numero do quarto,data de entrada e saida .
try
{
    Console.Write("Room number: ");
    int roomNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Entre com a data que deseja reservar");
    Console.Write("Check -in date(dd / MM / yyyy): ");
    DateTime checkin = DateTime.Parse(Console.ReadLine());

    Console.Write("Check -out date(dd / MM / yyyy): ");
    DateTime checkout = DateTime.Parse(Console.ReadLine());

    //Novo jeito de fazer
    Reservation reservation = new Reservation(roomNumber, checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();

    Console.WriteLine("Entre com a data que deseja reservar");
    Console.Write("Check -in date(dd / MM / yyyy): ");
    checkin = DateTime.Parse(Console.ReadLine());

    Console.Write("Check -out date(dd / MM / yyyy): ");
    checkout = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkin, checkout);
    Console.WriteLine("Reservation: " + reservation);
}
catch (DominioExceptions e)
{
    Console.WriteLine("Error na Reserva: "+e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Formato errado: "+ e.Message);
}
catch (Exception e )
{
    Console.WriteLine("Erro inesperado: "+ e.Message);
}