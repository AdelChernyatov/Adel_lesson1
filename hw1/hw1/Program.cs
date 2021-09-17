using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1.1");
            double a = 2.12;
            Console.WriteLine(a);


            Console.WriteLine("1.2");
            Console.WriteLine("e = 2.7");


            Console.WriteLine("1.3");
            int u = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + u);


            Console.WriteLine("1.4");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(j + " вот какое число Вы ввели");


            Console.WriteLine("1.5");
            Console.WriteLine("1 13 49");


            Console.WriteLine("1.6");
            Console.WriteLine("7  15  100");



            Console.WriteLine("1.7");
            Console.WriteLine("12  13  14");


            Console.WriteLine("1.8");
            Console.WriteLine("1 2 3 4");


            Console.WriteLine("1.9");
            Console.WriteLine("50");
            Console.WriteLine("10");


            Console.WriteLine("1.10");
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");



            Console.WriteLine("1.11");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");


            Console.WriteLine("1.12");
            Console.WriteLine("5 10");
            Console.WriteLine(7 + " см");


            Console.WriteLine("1.13");
            Console.WriteLine(2 + " кг");
            Console.WriteLine("13 17");






            Console.WriteLine("2.1");
            int x5 = int.Parse(Console.ReadLine());
            double y5 = 7 * Math.Pow(x5, 2) + 3 * x5 + 6;
            Console.WriteLine(y5);


            Console.WriteLine("2.1a");
            int a4 = int.Parse(Console.ReadLine());
            double x4 = 12 * Math.Pow(a4, 2) + 7 * a4 + 12;                // Math.Pow - Возведение в степень 
            Console.WriteLine(x4);



            Console.WriteLine("2.2");
            int side3 = int.Parse(Console.ReadLine());
            int perimetr3 = 4 * side3;
            Console.WriteLine(perimetr3);



            Console.WriteLine("2.3");
            int radius2 = int.Parse(Console.ReadLine());
            int diametr2 = 2 * radius2;
            Console.WriteLine(diametr2);


            Console.WriteLine("2.4");
            int AB1 = int.Parse(Console.ReadLine());
            int OA1 = 6350;                                           // боялся,что переменные другие заняты  
            int OG1 = 6350;                                           // 
            int OB1 = AB1 + OA1;
            double BG1 = Math.Round(Math.Sqrt(OB1 * OB1 - OG1 * OG1), 2);
            Console.WriteLine("Расстояние до линии горизонта " + BG1);



            Console.WriteLine("2.5");
            int dlina3 = int.Parse(Console.ReadLine());
            double V3 = Math.Pow(dlina3, 3);
            double S3 = 4 * Math.Pow(dlina3, 2);
            Console.WriteLine("Объем куба " + V3);
            Console.WriteLine("Площадь боковой поверхности " + S3);


            Console.WriteLine("2.6");
            int radius1 = int.Parse(Console.ReadLine());
            double dlinaOkr = 2 * 3.14 * radius1;
            double S = 3.14 * radius1 * radius1;
            Console.WriteLine("Длина окружности " + dlinaOkr);
            Console.WriteLine("Площадь круга " + S);



            Console.WriteLine("2.7");
            int a7 = int.Parse(Console.ReadLine());
            int b7 = int.Parse(Console.ReadLine());
            int arifmetik = (a7 + b7) / 2;
            double geometrik = Math.Round(Math.Sqrt(a7 * b7), 2);
            Console.WriteLine("Среднее арифметическое " + arifmetik);
            Console.WriteLine("Среднее геометрическое " + geometrik);


            Console.WriteLine("2.8");
            int m = int.Parse(Console.ReadLine());
            int V = int.Parse(Console.ReadLine());   //plotm - плотность населения
            double plotn = m / V;                       //m,V-масса,обьем
            Console.WriteLine("Плотность тела " + plotn);


            Console.WriteLine("2.9");
            int naselenie = int.Parse(Console.ReadLine());
            int S29 = int.Parse(Console.ReadLine());
            double plotnost = naselenie / S29;
            Console.WriteLine("Плотность населения " + plotnost);



            Console.WriteLine("2.10");
            double W = int.Parse(Console.ReadLine());
            double E = int.Parse(Console.ReadLine());
            if (W != 0)
            {                                               //W,E-вводимые коэффициенты (a,b)
                double F = -E / W;

                Console.WriteLine(F);                   //F- решение уравнения(x)
            }
            else
            {
                Console.WriteLine("Уравнение не имеет решения");
            }


            Console.WriteLine("2.11");
            int katet1 = int.Parse(Console.ReadLine());
            int katet2 = int.Parse(Console.ReadLine());
            double hypotinuze = Math.Round(Math.Sqrt(katet1 * katet1 + katet2 * katet2), 2);
            Console.WriteLine("Гипотенуза " + hypotinuze);



            Console.WriteLine("2.12");
            int r = int.Parse(Console.ReadLine());
            int R = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь кольца " + (R - r));


            Console.WriteLine("2.13");
            double p = int.Parse(Console.ReadLine());
            double q = int.Parse(Console.ReadLine());         //p,q - катеты                             
            double C = Math.Sqrt(p * p + q * q);              // C - Гипотенузв
            Console.WriteLine("Периметр прямоугольного треугольника " + (p + q + C));


            Console.WriteLine("2.13A");
            int f = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());       // f,g - числа
            int h = Math.Abs(f);
            int s = Math.Abs(g);
            Console.WriteLine("Среднее арифметическое " + (h + s) / 2);
            Console.WriteLine("Среднее геометрическое " + Math.Sqrt(h * s));


            Console.WriteLine("2.14");
            int osnovanie1 = int.Parse(Console.ReadLine());   //большее основание                                  
            int osnovanie2 = int.Parse(Console.ReadLine());    // меньшее основание                  
            int height = int.Parse(Console.ReadLine());
            int d = (osnovanie1 - osnovanie2) / 2;
            double bokstorona = Math.Sqrt(height * height + d * d);
            Console.WriteLine("Периметр трапеции " + (osnovanie1 + osnovanie2 + bokstorona * 2));


            Console.WriteLine("2.14A");
            int storona1 = int.Parse(Console.ReadLine());
            int storona2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр прямоугольника " + (2 * storona1 + 2 * storona2));
            Console.WriteLine("Длина диагонали " + Math.Sqrt(storona2 * storona2 + storona1 * storona1));



            Console.WriteLine("2.15");
            int figure1 = int.Parse(Console.ReadLine());
            int figure2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма " + (figure1 + figure2));
            Console.WriteLine("Произведение " + figure1 * figure2);
            Console.WriteLine("Частное " + figure1 / figure2);





            Console.WriteLine("2.16");
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());           //side1-3 -cтороны прямоугольного параллепипеда              
            int sidE3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Объем " + side1 * side2 * sidE3);
            Console.WriteLine("Площадь боковой поверхности " + 2 * (side1 * side3 + side2 * sidE3));


            Console.WriteLine("2.17");
            int Ax = int.Parse(Console.ReadLine());
            int Bx = int.Parse(Console.ReadLine());
            int Ay = int.Parse(Console.ReadLine());
            int By = int.Parse(Console.ReadLine());
            int lengthY = Ay - By;                            //Расстояние по y
            int lengthX = Ax - Bx;                            // Расстояние по x
            Console.WriteLine("Расстояние м-у точками " + Math.Sqrt(lengthY * lengthY + lengthX * lengthX));



            Console.WriteLine("2.18");
            int osnMAX = int.Parse(Console.ReadLine());                      //osnMAX - большее основание               
            int HEight = int.Parse(Console.ReadLine());                        //osnMIN - меньшее основание
            int osnMIN = int.Parse(Console.ReadLine());
            int d218 = (osnMAX - osnMIN) / 2;
            double bokstorona218 = Math.Sqrt(HEight * HEight + d218 * d218);
            Console.WriteLine("Периметр трапеции " + (osnMAX + osnMIN + bokstorona218 * 2));



            Console.WriteLine("2.19");
            int osnmax = int.Parse(Console.ReadLine());                             //osnmax - большее основание 
            int osnmin = int.Parse(Console.ReadLine());                             //osnmin - меньшее основание
            int gradys = int.Parse(Console.ReadLine());                        //Math.PI - число пи
            int d219 = (osnmax - osnmin) / 2;                                    // Math.Tan - тангенс числа
            double Height = Math.Tan((gradys) * d219);
            Console.WriteLine("Площадь равнобедренной трапеции" + (osnmax + osnmin) / 2 * Height);


            Console.WriteLine("2.20");
            int xA = int.Parse(Console.ReadLine());
            int yA = int.Parse(Console.ReadLine());
            int xB = int.Parse(Console.ReadLine());
            int yB = int.Parse(Console.ReadLine());
            int xC = int.Parse(Console.ReadLine());
            int yC = int.Parse(Console.ReadLine());
            double AB = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
            double AC = Math.Sqrt(Math.Pow(xA - xC, 2) + Math.Pow(yA - yC, 2));
            double BC = Math.Sqrt(Math.Pow(xB - xC, 2) + Math.Pow(yB - yC, 2));
            double Perimetr = AB + AC + BC;
            double pp = (AB + AC + BC) / 2;                                     // pp- полупериметр
            double S220 = Math.Sqrt(pp * (pp - AB) * (pp - AC) * (pp - BC));       //Площадь треугольника по ф-ле Герона
            Console.WriteLine("Периметр треугольника " + Perimetr);
            Console.WriteLine("Площадь треугольника " + S220);



            Console.WriteLine("2.21");
            int XA = int.Parse(Console.ReadLine());
            int YA = int.Parse(Console.ReadLine());
            int XB = int.Parse(Console.ReadLine());
            int YB = int.Parse(Console.ReadLine());                             //X,Y-координаты четырехугольника
            int XC = int.Parse(Console.ReadLine());                              // lenght 1-4 длины сторон 4-ка
            int YC = int.Parse(Console.ReadLine());
            int XD = int.Parse(Console.ReadLine());
            int YD = int.Parse(Console.ReadLine());
            double lenght1 = Math.Sqrt(Math.Pow(XA - XB, 2) + Math.Pow(YA - YB, 2)); //AB
            double lenght2 = Math.Sqrt(Math.Pow(XA - XC, 2) + Math.Pow(YA - YC, 2)); //AC
            double lenght3 = Math.Sqrt(Math.Pow(XB - XC, 2) + Math.Pow(YB - YC, 2)); //BC
            double lenght4 = Math.Sqrt(Math.Pow(XC - XD, 2) + Math.Pow(YC - YD, 2)); //CD
            double length5 = Math.Sqrt(Math.Pow(XD - XA, 2) + Math.Pow(YD - YA, 2)); //DA
            double polper1 = (lenght1 + lenght3 + lenght2) / 2;                         // Полупериметр треугольника ABC
            double polper2 = (length5 + lenght4 + lenght2) / 2;   //Полупериметр треугольника ADC
            double SABC = Math.Sqrt(polper1 * (polper1 - lenght1) * (polper1 - lenght3) * (polper1 - lenght2));
            double SADC = Math.Sqrt(polper2 * (polper2 - lenght4) * (polper2 - length5) * (polper2 - lenght2));
            Console.WriteLine("Площадь четырехугольника " + (SABC + SADC));


            Console.WriteLine("2.22");
            int sweets = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());
            int apples = int.Parse(Console.ReadLine());
            int xsw = int.Parse(Console.ReadLine()); //x
            int ycook = int.Parse(Console.ReadLine()); //y
            int zappl = int.Parse(Console.ReadLine()); //z
            Console.WriteLine("Стоимость всей покупки " + (sweets * xsw + cookies * ycook + apples * zappl));


            Console.WriteLine("2.23");
            int monitor = int.Parse(Console.ReadLine());
            int mouse = int.Parse(Console.ReadLine());
            int block = int.Parse(Console.ReadLine());
            int keyboard = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Стоимость 3-х компьютеров " + 3 * (monitor + mouse + keyboard + block));
            Console.WriteLine("Стоимость " + N + " компьютеров " + N * (monitor + mouse + keyboard + block));



            Console.WriteLine("2.24");
            int ageT = int.Parse(Console.ReadLine()); //ageT возраст Тани
            int ageM = int.Parse(Console.ReadLine()); //ageM возраст Мити
            double average = (ageM + ageT) / 2;
            Console.WriteLine("Средний возраст " + average);
            Console.WriteLine(" Возраст Тани отличается от среднего на " + Math.Abs(ageT - average));
            Console.WriteLine(" Возраст Тани отличается от среднего на " + Math.Abs(ageM - average));



            Console.WriteLine("2.25");
            double speed1 = int.Parse(Console.ReadLine());
            double speed2 = int.Parse(Console.ReadLine());
            double rasstoynie = int.Parse(Console.ReadLine());
            double time = rasstoynie / (speed1 + speed2);
            Console.WriteLine("Автомобили встретятся через " + time);



            Console.WriteLine("2.26");
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());
            int way = int.Parse(Console.ReadLine());
            int v12 = v1 - v2; //скорость отдаления
            Console.WriteLine("Первый автомобиль обогнал второй на " + (way + 0.5 * v12));


            Console.WriteLine("2.27");
            double celcia = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение температуры в Фаренгейтах " + (celcia * 1.8 + 32));
            Console.WriteLine("Значение температуры в Кельвинах " + (celcia + 273.15));


            Console.WriteLine("2.28");
            double farengeit = 450;
            Console.WriteLine("Температура в градусах " + Math.Round((farengeit - 32) / 1.8, 2));




            Console.WriteLine("3.1");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3;
            number3 = number2;
            number2 = number1;
            number1 = number3;
            Console.WriteLine("1-ое число " + number1);
            Console.WriteLine("2-ое число " + number2);


            Console.WriteLine("3.2a");
            int aA = int.Parse(Console.ReadLine());
            int bB = int.Parse(Console.ReadLine());
            int cC = int.Parse(Console.ReadLine());
            bB = cC;
            aA = bB;
            cC = aA;
            Console.WriteLine("Значение числа A " + aA);
            Console.WriteLine("Значение числа B " + bB);
            Console.WriteLine("Значение числа C " + cC);


            Console.WriteLine("3.2b");
            int AA = int.Parse(Console.ReadLine());
            int BB = int.Parse(Console.ReadLine());
            int CC = int.Parse(Console.ReadLine());
            BB = AA;
            CC = BB;
            AA = CC;
            Console.WriteLine("Значение числа A " + AA);
            Console.WriteLine("Значение числа B " + BB);
            Console.WriteLine("Значение числа C " + CC);



            Console.WriteLine("3.3a");                                                  // n33k переменная,где n(буква), 33- аббревиатура задания 3.3,k-пункты заданий
            int a33a = int.Parse(Console.ReadLine());
            int b33a = a33a * a33a;
            Console.WriteLine(b33a * b33a);




            Console.WriteLine("3.3б");
            int a33б = int.Parse(Console.ReadLine());                                       // n33k переменная,где n(буква), 33- аббревиатура задания 3.3,k-пункты заданий
            int b33б = a33б * a33б;
            int c33б = b33б * b33б;
            Console.WriteLine(c33б * b33б);



            Console.WriteLine("3.3в");
            int a33в = int.Parse(Console.ReadLine());
            int b33в = a33в * a33в;                                                       // n33k переменная,где n(буква), 33- аббревиатура задания 3.3,k-пункты заданий
            int c33в = b33в * b33в;
            int d33в = b33в * a33в;
            Console.WriteLine(d33в * c33в);


            Console.WriteLine("3.3г");
            int a33г = int.Parse(Console.ReadLine());
            int b33г = a33г * a33г;                                                       // n33k переменная,где n(буква), 33- аббревиатура задания 3.3,k-пункты заданий
            int c33г = b33г * b33г;
            Console.WriteLine(c33г * c33г);


            Console.WriteLine("3.3д");
            int a33д = int.Parse(Console.ReadLine());                                       // n33k переменная,где n(буква), 33- аббревиатура задания 3.3,k-пункты заданий
            int b33д = a33д * a33д;
            int c33д = b33д * b33д;
            int d33д = c33д * c33д;
            Console.WriteLine(d33д * a33д);


            Console.WriteLine("3.3е");
            int a33е = int.Parse(Console.ReadLine());
            int b33е = a33е * a33е;                                                            // n33k переменная,где n(буква), 33- аббревиатура задания 3.3,k-пункты заданий
            int c33е = b33е * b33е;
            int d33е = c33е * c33е;
            Console.WriteLine(d33е * b33е);




            Console.WriteLine("3.4а");
            int a34a = int.Parse(Console.ReadLine());
            int b34a = a34a * a34a;
            int c34a = b34a * a34a;
            int d34a = c34a * b34a;
            Console.WriteLine("3-я степень " + c34a);
            Console.WriteLine("10-я степень " + d34a * d34a);


            Console.WriteLine("3.4б");
            int a34б = int.Parse(Console.ReadLine());
            int b34б = a34б * a34б;
            int c34б = b34б * b34б;
            int d34б = c34б * c34б;
            int e34б = d34б * d34б;
            Console.WriteLine("4-я степень " + c34б);
            Console.WriteLine("20-я степень " + e34б * c34б);



            Console.WriteLine("3.4в");
            int a34в = int.Parse(Console.ReadLine()); ;
            int b34в = a34в * a34в;
            int c34в = b34в * b34в;
            int d34в = c34в * a34в;
            int e34в = d34в * c34в;
            Console.WriteLine("5-я степень " + d34в);
            Console.WriteLine("13-я степень " + e34в * c34в);


            Console.WriteLine("3.4г");
            int a34г = int.Parse(Console.ReadLine()); ;
            int b34г = a34г * a34г; //a2
            int c34г = b34г * b34г; //a4
            int d34г = c34г * a34г; //a5                                                   // возможно только при помощи 6 операций
            int e34г = d34г * c34г; //a9
            int k34г = e34г * e34г;  //a18
            Console.WriteLine("5-я степень " + d34г);
            Console.WriteLine("19-я степень " + k34г * a34г);


            Console.WriteLine("3.4д");

            int a34д = int.Parse(Console.ReadLine()); ;
            int b34д = a34д * a34д; //a2
            int c34д = b34д * b34д; //a4
            int d34д = c34д * a34д; //a5                                                  
            int e34д = c34д * c34д; //a8
            int k34д = e34д * e34д;  //a16
            Console.WriteLine("2-я степень " + b34д);
            Console.WriteLine("5-я степень " + d34д);
            Console.WriteLine("17-я степень " + (k34д * a34д));


            Console.WriteLine("3.4е");
            int a34е = int.Parse(Console.ReadLine()); ;
            int b34е = a34е * a34е; //a2
            int c34е = b34е * b34е; //a4
            int d34е = c34е * c34е;//a8
            int e34е = d34е * c34е; //a12
            int k34е = e34е * e34е;  //a24
            Console.WriteLine("4-я степень " + c34е);
            Console.WriteLine("12-я степень " + e34е);
            Console.WriteLine("28-я степень " + (k34е * c34е));



            Console.WriteLine("3.5");
            long a35 = 10;
            long b35 = a35 * a35;
            long c35 = b35 * b35;
            long d35 = c35 * c35;
            long e35 = d35 * b35;
            Console.WriteLine(e35);





        }
    }
}
