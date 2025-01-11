using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_grade_management.Models
{
    class Alumno
    {
        public string Name { get; set; }

        public List<float> grades = new();

        public string addName()
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            return Console.ReadLine();
        } 

        public List<float> addGrade(int numPruebas)
        {
            Console.WriteLine("Ingrese las notas de las pruebas: ");

            List<float> newGreades = new();

            for (int i = 1; i <= numPruebas; i++)
            {
                Console.Write($"Prueba Nro{i}: ");
                var inputGrade = Console.ReadLine();
                if (float.TryParse(inputGrade, out float result))
                {
                    newGreades.Add(result);
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }

            }

            return newGreades;
        }

        public float GetAverage()
        {
            float gradesSumados = 0;
            foreach (float grade in grades)
            {
                gradesSumados += grade;
            }



            return gradesSumados / grades.Count();
        }
    }
}
