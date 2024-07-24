using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi3
{
    class TinhTongDQ
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n;

            Console.Write("Nhap so luong phan tu can tinh tong vao mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang: \n", n);
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            int sum = tinhTongMang(a, n);

            Console.WriteLine("Tong cac phan tu trong mang la: " + sum);
            Console.ReadLine();
        }
        public static int tinhTongMang(int[] a, int n)
        {
            if (n == 0)
                return 0;
            return tinhTongMang(a, n - 1) + a[n - 1];
        }
    }
}
