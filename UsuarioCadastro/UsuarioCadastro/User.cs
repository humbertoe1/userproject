using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioCadastro
{
    class User
    {
        //Properties:
        private string name;
        private string cpf;
        private int age;
        private string email;
        private bool toBeRemoved;

        //Constructor
        public User(string name, int age, string email, string cpf)
        {
            SetName(name);
            SetAge(age);
            SetEmail(email);
            SetCpf(cpf);
        }
        //methods 
        //set methods
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetToBeRemoved(bool choice)
        {
            this.toBeRemoved = choice;
        }

        public void SetInformation(string name, int age, string email, string cpf)
        {
            SetName(name);
            SetEmail(email);
            SetAge(age);
            SetCpf(cpf);
        }
            //get methods
        public string GetName()
        {
            return this.name;
        }
        public string GetCpf()
        {
            
            return this.cpf;
        }
        public int GetAge()
        {
            return this.age;
        }
        public string GetEmail()
        {
            return this.email;
        }
        public bool GetToBeRemoved()
        {
            return this.toBeRemoved;
        }
        public void GetInformation()
        {
            Console.WriteLine("User information:\n");
            Console.WriteLine("Name: " + GetName() + "\n");
            Console.WriteLine("Age: " + GetAge() + "\n");
            Console.WriteLine("CPF: " + GetCpf() + "\n");
            Console.WriteLine("Email: " + GetEmail() + "\n");
        }

    }
}
