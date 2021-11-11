using System;

namespace LogicaPrestamo
{
    public class Service
    {
        public string CalculoPretamo(double CantidadPrestamo, int CantidadCuotas, double PorcentajeInteres)
        {
            PorcentajeInteres /= 100;
            double CuotaMensuales = ((CantidadPrestamo * PorcentajeInteres)+ CantidadPrestamo) /CantidadCuotas;
            
            return $"{CuotaMensuales}";
        }

    }
}
