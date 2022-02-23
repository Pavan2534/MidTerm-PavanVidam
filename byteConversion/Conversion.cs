using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteConversion
{
    public class Conversion
    {
        private int megaByte{ get; set; }
        private int gigaByte { get; set; }
        private int teraByte { get; set; }

        public Conversion()
        {
            megaByte = 1;
            teraByte = 1;
            gigaByte = 1;
        }

        public Conversion(int a, int b, int c)
        {
            megaByte = a;
            teraByte = b;
            gigaByte = c;

        }

        public double ConvertMegabyteToByte(int mb)
        {
           
            double bytes = mb * Math.Pow(2, 20);
            return bytes;
        }

        public double ConvertGigabyteToMegabyte(int gb)
        {
           
            double megabytes = gb * Math.Pow(2, 30) / Math.Pow(2, 20);
            return megabytes;

        }

        public double ConvertTerrabyteToGigabyte(int tb)
        {
           
            double gigabytes = tb * Math.Pow(2, 40) / Math.Pow(2, 30);
            return gigabytes;
        }
    }
}
