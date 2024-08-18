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
