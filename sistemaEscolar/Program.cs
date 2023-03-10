using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alunoJoao = new Aluno();
            Aluno alunoIzione = new Aluno();
            Aluno alunoJulio = new Aluno();

            Funcionario funcionarioJulio = new Funcionario();
            Funcionario funcionarioAmintas = new Funcionario();

            funcionarioJulio.nome = "Julio Cesar";
            funcionarioJulio.cargo = "Coordenador";
            funcionarioJulio.CPF = "14245687978";

            funcionarioAmintas.nome = "Amintes";
            funcionarioAmintas.cargo = "Armazenista";
            funcionarioAmintas.CPF = "123456789.10";


            alunoJoao.nome = "João Vitor";
            alunoJoao.RG = "0123456789";
            alunoJoao.nascimento = DateTime.Parse("17/01/2000");

            alunoIzione.nome = "Izione de Oliveira";
            alunoIzione.RG = "9876543210";
            alunoIzione.nascimento = DateTime.Parse("29/10/1972");

            Console.WriteLine("Nome do primeiro aluno: " + alunoJoao.nome);
            Console.WriteLine("O RG do primeiro aluno: " + alunoJoao.RG);
            Console.WriteLine("O nascimento do primeiro aluno: " + alunoJoao.nascimento.ToShortDateString());
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Nome do segundo aluno: " + alunoIzione.nome);
            Console.WriteLine("O RG do segundo aluno: " + alunoIzione.RG);
            Console.WriteLine("O nascimento do segundo aluno: " + alunoIzione.nascimento.ToShortDateString());
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Nome do primeiro Funcionario: " + funcionarioJulio.nome);
            Console.WriteLine("O cargo do primeiro Funcionario: " + funcionarioJulio.cargo);
            Console.WriteLine("O CPF do primeiro Funcionario" + funcionarioJulio.CPF);
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Nome do segundo Funcionario: " + funcionarioAmintas.nome);
            Console.WriteLine("O cargo do segundo Funcionario: " + funcionarioAmintas.cargo);
            Console.WriteLine("O CPF do segundo Funcionario: " + funcionarioAmintas.CPF);





            Console.ReadKey();




        }
    }
}
