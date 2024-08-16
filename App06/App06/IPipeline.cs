namespace App06
{
    /*
    Interfaz generica que recibe dos argumentos, el primer argumento representa lo que
    lo que le entrega el usuario al programa (El input), el segundo argumento representa
    el resultado que se va a devolver cuando se ejecute el metodo (El output).
    */
    public interface IPipeline<TInput, TOutput> 
        where TInput : BaseRequest
        where TOutput : IDisposable, new()
    {
        TOutput EjecutarTarea(TInput request);
    }
}
