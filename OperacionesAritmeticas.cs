class OperacionesAritmeticas{
    //Propiedades - Atributos
    public int numero_uno { get; set; }
    public int numero_dos { get; set; }
    //Metodos (Funciones o Acciones)
    public void sumar_num (){
        //Operaciones
        int Resultado = numero_uno + numero_dos;
        //Salida - Impresa o Return
        Console.WriteLine("El resultado de la suma es: " + Resultado);
    }
    public void restar_num (){
        //Operaciones
        int Resultado = numero_uno - numero_dos;
        //Salida - Impresa o Return
        Console.WriteLine("El resultado de la resta es: " + Resultado);
    }
    public void multiplicar_numeros (){
        int Resultado = numero_uno * numero_dos;
        Console.WriteLine("El resultado de la multiplicacion es: " + Resultado);
    }
    public void dividir_numeros (){
        int Resultado = numero_uno / numero_dos;
        Console.WriteLine("El resultado de la division es: " + Resultado);
    }
    //Metodo constructor - no se ve pero siempre se llama igual que la clase
}