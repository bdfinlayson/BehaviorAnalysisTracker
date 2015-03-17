﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BAT.Models
{
    public class Participant
    {
        public Participant(int participantID, int sessionId, int collaborator)
        {
            this.SessionID = sessionId;
            this.Collaborator = collaborator;
        }
        
        public Participant() { }

        //a participant must be associated with a SessionID
        [Required]
        public int SessionID { get; set; }

        [ForeignKey("SessionID")]
        public virtual Session Session { get; set; }

        [Required]
        public int Collaborator { get; set; }

        //a Participant may appear on a Session
        public int ParticipantID { get; set; }

        //Other models may access participants
        public ICollection<Participant> Participants { get; set; }
    }
}