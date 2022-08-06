using System;

namespace Count_IP_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement a function that receives two IPv4 addresses,
            //and returns the number of addresses between them
            //(including the first one, excluding the last one).

            //All inputs will be valid IPv4 addresses in the form of strings.
            //The last address will always be greater than the first one.
        }
    }

    public class CountIPAddresses
    {
        public static long IpsBetween(string start, string end)
        {
            byte[] start_new = Array.ConvertAll(start.Split('.'), byte.Parse);
            byte[] end_new = Array.ConvertAll(end.Split('.'), byte.Parse);

            long result = 0;
            int mul = 3;
            for (int i = 0; i < start_new.Length; i++)
            {
                result += (end_new[i] - start_new[i]) * ((long)Math.Pow(256,mul));
                mul--;                
            }
            return result;
        }
    }
}
