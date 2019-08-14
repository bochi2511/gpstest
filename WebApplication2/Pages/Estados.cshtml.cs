using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models.EnaexGPS;

namespace WebApplication2.Pages
{
    public class EstadosModel : PageModel
    {
        private readonly WebApplication2.Models.EnaexGPS.EnaexGPSContext _context;

        public EstadosModel(WebApplication2.Models.EnaexGPS.EnaexGPSContext context)
        {
            _context = context;
        }

        public IList<EnaexEstados> EnaexEstados { get;set; }

        public async Task OnGetAsync()
        {
            EnaexEstados = await _context.EnaexEstados.ToListAsync();
        }
    }
}
