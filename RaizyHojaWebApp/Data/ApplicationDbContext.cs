//archivo de contexto para la base de datos
using Microsoft.EntityFrameworkCore;
using RaizyHojaWebApp.Models;

namespace RaizyHojaWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Modelo para los formularios de contacto
        public DbSet<ContactFormIndex> ContactForms { get; set; }

       
    }
}

