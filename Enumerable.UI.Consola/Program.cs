using Enumerable.UI.Consola;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("============================================");
        Console.WriteLine("Enumerable");
        Console.WriteLine("============================================");
        Console.WriteLine("\n **Lista**     list<T>");
        #region Lista
        var lista = new List<Alumnos>{
            new Alumnos{Matricula=23030396, Nombre="Ingrid", Edad=19},
            new Alumnos{Matricula=23030286, Nombre="Aneth", Edad=19},
            new Alumnos{Matricula=23030397, Nombre="Cesar", Edad=19},
            new Alumnos{Matricula=23030309, Nombre="Pris", Edad=19},
            new Alumnos{Matricula=23030312, Nombre="Alexis", Edad=19},
            new Alumnos{Matricula=23030398, Nombre="Uriel", Edad=19},
            new Alumnos{Matricula=23030334, Nombre="Gonza", Edad=19},
            new Alumnos{Matricula=23030389, Nombre="Jessi", Edad=19},
            new Alumnos{Matricula=23030366, Nombre="Juan", Edad=20},

            /*"Juan",
            "Juan",
            "Juan",
            "Juan",
            "Juan",
            "Juan",
            "Juan",
            "Juan",
            "Juan"*/
        };

        lista=lista.OrderBy(x => x.Nombre).ToList();
        //lista.Sort();

        for (int i = 0; i < lista.Count; i++) { 
            Console.WriteLine(lista[i]);
        }
        /*lista.Add("Juan");
        lista.Add("Jose");
        lista.Add("Luis");
        lista.Add("Ileny");
        lista.Add("Karla");
        lista.Add("Casco");
        lista.Add("Mitzi");
        lista.Add("Isabel");
        lista.Add("Zuri");

        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
        //Console.WriteLine();*/

        #endregion

        Console.ReadKey();
    }
}