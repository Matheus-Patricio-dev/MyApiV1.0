using Microsoft.AspNetCore.Mvc;
using myApi.model;
using myApi.ViewModel;

namespace myApi.Controllers
{
    [ApiController]
    [Route("api/v1/fabricantes")]
    public class FabricanteController : ControllerBase
    {
        private readonly IFabricantesRepository _fabricanteRepository;

        public FabricanteController(IFabricantesRepository fabricanteRepository)
        {
            _fabricanteRepository = fabricanteRepository ?? throw new ArgumentNullException();
        }


        [HttpPost]
        public IActionResult Add(FabricanteViewModel fabricanteView)
        {
            var fab = new Fabricante(fabricanteView.ID, fabricanteView.Nome, fabricanteView.Pais_og);
            _fabricanteRepository.add(fab);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get(FabricanteViewModel fabricanteView)
        {
            var fab = _fabricanteRepository.Get();
            return Ok(fab);
        }

    }
}
