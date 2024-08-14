namespace App05
{
    public class AutorPrinterService
    {
        private readonly IRepository<Estudiante> _autorRepository;

        public AutorPrinterService(IRepository<Estudiante> autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public void PrintAutores()
        {
            var autores = _autorRepository.List();
            Array.Sort(autores);

            Console.WriteLine("Imprimiendo lista de Autores desde el metodo PrintAutores: ");

            for (int i = 0; i < autores.Length; i++)
            {
                Console.WriteLine(autores[i]);
            }
        }
    }
}
