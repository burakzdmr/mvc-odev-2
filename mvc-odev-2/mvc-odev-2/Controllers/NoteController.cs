using Microsoft.AspNetCore.Mvc;
using mvc_odev_2.Models;
using System.Diagnostics;

namespace mvc_odev_2.Controllers
{
    public class NoteController : Controller
    {
        private readonly ILogger<NoteController> _logger;

        public NoteController(ILogger<NoteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NoteAdd()
        {
            NoteModel noteModel = new NoteModel();
            noteModel.NoteDescription = "ben note descriptionıyım.";
            
            return View(noteModel);
        }

        public IActionResult NoteList()
        {
            return View();
        }

        public IActionResult NoteEdit()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}