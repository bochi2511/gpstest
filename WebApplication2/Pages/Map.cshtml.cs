using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models.EnaexGPS;

namespace WebApplication2.Pages
{
    public class MapModel : PageModel
    {
        private readonly WebApplication2.Models.EnaexGPS.EnaexGPSContext _context;

        public MapModel(WebApplication2.Models.EnaexGPS.EnaexGPSContext context)
        {
            _context = context;
        }

        public IList<EnaexEventosGpsfull> EnaexEventosGpsfull { get; set; }
        public async Task OnGetAsync()
        {
            var eventos = from m in _context.EnaexEventosGpsfull
                          where m.CodVehiculo == 155592 && m.FechaHora > DateTime.UtcNow.AddDays(-1)
                          select m;
            
            
            EnaexEventosGpsfull = await eventos.ToListAsync();

            foreach (var eventito in EnaexEventosGpsfull)
            {
                Debug.WriteLine(eventito.FechaHoraActividadConFormato.ToString() + " prueba");
            }
        }
    }
}