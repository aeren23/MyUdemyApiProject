﻿namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class UpdateBookingDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Checkin { get; set; }
        public string CheckOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildCount { get; set; }
        public string RoomCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
