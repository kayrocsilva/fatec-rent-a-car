namespace Fatec_rent_car_API
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Categoria { get; set; }
        public string Modelo { get; set; }

        public int CapacidadePassageiros { get; set; }

        public string  Combustivel { get; set; }
        public decimal Preco {  get; set; }
    }
}
