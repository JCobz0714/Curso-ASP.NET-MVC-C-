namespace App06
{
    public class ClienteProcessor : IProcessor<Cliente>
    {
        public void Process(Cliente input)
        {
            Console.WriteLine($"Processing Cliente: {input}");
        }
    }
}
