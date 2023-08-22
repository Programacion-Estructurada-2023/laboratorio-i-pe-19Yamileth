using System; 

namespace MyApp// Laboraorio 1 PE
{
    internal class Program
    {
         static void Main(string[] args)
        {
             // PARTE 1. Realizar la declaración y asignación de valores
             Console.WriteLine("Inicio");
            string? departamento, municipio, ciudad;
            Console.Write("Ingrese el nombre del departamento: ");
            departamento = Console.ReadLine();
            Console.Write("Ingrese el nombre del municipio: ");
            municipio = Console.ReadLine();
            Console.Write("Ingrese el nombre de la ciudad: ");
            ciudad = Console.ReadLine();

        //Declaración de dos variables de tipo texto capturando su valor desde consola
            string colonia = "Santa María";
            string colorCasa = "Blanca";

         //Declaración de dos variables enteras
            int aniosResidencia, edadActual;
            Console.Write("Ingrese los años de vivir en su residencia actual: ");
            aniosResidencia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su edad actual: ");
            edadActual = Convert.ToInt32(Console.ReadLine());

            DateTime fechanacimiento = new DateTime(2002, 12, 22); 
            DateTime fechaActual = DateTime.Now;
          // PARTE 2. Realizar asignación de funciones
            
            Console.WriteLine("\nFunciones para cadenas de textos:");
            Console.WriteLine($"Comparación de cadenas: {string.Compare(colonia, colorCasa)}");
            Console.WriteLine($"Concatenación de texto: {string.Concat(colonia, colorCasa)}");
            Console.WriteLine($"Mayúsculas: {colonia.ToUpper()}");
            Console.WriteLine($"Limpiado de cadena: {colonia.Trim()}");
            Console.WriteLine($"Longitud de cadena (colonia): {colonia.Length}");
            Console.WriteLine($"Longitud de cadena (colorCasa): {colorCasa.Length}");

            // Funciones para fechas
            Console.WriteLine("\nFunciones con Fechas:");
            Console.WriteLine($"Fecha de nacimiento formateada: {fechanacimiento.ToString("dd/MM/yyyy")}");
            DateTime fechanacimientoMas2Semanas = fechanacimiento.AddDays(14);
            DateTime fechaActualMas2Semanas = fechaActual.AddDays(14);
            Console.WriteLine($"Fecha de nacimiento + 2 semanas: {fechanacimientoMas2Semanas.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Fecha actual + 2 semanas: {fechaActualMas2Semanas.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Comparación de fechas: fechaNacimiento > fechaActual: {fechanacimiento > fechaActual}, fechaNacimiento < fechaActual: {fechaNacimiento < fechaActual}");

            // PARTE 3. Impresión de valores en consola
            Console.WriteLine("\nValores ingresados:");
            Console.WriteLine($"Departamento: {departamento}");
            Console.WriteLine($"Municipio: {municipio}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Colonia: {colonia}");
            Console.WriteLine($"Color de casa: {colorCasa}");
            Console.WriteLine($"Años de residencia: {aniosResidencia}");
            Console.WriteLine($"Edad actual: {edadActual}");
            Console.WriteLine($"Fecha de nacimiento: {fechanacimiento}");
            Console.WriteLine($"Fecha actual: {fechaActual}");
            //Auto evaluacion NOTA:8.
        }
    }
}