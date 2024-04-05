using System.Runtime.Intrinsics.X86;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ch1-1 寫一程式，輸入a,b,c,d，計算((𝑎+𝑏))/((𝑐−𝑑))×𝑑。

            //Console.WriteLine("寫一程式，輸入a,b,c,d，計算((𝑎+𝑏))/((𝑐−𝑑))×𝑑。");

            //int a, b, c, d;
            //Console.WriteLine("輸入a");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入b");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入c");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入d");
            //d = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("(a+b) / (c-d) * d");
            //try
            //{
            //    double answer = Convert.ToDouble((a + b) / (c - d) * d);
            //    Console.WriteLine(answer);
            //    Console.ReadLine();
            //}
            ////分母不可為0
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0");
            //}

            #endregion

            #region ch1-2 假設有一組二元一次方程式如下：a1x + b1y = c1，a1x + b2y = c2  此組方程式的解如下：x = ((c1b2-c2b1))/ ((a1b2-a2b1))，y = ((c1a2-c2a1))/ ((b1a2-a1b2)) 寫一程式，輸入此方程式變數之係數。
            //Console.WriteLine("假設有一組二元一次方程式如下：a1x + b1y = c1，a1x + b2y = c2  此組方程式的解如下：x = ((c1b2-c2b1))/ ((a1b2-a2b1))，y = ((c1a2-c2a1))/ ((b1a2-a1b2)) 寫一程式，輸入此方程式變數之係數。");

            //// 方程式1
            //Console.WriteLine("請輸入a1：");
            //double a1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("請輸入b1：");
            //double b1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("請輸入c1：");
            //double c1 = double.Parse(Console.ReadLine());

            //// 方程式2
            //Console.WriteLine("請輸入a2：");
            //double a2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("請輸入b2：");
            //double b2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("請輸入c2：");
            //double c2 = double.Parse(Console.ReadLine());

            //// 計算
            //double x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
            //double y = (c1 * a2 - c2 * a1) / (b1 * a2 - a1 * b2);

            //Console.WriteLine($"x = {x}");
            //Console.WriteLine($"y = {y}");

            //Console.ReadLine();
            #endregion

            #region ch1-3 輸入a和b，求：(提示:使用Math)，c = (a^1+b^2)/ (a^2-b^2)
            Console.WriteLine("輸入a和b，求：(提示:使用Math)，c = (a^1+b^2)/ (a^2-b^2)");
            //// Parse(強制轉型)
            //// Parse 則是無條件捨去( long、float、double、或 decimal )

            // 讀取用戶輸入的a和b的值
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());

            // 計算c
            double c = Math.Pow(a, 1) + Math.Pow(b, 2) / (Math.Pow(a,2) - Math.Pow(b, 1));

            // 輸出結果
            Console.WriteLine("c = " + c);

            Console.ReadLine();
            #endregion

            #region ch1-4 輸入a和b，求： (提示:使用Math) c = √(a^2+b^2)：
            //Console.Write("輸入a和b，求： (提示:使用Math) c = √(a^2+b^2：");

            ////// Parse(強制轉型)
            ////// Parse 則是無條件捨去( long、float、double、或 decimal )

            //// 讀取用戶輸入的a和b的值
            //Console.Write("a: ");
            //double a = double.Parse(Console.ReadLine());

            //Console.Write("b: ");
            //double b = double.Parse(Console.ReadLine());

            //// 計算c的值
            //// 此方法傳回x的平方根：Math.Sqrt(x)
            //double c = Math.Sqrt(a * a + b * b);

            //// 輸出c的值
            //Console.WriteLine("c的值為：" + c);

            //Console.ReadLine();
            #endregion

            #region ch1-5 輸入a、b和c，求：c = a-(b+c)(3a-c)：
            //Console.WriteLine("輸入a、b和c，求：c = a-(b+c)(3a-c)：");

            ////// Parse(強制轉型)
            ////// Parse 則是無條件捨去( long、float、double、或 decimal )

            //// 讀取用戶輸入的a、b和c的值
            //Console.Write("a: ");
            //double a = double.Parse(Console.ReadLine());

            //Console.Write("b: ");
            //double b = double.Parse(Console.ReadLine());

            //Console.Write("c: ");
            //double c = double.Parse(Console.ReadLine());

            //// 計算表達式的值
            //double answer = a - (b + c) * (3 * a - c);

            //// 輸出結果
            //Console.WriteLine("a - (b + c) * (3 * a - c)：" + answer);
            //Console.ReadLine();
            #endregion

            #region ch1-6 請隨意輸入正負數，取絕對值輸出
            //Console.WriteLine("請隨意輸入正負數，取絕對值輸出");

            ////// Parse(強制轉型)
            ////// Parse 則是無條件捨去( long、float、double、或 decimal )

            //Console.Write("輸入數字：");
            //double number = double.Parse(Console.ReadLine());

            ////此方法傳回x的絕對（正）值：Math.Abs(x)
            //double absoluteValue = Math.Abs(number);

            //Console.WriteLine("絕對值為：" + absoluteValue);
            //Console.ReadLine();
            #endregion

            #region ch1-7 輸入的西元年份轉換成民國年份後輸出
            //Console.WriteLine("輸入的西元年份轉換成民國年份後輸出");

            ////// Parse(強制轉型)
            ////// Parse 則是無條件捨去( long、float、double、或 decimal )

            //Console.Write("西元");
            //int westernYear = int.Parse(Console.ReadLine());

            //// 轉換成民國年份
            //int taiwanYear = westernYear - 1911;

            //// 輸出結果
            //Console.WriteLine("民國：" + taiwanYear + "年");

            //Console.ReadLine();
            #endregion

            #region ch1-8 請輸入身高體重，輸出BMI
            //Console.WriteLine("請輸入身高體重，輸出BMI");

            ////// Parse(強制轉型)

            //Console.Write("身高(m)：");
            //double height = double.Parse(Console.ReadLine());

            //Console.Write("體重(kg)：");
            //double weight = double.Parse(Console.ReadLine());

            //// BMI公式
            //double bmi = weight / (height * height);

            //// 輸出BMI
            //Console.WriteLine("BMI為：" + bmi);

            //Console.ReadLine();
            #endregion

        }
    }
}
