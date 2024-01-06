using System;
using System.Text;

namespace SHA1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Security.Cryptography.SHA1 hash = System.Security.Cryptography.SHA1.Create();
            foreach (string s in args)
            {
                byte[] jj = Encoding.ASCII.GetBytes(s);
                byte[] sha1 = hash.ComputeHash(jj);
                Console.Write("{0} => ", s);
                foreach (byte j in sha1)
                    Console.Write(j.ToString("X2"));
                Console.WriteLine();
            }
        }
    }
}
