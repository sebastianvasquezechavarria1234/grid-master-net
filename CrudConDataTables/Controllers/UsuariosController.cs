using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudConDataTables.Models;

namespace CrudConDataTables.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region API CALLS
        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            return Json(new { data = usuarios });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return Json(new { success = false, message = "Error al borrar" });
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Usuario borrado correctamente" });
        }
        #endregion

        // GET: Usuarios/Create o Edit
        public async Task<IActionResult> Upsert(int? id)
        {
            Usuario usuario = new Usuario();
            if (id == null)
            {
                // Create
                return View(usuario);
            }

            // Edit
            usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Id == 0)
                {
                    _context.Usuarios.Add(usuario);
                }
                else
                {
                    _context.Usuarios.Update(usuario);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
    }
}
