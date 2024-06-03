using App03;

var objeto = new ClassFuncion();

MiDelegate f = objeto.func1;
Console.WriteLine($"El resultado es {f(10, 100)}");

f = objeto.func2;
Console.WriteLine($"El resultado es {f(56, 78)}");

var objeto2 = new MiClase();
f = objeto2.InstanciaDeMetodo;
Console.WriteLine($"El resultado de la formula es {f(89, 100)}");

public delegate string MiDelegate(int arg1, int arg2);