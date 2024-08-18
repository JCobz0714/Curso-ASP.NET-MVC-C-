Base x = new Base();
Base y = new Derived();

x.EjecutarEnBase();
y.EjecutarEnBase();

Console.WriteLine();

//Llamada ilegal de metodo
//y.EjecutarEnDerivada();

Derived z = new Derived();
z.EjecutarEnDerivada();
z.EjecutarEnBase();

IProducer<Base> prodBase = null!;
Base bs = prodBase.Produce();

IProducer<Derived> prodDerived = null!;
Derived ds = prodDerived.Produce();
Base bs1 = prodDerived.Produce();

IConsumer<Base> consBase = null!;
consBase.Consume(new Base());
consBase.Consume(new Derived());

IConsumer<Derived> consDerived = null!;
consDerived.Consume(new Derived());

/*
La palabra reservada "out" es un indicativo que señala que se trata de un 
Covariant type, de un tipo covariante.

Cuando tenemos un parametro de tipo generico "out" que esta ingresando a una interfaz 
y dentro de ella se esta devolviendo a ese mismo objeto, se le llama de tipo covariant
*/
interface IProducer<out T>
{
    T Produce();
}

/*
La palabra reservada "in" indica de que el objeto esta ingresando al objeto interfaz,
este caso se le puede llamar un Contravariant type, un tipo contravariante.

Si esta ingresando un parametro de tipo in y esta siendo consumido como un parametro
dentro del metodo generico, entonces se le llama contravariant.
*/
interface IConsumer<in T>
{
    void Consume(T obj);
}

//Clase "Less-derived"
class Base 
{
    public void EjecutarEnBase() => Console.WriteLine($"Ejecutando desde {GetType().Name}");
}

//Clase "More-derived"
class Derived : Base 
{
    public void EjecutarEnDerivada() => Console.WriteLine($"Ejecutando derivada {GetType().Name}");
}
