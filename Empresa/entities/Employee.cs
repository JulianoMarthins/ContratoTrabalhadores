
using System.Globalization;

namespace Empresa.entities
{
    internal class Employee
    {

        // Atributos
        public string name { get; set; }
        public int hours { get; set; }
        public double valuePerHour { get; set; }


        // Construtores
        public Employee()
        {

        }
                
        public Employee(string name, int hours, double valuePerHour)
        {
            this.name = name;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }


        // Métodos

        public virtual double Payment()
        {
            return this.hours * this.valuePerHour;
        }


        public override string ToString()
        {
            double pagamento = Payment();
            string formatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pagamento);
            return $"\n\nName: {this.name} {formatado} ";
        }

    }
}
