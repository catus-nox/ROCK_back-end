namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2-1.寫一程式，輸入x和y，如果x>y，則列印x，否則列印y

            //Console.WriteLine("x：");
            //double x = double.Parse(Console.ReadLine());

            //Console.WriteLine("y：");
            //double y = double.Parse(Console.ReadLine());

            //if (x > y)
            //{
            //    Console.WriteLine("x>y，x：" + x);
            //}
            //else
            //{
            //    Console.WriteLine("x<y，y：" + y);
            //}

            //Console.ReadLine();

            #endregion

            #region 2-2.寫一程式，輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0

            //Console.WriteLine("x：");
            //double x = double.Parse(Console.ReadLine());

            //Console.WriteLine("y：");
            //double y = double.Parse(Console.ReadLine());

            //int z;

            //if (x > 0 && y > 0)
            //{
            //    z = 1;
            //}
            //else if (x < 0 && y < 0)
            //{
            //    z = -1;
            //}
            //else
            //{
            //    z = 0;
            //}

            //Console.WriteLine("z：" + z);

            //Console.ReadLine();

            #endregion

            #region 2-3.寫一程式，輸入x、y、u、v，如果(x+y)>(u+v)，則令z=x-y，否則令z=u-v

            //Console.WriteLine("x：");
            //double x = double.Parse(Console.ReadLine());

            //Console.WriteLine("y：");
            //double y = double.Parse(Console.ReadLine());

            //Console.WriteLine("u：");
            //double u = double.Parse(Console.ReadLine());

            //Console.WriteLine("v：");
            //double v = double.Parse(Console.ReadLine());

            //double z;

            //if ((x + y) > (u + v))
            //{
            //    z = x - y;
            //}
            //else
            //{
            //    z = u - v;
            //}

            //Console.WriteLine("z：" + z);

            //Console.ReadLine();

            #endregion

            #region 2-4.寫一程式，輸入x、y、u、v，如果，令z=x-y，否則令z=u-v。

            //Console.WriteLine("x：");
            //double x = double.Parse(Console.ReadLine());

            //Console.WriteLine("y：");
            //double y = double.Parse(Console.ReadLine());

            //Console.WriteLine("u：");
            //double u = double.Parse(Console.ReadLine());

            //Console.WriteLine("v：");
            //double v = double.Parse(Console.ReadLine());

            //double z;

            //if ((x + y) > (u + v))
            //{
            //    z = x - y;
            //}
            //else
            //{
            //    z = u - v;
            //}

            //Console.WriteLine("z：" + z);

            //Console.ReadLine();

            #endregion

            #region 2-5.寫一程式，輸入x和y，如果x>=y，令z=x^2，否則令z=y^2

            //Console.WriteLine("x：");
            //double x = double.Parse(Console.ReadLine());

            //Console.WriteLine("y：");
            //double y = double.Parse(Console.ReadLine());

            //double z;

            //if (x >= y)
            //{
            //    z = x * x;
            //}
            //else
            //{
            //    z = y * y;
            //}

            //Console.WriteLine("z：" + z);

            //Console.ReadLine();

            #endregion

            #region 2-6 流程圖

            //Console.WriteLine("income：");
            //double income = double.Parse(Console.ReadLine());

            //double rate;
            //double difference;

            //if (income > 4090000)
            //{
            //    rate = 0.4;
            //    difference = 721100;
            //}
            //else if (income > 2180000)
            //{
            //    rate = 0.3;
            //    difference = 312100;
            //}
            //else if (income > 1090000)
            //{
            //    rate = 0.21;
            //    difference = 115900;
            //}
            //else if (income >410000)
            //{
            //    rate = 0.13;
            //    difference = 28700;
            //}
            //else
            //{
            //    rate = 0.06;
            //    difference = 0;
            //}

            //double tax =( income * rate)- difference;

            //Console.WriteLine("tax：" + tax);

            //Console.ReadLine();

            #endregion

            #region 2-7 流程圖

            //Console.WriteLine("x：");
            //double x = double.Parse(Console.ReadLine());

            //Console.WriteLine("y：");
            //double y = double.Parse(Console.ReadLine());

            //if (x > 0)
            //{
            //    if (y>0)
            //    {
            //        Console.WriteLine("1st quadrant");
            //    }
            //    else if(y == 0)
            //    {
            //        Console.WriteLine("X-axis");

            //    }
            //    else
            //    {
            //        Console.WriteLine("4th quadrant");

            //    }
            //}
            //else if (x ==0)
            //{
            //    if (y == 0)
            //    {
            //        Console.WriteLine("Origin");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Y-axis");

            //    }
            //}

            //else
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine("2nd quadrant");

            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine("X-axis");

            //    }
            //    else
            //    {
            //        Console.WriteLine("3th quadrant");

            //    }
            //}

            //Console.ReadLine();
            #endregion 流程圖

            #region 補充習題 1
            /*
            sagit 是一位高中電腦老師，這學期正在教學生寫C++程式。他的評分標準是依照每一位學生在 ZeroJudge 系統上解出的題數，去計算出對應的得分。規則如下：
            答對題數在 0~10 者，每題給6分。
            題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
            題數在 21~40 者，從第21題開始，每題給1分。
            題數在 40 以上者，一律100分。
            請輸入答對題數，輸出統計後分數
             */

            Console.WriteLine("答對的題數：");
            //int correctAnswers = int.Parse(Console.ReadLine());

            //int score;

            //if (correctAnswers >= 0 && correctAnswers <= 10)
            //{
            //    score = correctAnswers * 6;
            //}
            //else if (correctAnswers >= 11 && correctAnswers <= 20)
            //{
            //    score = 10 * 6 + (correctAnswers - 10) * 2;
            //}
            //else if (correctAnswers >= 21 && correctAnswers <= 40)
            //{
            //    score = 10 * 6 + 10 * 2 + (correctAnswers - 20) * 1;
            //}
            //else
            //{
            //    score = 100;
            //}

            //Console.WriteLine("得分為：" + score + " 分");

            //Console.ReadLine();

            #endregion

            #region 補充習題2
            /*
            請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。
            請隨意輸入三個數，請由大到小 依序印出。
            企業發放的獎金根據利潤提成。利潤低於或等於10萬元時，獎金可提10%；利潤高于10萬元，低於20萬元時，低於10萬元的部分按10%提成，高於10萬元的部分，可提成7.5%；20萬到40萬之間時，高於20萬元的部分，可提成5%；
            40萬到60萬之間時高於40萬元的部分，可提成3%；
            60萬到100萬之間時，高於60萬元的部分，可提成1.5%，高於100萬元時，超過100萬元的部分按1%提成，從鍵盤輸入當月利潤I，求應發放獎金總數？
            */

            Console.WriteLine("身高m：");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("體重kg：");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("BMI：" + bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("過輕");
            }
            else if (bmi >= 18.5 && bmi < 24)
            {
                Console.WriteLine("正常");
            }
            else
            {
                Console.WriteLine("過重");
            }

            // 輸入三個數，由大到小印出
            Console.WriteLine("輸入三個數，由大到小印出：");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double max = Math.Max(num1, Math.Max(num2, num3));
            double min = Math.Min(num1, Math.Min(num2, num3));
            double mid = num1 + num2 + num3 - max - min;

            Console.WriteLine("由大到小依序印出：" + max + " " + mid + " " + min);

            // 計算獎金
            Console.WriteLine("利潤（萬）：");
            double profit = double.Parse(Console.ReadLine());

            double bonus = 0;
            if (profit <= 10)
            {
                bonus = profit * 0.1;
            }
            else if (profit > 10 && profit <= 20)
            {
                bonus = 10 * 0.1 + (profit - 10) * 0.075;
            }
            else if (profit > 20 && profit <= 40)
            {
                bonus = 10 * 0.1 + 10 * 0.075 + (profit - 20) * 0.05;
            }
            else if (profit > 40 && profit <= 60)
            {
                bonus = 10 * 0.1 + 10 * 0.075 + 20 * 0.05 + (profit - 40) * 0.03;
            }
            else if (profit > 60 && profit <= 100)
            {
                bonus = 10 * 0.1 + 10 * 0.075 + 20 * 0.05 + 20 * 0.03 + (profit - 60) * 0.015;
            }
            else
            {
                bonus = 10 * 0.1 + 10 * 0.075 + 20 * 0.05 + 20 * 0.03 + 40 * 0.015 + (profit - 100) * 0.01;
            }

            Console.WriteLine("發放獎金：" + bonus + "萬元");

            Console.ReadLine();

            #endregion
        }
    }
}
