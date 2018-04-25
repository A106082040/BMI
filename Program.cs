using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 輸入基本資料
            Console.WriteLine(" 請依序輸入身高 ( 公尺 ) 及體重 ( 公斤 ) ");
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            // 設 BMI 為計算及 if 判斷的變數
            double BMI;

            //計算BMI的值
            BMI = w / (h * h);

            // 判斷 BMI 的資訊
            if (BMI < 16.5)
                Console.WriteLine(" 免役體位喔!體重過輕 ");

            else if (BMI >= 16.5 && BMI < 17)
                Console.WriteLine(" 替代役體位喔!但體重過輕 ");

            else if (BMI >= 17 && BMI < 18.5)
                Console.WriteLine(" 常備役體位喔!不過體重過輕 ");

            else if (BMI >= 18.5 && BMI < 24)
                Console.WriteLine(" 常備役體位喔!且體重正常 ");

            else if (BMI >= 24 && BMI < 27)
                Console.WriteLine(" 常備役體位喔!可是體重過重 ");

            else if (BMI >= 27 && BMI < 30)
                Console.WriteLine(" 常備役體位喔!但輕度肥胖 ");

            else if (BMI >= 30 && BMI < 31)
                Console.WriteLine(" 常備役體位喔!不過中度肥胖 ");

            else if (BMI >= 31 && BMI < 31.5)
                Console.WriteLine(" 替代役體位喔!且中度肥胖 ");

            else if (BMI >= 31.5 && BMI < 35)
                Console.WriteLine(" 免役體位喔!但中度肥胖 ");

            else if (BMI >= 35)
                Console.WriteLine(" 免役體位喔!可是重度肥胖 ");

            // 暫停 & 任意鍵結束
            Console.ReadLine();

        }
    }
}
