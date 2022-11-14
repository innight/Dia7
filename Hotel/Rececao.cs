using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;

namespace Hotel
{
    internal class Rececao
    {
        public byte Telefone { get; set; }
        public string Email { get; set; }

        #region NOT-STATIC

        public void PedirRececao()
        {
            var valor = "";
            byte telefone;
            string email;
            
            Console.WriteLine("Introduza Telefone:");
            valor = Console.ReadLine();

            bool resultado = byte.TryParse(valor, out telefone);
            if (resultado)
            {
                Telefone = telefone;
            }
            else
            {
                Console.WriteLine("A conversão de '{0}' Falhou.", valor == null ? "<null>" : valor);
            }

            Console.WriteLine("introduza email");
            email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                Email = email;
            }
            else
            {
                Email = null;
                Console.WriteLine("Por Favor introduza email correto;");
            }
        }



        public override string ToString()
        {
            return $"Telefone: {Telefone}\nEmail: {Email}";
        }

        void Mostrar()
        {
            Console.WriteLine(ToString());
        }
        static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        #endregion

        #region STATIC
        public static void CriarRececao()
        {
            var valor = "";
            byte telefone;
            string email;
            Rececao rececao = new Rececao();

            Console.WriteLine("Introduza Telefone:");
            valor = Console.ReadLine();

            bool resultado = byte.TryParse(valor, out telefone);
            if (resultado)
            {
                rececao.Telefone = telefone;
            }
            else
            {
                Console.WriteLine("A conversão de '{0}' Falhou.", valor == null ? "<null>" : valor);
            }

            Console.WriteLine("introduza email");
            email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                rececao.Email = email;
            }
            else
            {
                rececao.Email = null;
                Console.WriteLine("Por Favor introduza email correto;");
            }

            rececao.Mostrar();
        }

        #endregion
    }
}
