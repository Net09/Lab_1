//Console.Write($"{Math.PI:F2}");
//Console.WriteLine($"{Math.E:F1}");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число {a}");

//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"{a} - Вот такое число ввели");
//Console.WriteLine("1 13 49");
//Console.WriteLine("7  15  100");
//try
//{

//    Console.WriteLine("Введите a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    double d = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
//    Console.WriteLine($"{d:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message );
//}
//try
//{
//    Console.WriteLine("Введите радиус");
//    double R = double.Parse(Console.ReadLine());
//    double D = 2 * R;
//    Console.WriteLine($" Диаметр окружности:{D:F2}");


//        }
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.WriteLine("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double z = (x + ((2 + y) / x * x)) / (y + (1 / Math.Sqrt(x * x + 10)));
//    Console.WriteLine($"z=:{z:F2}");
//    double q = 2.8 * Math.Sin(x) + Math.Abs(y);
//    Console.WriteLine($"q={z:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.WriteLine("Введите количество саниметров");
//    int sm = int.Parse(Console.ReadLine());
//    int m = sm / 100;
//    Console.WriteLine($"Полных метров{m}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine (ex.Message);
//}

//try
//{
//    Console.WriteLine("Введите количество килограмм");
//    int kg = int.Parse(Console.ReadLine());
//    int t = kg  / 1000;
//    Console.WriteLine($"полных тонн{t}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine (ex.Message );
//}

//try
//{
//    Console.WriteLine("Введите количество килограмм");
//    int kg = int.Parse(Console.ReadLine());
//    int cwq = kg / 100;
//    Console.WriteLine($"Полных центнеров{cwq}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine (ex.Message );
//}

//try
//{
//    Console.WriteLine("Введите количество метров");
//    int m = int.Parse(Console.ReadLine());
//    int km = m / 1000;
//    Console.WriteLine($"полных километров{km}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine (ex.Message);
//}
//try
//{
//    Console.WriteLine("Введите колечество секунд");
//    int n = int.Parse(Console.ReadLine());
//    int hour = n / 3600;
//    int minute = n % 3600 / 60;
//    int second = n % 3600 % 60;
//    Console.WriteLine($"{hour}:{minute}:{second}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine (ex.Message);
//}

//try
//{
//    Console.WriteLine("Введите четырехзначтое число");
//    int n = int.Parse(Console.ReadLine());
//    int a = n % 10;
//    int b = n % 100 / 10;
//    int c = n % 1000 / 100;
//    int d = n / 1000;
//    int s = a + b + c + d;
//    Console.WriteLine(s);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}