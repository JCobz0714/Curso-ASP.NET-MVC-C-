using App04;

var documento = new Documento("Jacobo Osorio");

//Llamando los metodos de la subclase documento, que hereda de la interfaz o clase
//padre "IOperaciones"
/*
documento.Cargar();
documento.Guardar();
documento.NecesitaGuardar();
*/

//INTERFACES Y EL CASTING ENTRE LAS DIFERENTES INTERFACES Y CLASES
/*
Se tienen tres clases: Clase A, subclase B y subclase C. La subclase C
hereda de la subclase B, y la subclase B hereda de la clase A. Si se tiene
lo siguiente:

void Method(){
  B obj = new B();
}

if(obj is B){} //Retorna true

if(obj is A){} //Retorna true

if(obj is C){} //Retorna false, porque C es la clase hija o subclase de la
clase B

COMO REDEFINIR O CASTEAR LA IDENTIDAD DE UN OBJETO CON OTRO
A obj2 = obj as A //obj2 es A
C obj2 = obj as C //obj2 es Null, porque no comparte nada de B que
pertenece a C
*/

//Si documento es de tipo "IOperaciones", que se ejecute el metodo guardar
//Cuando se quiera comparar si un objeto pertenece a una determinada clase
//o interface, se utiliza el operador "is"
if(documento is IOperaciones){
  document.Guardar();
}

//Si se quiere transformar o castear un objeto a un tipo de dato
//determinado (interfaz o clase), se tiene que utilizar el operador "as".
//Si la transformacion o casteo es correcto, "ioperaciones" sera distinto
//de nulo. Si el casteo no cumple las reglas logicas de implementacion o
//herencia entre clases o interfaces, entonces sera un Null.
//Este casteo es para que el objeto "documento" no venga de la clase
//"Documento", sino que venga directamente de la interfaz "IOperaciones".
IOperaciones ioperaciones = documento as IOperaciones;

if(ioperaciones is not null){
  ioperaciones.Cargar();
}

//AGREGANDO VARIAS INTERFACES A UNA SOLA SUBCLASE O CLASE HIJO
documento.EnviarNotification();
documento.EnviarMensajeTexto();
documento.EnviarEmail();

//Cualquier clase puede ser transformada o casteada a conveniencia para el
//codigo o proyecto que se este construyendo.
IMensajeria imensajeria = documento as IMensajeria;
imensajeria.EnviarMensajeTexto();