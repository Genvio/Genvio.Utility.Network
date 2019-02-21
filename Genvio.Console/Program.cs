using System;
using System.Collections;
using System.Collections.Generic;
using Genvio.Utility.Network;
using System.Net;

namespace Genvio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ParseValidString();
            ParseAddressFromCidrNotation();
            VerifyIpAddressIsInCidrRange();
        }
        public static void ParseValidString()
        {
            const string input = "192.168.2.9";
            var result = NetworkUtilities.ParseIPv4Addresses(input);
            var parsedIps = new List<IPAddress>();
            var parsedIp = string.Empty;

            if (result.Success)
            {
                parsedIps = result.Value;
            }

            if (parsedIps.Count > 0)
            {
                parsedIp = parsedIps[0].ToString();
            }

            Console.WriteLine(result.Success);
            Console.WriteLine(parsedIps.Count);
            Console.WriteLine(input, parsedIp);
        }

        public static void ParseAddressFromCidrNotation()
        {
            const string input = "192.168.2.0/24";
            var result = NetworkUtilities.ParseIPv4Addresses(input);
            var parsedIps = new List<IPAddress>();
            var parsedIp = string.Empty;

            if (result.Success)
            {
                parsedIps = result.Value;
            }

            if (parsedIps.Count > 0)
            {
                parsedIp = parsedIps[0].ToString();
            }

            Console.WriteLine(result.Success);
            Console.WriteLine(parsedIps.Count);
            Console.WriteLine("192.168.2.0", parsedIp);
        }
        public static void VerifyIpAddressIsInCidrRange()
        {
            var cidrRange1 = "192.168.2.0/24";
            var cidrRange2 = "10.2.0.0/8";

            var ip1 = "192.168.2.2";
            var ip2 = "192.169.2.2";
            var ip3 = "192.168.3.2";
            var ip4 = "10.168.2.2";
            var ip5 = "10.2.0.2";
            var ip6 = "1.1.1.1";
            var ip7 = "71.94.90.29";

            var checkIp1InCidrRange1 = NetworkUtilities.IpAddressIsInRange(ip1, cidrRange1);
            var checkIp2InCidrRange1 = NetworkUtilities.IpAddressIsInRange(ip2, cidrRange1);
            var checkIp3InCidrRange1 = NetworkUtilities.IpAddressIsInRange(ip3, cidrRange1);
            var checkIp4InCidrRange1 = NetworkUtilities.IpAddressIsInRange(ip4, cidrRange1);
            var checkIp5InCidrRange1 = NetworkUtilities.IpAddressIsInRange(ip5, cidrRange1);
            var checkIp6InCidrRange1 = NetworkUtilities.IpAddressIsInRange(ip6, cidrRange1);
            var checkIp7InCidrRange1 = NetworkUtilities.IpAddressIsInRange(ip7, cidrRange1);

            var checkIp1InCidrRange2 = NetworkUtilities.IpAddressIsInRange(ip1, cidrRange2);
            var checkIp2InCidrRange2 = NetworkUtilities.IpAddressIsInRange(ip2, cidrRange2);
            var checkIp3InCidrRange2 = NetworkUtilities.IpAddressIsInRange(ip3, cidrRange2);
            var checkIp4InCidrRange2 = NetworkUtilities.IpAddressIsInRange(ip4, cidrRange2);
            var checkIp5InCidrRange2 = NetworkUtilities.IpAddressIsInRange(ip5, cidrRange2);
            var checkIp6InCidrRange2 = NetworkUtilities.IpAddressIsInRange(ip6, cidrRange2);
            var checkIp7InCidrRange2 = NetworkUtilities.IpAddressIsInRange(ip7, cidrRange2);

            Console.WriteLine(checkIp1InCidrRange1.Success);
            Console.WriteLine(checkIp1InCidrRange1.Value);
            Console.WriteLine(checkIp2InCidrRange1.Success);
            Console.WriteLine(checkIp2InCidrRange1.Value);
            Console.WriteLine(checkIp3InCidrRange1.Success);
            Console.WriteLine(checkIp3InCidrRange1.Value);
            Console.WriteLine(checkIp4InCidrRange1.Success);
            Console.WriteLine(checkIp4InCidrRange1.Value);
            Console.WriteLine(checkIp5InCidrRange1.Success);
            Console.WriteLine(checkIp5InCidrRange1.Value);
            Console.WriteLine(checkIp6InCidrRange1.Success);
            Console.WriteLine(checkIp6InCidrRange1.Value);
            Console.WriteLine(checkIp7InCidrRange1.Success);
            Console.WriteLine(checkIp7InCidrRange1.Value);

            Console.WriteLine(checkIp1InCidrRange2.Success);
            Console.WriteLine(checkIp1InCidrRange2.Value);
            Console.WriteLine(checkIp2InCidrRange2.Success);
            Console.WriteLine(checkIp2InCidrRange2.Value);
            Console.WriteLine(checkIp3InCidrRange2.Success);
            Console.WriteLine(checkIp3InCidrRange2.Value);
            Console.WriteLine(checkIp4InCidrRange2.Success);
            Console.WriteLine(checkIp4InCidrRange2.Value);
            Console.WriteLine(checkIp5InCidrRange2.Success);
            Console.WriteLine(checkIp5InCidrRange2.Value);
            Console.WriteLine(checkIp6InCidrRange2.Success);
            Console.WriteLine(checkIp6InCidrRange2.Value);
            Console.WriteLine(checkIp7InCidrRange2.Success);
            Console.WriteLine(checkIp7InCidrRange2.Value);
        }

    }
}
