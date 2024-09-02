public static class Diccionario{

    public static void Run(){
        Dictionary<string, string> idioma = new Dictionary<string, string>();

        //Agregar palabras al diccionario
        idioma.Add("Tiempo", "Time");
        idioma.Add("Persona", "Person");
        idioma.Add("Año", "Year");
        idioma.Add("Día", "Day");
        idioma.Add("Mundo", "World");
        // idioma.Add("life", "vida");
        // idioma.Add("woman", "mujer");
        // idioma.Add("work", "trabajo");
        // idioma.Add("week", "semana");
        // idioma.Add("place", "lugar");

        
        //Agregar frase al diccionario
        //string clave = "Este día es hermoso, depende mucho del ojo que lo ve";
        //string valor = "Este day es hermoso, depende mucho del eye que lo ve";

        System.Console.WriteLine("Ingrese una clave y un valor al diccionario");

        //Agregar datos al diccionario
        System.Console.WriteLine("Ingrese una clave");
        string? clave = Console.ReadLine();
        System.Console.WriteLine("Ingrese un valor");
        string? valor = Console.ReadLine();
        
        //ContainsKey comprobar si una frase ya existe
        if(idioma.ContainsKey(clave)){
            System.Console.WriteLine("La frase ya existe");
        }else{
            idioma.Add(clave, valor);
        }

        
        //Traductor
        System.Console.WriteLine("Ingrese una frase a traducir");
        string? texto = Console.ReadLine();

        string[] palabras = texto.Split(" ");
        string textoTraducido = string.Empty;
        string textoBuscado = string.Empty;

        // //imprimir contenido del diccionario
        // foreach (var item in idioma)
        // {
        //     System.Console.WriteLine(item);
        // }

        foreach (var item in palabras){
            textoBuscado = item;

            if(idioma.ContainsKey(item)){
                // System.Console.WriteLine("palabra encontrada en el diccionario " + item);
                textoBuscado = idioma[item];
            }
            textoTraducido = textoTraducido + " " + textoBuscado;
        }
        
        System.Console.WriteLine(textoTraducido);
    }
}
