using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serwis_pogodowy_GUI
{
    internal class Pogoda_inicjalizuj
    {
        public int Id { get; set; }
        public string miasto { get; set; }
        public required double temperatura { get; set; }
        public required double cisnienie { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} ,\t Miasto: {miasto}\t, Temperatura : {temperatura:0.00} , Ciśnienie: {cisnienie}";
        }
    }
}
