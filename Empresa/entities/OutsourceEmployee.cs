
using Microsoft.SqlServer.Server;
using System.Globalization;

namespace Empresa.entities
{
    internal class OutsourceEmployee : Employee
    {
        // Atributos
        public double additionalCharge { get; set; }


        // Construtores
        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge):
            base(name, hours, valuePerHour)
        {
            this.additionalCharge = additionalCharge;
        }

        // Métodos
        public override double Payment()
        {
            return base.Payment() + 1.1 * additionalCharge;
        }

        public override string ToString()
        {
            double pagamento = this.Payment();
            string formatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pagamento);
            return $"\n\nName: {this.name} {formatado} ";
        }

    }
}
