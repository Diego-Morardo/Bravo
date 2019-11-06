namespace Bravo.Modelo
{
    public class UnidadMovil
    {
        public int ID { get; set; }
        public string dominio { get; set; }
        public bool habilitada { get; set; }
        public int kilometraje { get; set; }
        public int kilometrajeInicial { get; set; }
        public bool requiereService { get; set; }
    }
}