using System.Data;

namespace Fatec_rent_car_API
{
    public interface IDbContext
    {
        IDbConnection GetConnection();
    }
}
