using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fatec_rent_car_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> logger;
        private readonly IVehicleRepository repository;

        public VehicleController(ILogger<VehicleController>logger, IVehicleRepository repository) 
        {
            this.logger = logger;
            this.repository = repository;

        }

        [HttpGet]
        public async Task<IEnumerable<Vehicle>> Get()
        {
            logger.LogInformation("Get executado com sucesso");

            return await repository.GetAll();                

           
        }
    }
}
