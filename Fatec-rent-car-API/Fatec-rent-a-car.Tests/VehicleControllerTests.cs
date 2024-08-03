using Fatec_rent_car_API;
using Fatec_rent_car_API.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace Fatec_rent_a_car.Tests
{
    public class VehicleControllerTests
    {
        VehicleController subject;
        Mock<IVehicleRepository> repositorio;
        public VehicleControllerTests()
        {
            repositorio = new Mock<IVehicleRepository>();

            subject = new VehicleController(
                Mock.Of<ILogger<VehicleController>>(),
                repositorio.Object
            );

        }

        [Fact]
        public async Task GET_retorna_uma_lista_de_veiculos()
        {
            
            //ACT [agir]
            var veiculos = await subject.Get();

            // ASSERT [validar]
            Assert.IsAssignableFrom<IEnumerable<Vehicle>>(veiculos);
        }

        [Fact]
        public async Task GET_retorna_a_lista_retornada_do_repositorio()
        {
            // ARRANGE
            var esperado = new List<Vehicle>();
            repositorio.Setup(r => r.GetAll()).ReturnsAsync(esperado);
           
            //ACT [agir]
            var veiculos = await subject.Get();

            // ASSERT [validar]
            Assert.Same(esperado.AsEnumerable(), veiculos);
        }
    }


    
}