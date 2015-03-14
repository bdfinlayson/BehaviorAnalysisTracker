﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BAT.Models
{
    public class Participant
    {
        public int SessionID; //FK Session.ID
        public int UserID;
    }

    public class ParticipantsDbContext : DbContext
    {
        public DbSet<Participant> Participants { get; set; }
    }
}