using System;
using System.Collections.Generic;
using student_grade_management.Models;


class Program
{
    static void Main()
    {
        var alumno = new Alumno();

        List<Alumno> alumnos = new List<Alumno>();

        Console.WriteLine("Gestión de notas de estudiantes");
        Console.Write("Ingrese el número de pruebas realizadas: ");
        dynamic numPruebas = Console.ReadLine();

        if (int.TryParse(numPruebas, out int result))
        {
            numPruebas = result;
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }


        Console.WriteLine("Ingresar alumno: ");
        bool res = true;

        do
        {
            string name = alumno.addName();
            List<float> grades = alumno.addGrade(numPruebas);
            alumnos.Add(new Alumno { Name = name, grades = grades });


            Console.Write("Desea agregar otro alumno? 1.Si / 2.No: ");
            var input3 = Console.ReadLine();

            if (input3 == "2")
            {
                res = false;
            }
        } while (res);


        foreach (Alumno Ialumno in alumnos)
        {
            Console.WriteLine($"Alumno: {Ialumno.Name}.");
            Console.WriteLine($"Notas: {string.Join(", ", Ialumno.grades)}");
            Console.WriteLine($"Promedio: {Ialumno.GetAverage():F2}");
            Console.WriteLine($"Estado: {(Ialumno.GetAverage() >= 6 ? "Aprobado": "Desaprobado")}");
        }
    }
}