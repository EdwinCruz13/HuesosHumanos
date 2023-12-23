// See https://aka.ms/new-console-template for more information
using HuesosHumanos;

public class Program
{
    /// <summary>
    /// Iniciar el programa a traves del método main
    /// </summary>
    static void Main()
    {

        Console.WriteLine("Initalizing program....");


        //crear objeto
        Esqueleto esqueleto = new Esqueleto();
        esqueleto.AgregarHueso(new Hueso { Nombre = "hueso 1", Peso = 2, Densidad = 1.1, Longitud = 10, Diametro = 1});
        esqueleto.AgregarHueso(new Hueso { Nombre = "hueso 2", Peso = 15, Densidad = 1.5, Longitud = 0.1, Diametro = 2 });
        esqueleto.AgregarHueso(new Hueso { Nombre = "hueso 3", Peso = 1, Densidad = 1.1, Longitud = 5, Diametro = 78 });
        esqueleto.AgregarHueso(new Hueso { Nombre = "hueso 4", Peso = 8, Densidad = 0.1, Longitud = 7, Diametro = 5 });


        Console.WriteLine("");

        Console.WriteLine("Imprimiendo.....");
        esqueleto.Imprimir(); //imprimir la lista de huesos

        Console.WriteLine("");

        //ordenar de acuerdo a un criterio
        Console.WriteLine("Ordenando de acuerdo al criterio peso.....");
        esqueleto.Ordenar("Peso");
        esqueleto.Imprimir();

        //ordenar de acuerdo a un criterio
        Console.WriteLine("");
        Console.WriteLine("Ordenando de acuerdo al criterio densidad.....");
        esqueleto.Ordenar("Densidad");
        esqueleto.Imprimir();

        //ordenar de acuerdo a un criterio
        Console.WriteLine("");
        Console.WriteLine("Ordenando de acuerdo al criterio diámetro.....");
        esqueleto.Ordenar("Diametro");
        esqueleto.Imprimir();


        //ordenar de acuerdo a un criterio
        Console.WriteLine("");
        Console.WriteLine("Ordenando de acuerdo al criterio Longitud.....");
        esqueleto.Ordenar("Longitud");
        esqueleto.Imprimir();

        //ordenar de acuerdo a un criterio erroneo
        Console.WriteLine("");
        Console.WriteLine("Ordenando de acuerdo al criterio erroneo.....");
        esqueleto.Ordenar("erroneo");

    }
}
