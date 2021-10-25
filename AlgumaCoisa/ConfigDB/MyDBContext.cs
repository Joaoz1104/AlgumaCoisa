using System;
using AlgumaCoisa.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AlgumaCoisa.ConfigDB
{
    class MyDBContext: DbContext
    {
        DbSet<Evento> Eventos { get; set; }
        DbSet<Status> Statuses { get; set; }
    }
}