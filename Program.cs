using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCertificadosNF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //X509Store store = new X509Store(StoreName.TrustedPeople, StoreLocation.LocalMachine);
            //store.Open(OpenFlags.ReadOnly);
            foreach (X509Certificate2 certificate in GetCertificates())
            {
                Console.WriteLine(certificate.ToString());
            }

            Console.ReadLine();
        }

        //funcion que devuelva todos los certificados instalados en el equipo de todos los stores
        public static X509Certificate2Collection GetCertificates()
        {
            X509Certificate2Collection certificates = new X509Certificate2Collection();
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.TrustedPeople, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.TrustedPublisher, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.AddressBook, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.AuthRoot, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.CertificateAuthority, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.Disallowed, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.TrustedPeople, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.TrustedPublisher, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.AddressBook, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.AuthRoot, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.CertificateAuthority, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            store = new X509Store(StoreName.Disallowed, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadOnly);
            certificates.AddRange(store.Certificates);
            store.Close();
            return certificates;
        }

    }
}
