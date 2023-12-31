//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public double CostoTotal {get; set;}

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        /*public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
        */
        public void GetProductionCost()                                            
        {
            double SumaCostosIng=0;
            double SumaCostosEquip=0;
            
            foreach (Step step in this.steps)
            {
                SumaCostosIng=+ step.Input.UnitCost*step.Quantity;
                SumaCostosEquip=+ (step.Time/60)*step.Equipment.HourlyCost;
            }
            this.CostoTotal= SumaCostosEquip+SumaCostosIng;
            
        }
    }
}