namespace CRUDAPI.Models
{
    public class Carro
    {
        public int CarroId { get; set; }
        public double KmLitro { get; set; }
        public double Tempo { get; set; }
        public double VelocidadeMedia { get; set; }
        public double DistanciaPercorrida { get; set; }
        public double ConsumoCombustivel { get; set; }
    }
}