using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {

        public ConsolePrinter(Recipe receta)
        {
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}:");
            foreach (Step step in receta.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +           // Imprime cada paso de la receta 
                    $"usando '{step.Equipment.Description}' durante {step.Time}");              
            }

            Console.WriteLine($"El costo total de la receta es: {receta.CostoTotal}");   // Imprime el cossto de producción de la receta
        }

    }
}