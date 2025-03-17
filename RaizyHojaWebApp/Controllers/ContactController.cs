using Microsoft.AspNetCore.Mvc;
using RaizyHojaWebApp.Data;
using RaizyHojaWebApp.Models;

namespace RaizyHojaWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Inyección de dependencias del contexto
        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Acción para procesar el formulario de contacto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitContactForm(ContactFormIndex contactForm)
        {
            if (ModelState.IsValid)
            {
                // Guardar el formulario en la base de datos
                _context.ContactForms.Add(contactForm);
                _context.SaveChanges();

                // Usar SweetAlert para mostrar el mensaje de éxito
                TempData["SuccessMessage"] = "¡Gracias por tu mensaje! Nos pondremos en contacto pronto.";

                // Redirigir al Home o a la misma página de contacto
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Si hay un error en el modelo, regresar a la vista con los errores
                TempData["ErrorMessage"] = "Hubo un error al enviar el formulario. Inténtalo de nuevo.";
                return RedirectToAction("Index", "Home");
            }
        }
    }
}