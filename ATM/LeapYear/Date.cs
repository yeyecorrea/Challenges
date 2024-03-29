﻿namespace LeapYear
{
    // clase Date de fechas
    public class Date
    {
        // Propiedades con _para las propiedades privadas
        private int _year;
        private int _month;
        private int _day;
        private int _Hour;
        // Constructor de la clase
        public Date(int year, int month, int day,int Hour)
        {
            _year = year;
            _month = ChekMount(month);
            _day = CheckDay(year, month, day);

        }

        // Metodo que valida el dia del mes
        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            throw new DayException($"Invalid day!! {day}");
        }

        // Metodo que valida si es un año bisiesto, los metodos que retornan bool siempre deben empesar por I
        private bool IsLeapYear(int year)
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                return true;

            }
            throw new LeapYearExeption($"it's not a leap year {year}");
        }

        /*
        Metodo que valida que la fecha este bien, no se utiliza los cw para devolver los mesajes de erro
        ya que la idea es mantener separada la interfaz con la logica por eso se utilizara throw 
        que significa lanzar y lanzara la execpcion
        */
        private int ChekMount(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            // Creamos nustra propia Exception (monthException)
            throw new MonthException($"Invalid Month!! {month}");
        }

        // Override para sobre escribir metodo ToString
        public override string ToString()
        {
            return $"El formato de la fecha es: {_year}/{_month:00}/{_day:00}";
        }

    }
}
