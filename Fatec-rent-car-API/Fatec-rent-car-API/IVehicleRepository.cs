namespace Fatec_rent_car_API
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAll();
    }
}
