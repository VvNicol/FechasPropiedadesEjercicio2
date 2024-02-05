namespace FechasPropiedadesEjercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaHoyPropiedad = DateTime.Today;

            int dia = fechaHoyPropiedad.Day;
            int month = fechaHoyPropiedad.Month;
            int year = fechaHoyPropiedad.Year;
            int hour = fechaHoyPropiedad.Hour;
            int min = fechaHoyPropiedad.Minute;
            int seg = fechaHoyPropiedad.Second;
            _ = fechaHoyPropiedad.DayOfWeek;
            int yeary = fechaHoyPropiedad.DayOfYear;
        }
    }
}
