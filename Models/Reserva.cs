using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // FEITO!
            int capacidade = Suite.Capacidade;
            if (capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // FEITO!
                throw new Exception ("A capacidade da suite é menor que o número de hóspedes.");
            
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // FEITO!
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            // FEITO!
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor;
            valor = DiasReservados * Suite.ValorDiaria;

            // FEITO!
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 10 / 100);
            }

            return valor;
        }
    }
}