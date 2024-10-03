using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visibilidade
{
    internal class Pessoa
    {
        private string Nome;
        private int Idade;
        private string Telefone;
        private string Endereco;
        private string Email;

        public string getNome()
        {
            return Nome;
        }
        public void setNome(string nome)
        {
            if (String.IsNullOrWhiteSpace(nome) == false)
            {

                 Nome = nome;
            }
            else
            {
                Console.WriteLine("Nome não pode estar vazio");
            }
        }
        public int getIdade()
        {
            return Idade;
        }
        public void setIdade(int idade)
        {
            if (idade > 0)
            {
                 Idade = idade;
            }
            else
            {
                Console.WriteLine("Idade invalida");
            }
        }
        public string getTelefone()
        {
            return Telefone;
        }
        public void setTelefone(string telefone)
        {
            if (String.IsNullOrWhiteSpace(telefone) == false)
            {
                Telefone = telefone;
            }
            else
            {
                Console.WriteLine("Telefone não pode ficar em branco");
            }
        }
        public string getEmail()
        {
            return Email;
        }
        public void setEmail(string email)
        {   if (String.IsNullOrWhiteSpace(email) == false)
            {
                 Email = email;
            }
            else
            {
                Console.WriteLine("Email não pode estar vazio");
            }
        }
        public string getEndereco()
        {
            return Endereco;
        }
        public void setEndereco(string endereco)
        {
            if (String.IsNullOrWhiteSpace(endereco) == false)
            {
                Endereco = endereco;
            }
            else
            {
                Console.WriteLine("Endereço não pode ficar em branco");
            }
        }
    }
}
