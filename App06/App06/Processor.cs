namespace App06
{
    public class Processor<T> : IProcessor<T>
    {
        public void Process(T input)
        {
            Console.WriteLine($"Generic class processor {input}");
        }
    }

    public record Cliente(string nombre, string apellido);
}
