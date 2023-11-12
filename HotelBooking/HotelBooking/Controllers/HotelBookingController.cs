using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HotelBooking.Model;
using HotelBooking.Data;
using Microsoft.Extensions.Logging;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HotelBookingController : ControllerBase
    {
        private readonly ILogger<HotelBookingController> _logger;
        private readonly ApiContext _context;

        public HotelBookingController(ApiContext context, ILogger<HotelBookingController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Create/Edit
        [HttpPost]
        public IActionResult CreateEdit([FromBody] HotelBookingg booking)
        {
            try
            {
                if (booking.Id == 0)
                {
                    _context.Bookings.Add(booking);
                }
                else
                {
                    var bookingInDb = _context.Bookings.Find(booking.Id);
                    if (bookingInDb == null)
                        return NotFound();

                    // Update individual properties
                    bookingInDb.ClientName = booking.ClientName;
                    bookingInDb.RoomNumber = booking.RoomNumber;
                    // ...

                    // Alternatively, you can use a library like AutoMapper for property mapping
                }

                _context.SaveChanges();

                return Ok(booking);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in CreateEdit: {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        // Get
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _context.Bookings.Find(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _context.Bookings.Find(id);

            if (result == null)
                return NotFound();

            _context.Bookings.Remove(result);
            _context.SaveChanges();

            return NoContent();
        }

        // Get all
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _context.Bookings.ToList();

            return Ok(result);
        }
    }
}
