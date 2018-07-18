using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using www_ROCholet.Models;

namespace www_ROCholet.Models
{
    public class EquipeModels
    {
        public int IdEquipe { get; set; }
        public string LibelleEquipe { get; set; }

        public virtual ClubModels Club { get; set; }
        public virtual AgendaModels Agenda { get; set; }
    }
}