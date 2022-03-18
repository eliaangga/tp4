using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric<string> halo = new HaloGeneric<string>();
            String x = "Elia Angga";
            halo.SapaUser(x);
            DataGeneric<String> data = new DataGeneric<string>("1302204005");
            data.PrintData();
        }
    }

    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("Halo " + x);
        }
    }

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.data);
        }
    }
}

// Elia Angga - 1302204005

