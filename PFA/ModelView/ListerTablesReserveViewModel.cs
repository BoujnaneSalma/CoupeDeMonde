﻿using AuthSystem.Models;
using PFA.Models;

namespace PFA.ModelView
{
    public class ListerTablesReserveViewModel
    {
        public string PhotoPath { get; set; }
        public List<Reservation> reservations { get; set; }
        public User user { get; set; }

        
    }
}
