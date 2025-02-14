using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Pessoa
{
    internal class PessoaBLL
    {
        static string formatacao;
        static Regex regex;

        public static void validarDados(Pessoa pessoa)
        {
            Erro.setErro(false);

            if (String.IsNullOrEmpty(pessoa.Nome))
            {
                Erro.setErro("Nome é de preenchimento obrigatório.");
                return;
            }

            if (String.IsNullOrEmpty(pessoa.Telefone))
            {
                Erro.setErro("Telefone é de preenchimento obrigatório.");
                return;
            }
            else
            {
                formatacao = @"^\(\d{2}\) \d{5}-\d{4}$";
                regex = new Regex(formatacao);

                if (!regex.IsMatch(pessoa.Telefone))
                {
                    Erro.setErro("Telefone está com formatação incorreta.");
                    return;
                }
            }

            if (String.IsNullOrEmpty(pessoa.Email))
            {
                Erro.setErro("Email é de preenchimento obrigatório.");
                return;
            }
            else
            {
                formatacao = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                regex = new Regex(formatacao);

                if (!regex.IsMatch(pessoa.Email))
                {
                    Erro.setErro("Email está com formatação incorreta.");
                    return;
                }
            }

            if (String.IsNullOrEmpty(pessoa.CEP))
            {
                Erro.setErro("CEP é de preenchimento obrigatório.");
                return;
            }
            else
            {
                formatacao = @"^\d{5}-\d{3}$";
                regex = new Regex(formatacao);

                if (!regex.IsMatch(pessoa.CEP))
                {
                    Erro.setErro("CEP está com formatação incorreta.");
                    return;
                }
            }

            if (String.IsNullOrEmpty(pessoa.Estado))
            {
                Erro.setErro("Estado é de preenchimento obrigatório.");
                return;
            }

            if (String.IsNullOrEmpty(pessoa.Cidade))
            {
                Erro.setErro("Cidade é de preenchimento obrigatório.");
                return;
            }

            if (String.IsNullOrEmpty(pessoa.Bairro))
            {
                Erro.setErro("Bairro é de preenchimento obrigatório.");
                return;
            }

            if (String.IsNullOrEmpty(pessoa.Rua))
            {
                Erro.setErro("Rua é de preenchimento obrigatório.");
                return;
            }

            if (String.IsNullOrEmpty(pessoa.NumeroRua))
            {
                Erro.setErro("Número da Rua é de preenchimento obrigatório.");
                return;
            }
            else
            {
                try
                {
                    int.Parse(pessoa.NumeroRua);
                }
                catch (Exception)
                {
                    Erro.setErro("Número da Rua precisa ser um valor inteiro.");
                    return;
                }
            }
        }

        public static int createPessoa(Pessoa pessoa)
        {
            return PessoaDAL.createPessoa(pessoa);
        }

        public static Pessoa readPessoa(String id)
        {
            return PessoaDAL.readPessoa(id);
        }

        public static void updatePessoa(Pessoa pessoa)
        {
            PessoaDAL.updatePessoa(pessoa);
        }

        public static void removePessoa(String id)
        {
            PessoaDAL.removePessoa(id);
        }
    }
}
