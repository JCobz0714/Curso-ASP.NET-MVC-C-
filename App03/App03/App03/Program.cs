/*
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
*/

//Como es un delegate anonimo, puedo agregarle la logica que yo quiera
//Primero hay que definir el delegate antes de declararlo
//Un delegate anonimo es un delegate al cual no se le agrega la logica
//de un metodo ya existente, sino que tiene su propia logica
MiDelegado f = delegate (int i, string s)
{
    return i + 100;
};

//Llamando al delegate
int resultado = f(250, "Es Jacobo Osorio");

//Delegates anonimos
public delegate int MiDelegado(int i, string s);