// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

X509Store store = new X509Store(StoreName.TrustedPeople, StoreLocation.LocalMachine);
store.Open(OpenFlags.ReadOnly);
foreach (X509Certificate2 certificate in store.Certificates)
{
    Console.WriteLine(certificate.ToString());
}

Console.ReadLine();
