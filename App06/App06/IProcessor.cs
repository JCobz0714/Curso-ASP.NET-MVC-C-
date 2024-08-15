namespace App06
{
    public interface IProcessor<T>
    {
        void Process(T input);
    }
}
