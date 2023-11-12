using HotelBooking.Model;
using HotelBooking.Data;

namespace HotelBooking.Data
{
    public class BookingFactory : IBookingFactory
    {
        public HotelBookingg CreateBooking()
        {
  
            return new HotelBookingg();
        }
    }
}
