class TarifasHoteleras{
    //Propiedades de la clase
    public int diasEstadia { get; set; }
    public int TarifaIndividual = 2500;
    public int TarifaDoble = 4600;
    public int TarifaFamiliar = 5200;

    //Metodos de la clase
    //Metodo para calcular el costo de la estadia de una tarifa individual
    public double CalcularIndividual(int diasHospedaje){
        //Se calcula el precio básico de la estadia multiplicando los días por la tarifa seleccionada
        double CostoEstadiaNoIVA = (diasHospedaje * TarifaIndividual);
        //Se calcula el precio de la estadia sumandole el 19% del IVA
        double CostoEstadiaIVA =  CostoEstadiaNoIVA + (CostoEstadiaNoIVA*0.19);
        //Se le aplica un descuento del 5% al precio con IVA
        double CostoFinal = CostoEstadiaIVA - (CostoEstadiaIVA*0.05);
        //Se retorna el precio final luego de las operaciones
        return CostoFinal;
    }
    //Metodo para mostrar el calculo del costo de la estadia de una tarifa individual
    public void PrintIndividual(){
        //Se trae el valor que retorna el metodo CalcularIndividual luego de realizar la operación
        double CostoEstadia = CalcularIndividual(diasEstadia);
        //Se imprime el resultado del calculo
        Console.WriteLine($"El costo de su estadía por {diasEstadia} dias es de {CostoEstadia}");
    }
    //Metodo para calcular el costo de la estadia de una tarifa doble
    public double CalcularDoble(int diasHospedaje){
        //Se calcula el precio básico de la estadia multiplicando los días por la tarifa seleccionada
        double CostoEstadiaNoIVA = (diasHospedaje * TarifaDoble);
        //Se calcula el precio de la estadia sumandole el 19% del IVA
        double CostoEstadiaIVA =  CostoEstadiaNoIVA + (CostoEstadiaNoIVA*0.19);
        //Se le aplica un descuento del 5% al precio con IVA
        double CostoFinal = CostoEstadiaIVA - (CostoEstadiaIVA*0.09);
        //Se retorna el precio final luego de las operaciones
        return CostoFinal;
    }
    //Metodo para mostrar el calculo del costo de la estadia de una tarifa doble
    public void PrintDoble(){
        //Se trae el valor que retorna el metodo CalcularIndividual luego de realizar la operación
        double CostoEstadia = CalcularDoble(diasEstadia);
        //Se imprime el resultado del calculo
        Console.WriteLine($"El costo de su estadía por {diasEstadia} dias es de {CostoEstadia}");
    }
    
}