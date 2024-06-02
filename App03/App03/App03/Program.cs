using App03;

var objeto = new ClassFuncion();

MiDelegate f = objeto.func1;
Console.WriteLine($"El resultado es {f(10, 100)}");

public delegate string MiDelegate(int arg1, int arg2);