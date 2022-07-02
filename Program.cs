using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_CONSUMO {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double distancia, combustivel, consumo;

            Console.Write("Distancia percorrida: ");
            distancia = double.Parse(Console.ReadLine(), CI);
            Console.Write("Combustivel gasto: ");
            combustivel = double.Parse(Console.ReadLine(), CI);

            consumo = distancia / combustivel;

            Console.WriteLine("Consumo medio = " + consumo.ToString("F3", CI));

        }
    }
}
