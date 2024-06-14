using App04;

var documento = new Documento("Jacobo Osorio");

//Llamando los metodos de la subclase documento, que hereda de la interfaz o clase
//padre "IOperaciones"
documento.Cargar();
documento.Guardar();
documento.NecesitaGuardar();