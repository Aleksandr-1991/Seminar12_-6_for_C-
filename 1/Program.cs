Console.Write("Введите натуральное число:  ");
string str = Console.ReadLine();
int firtstSymvol = Convert.ToInt32(str.Substring(0, 1));
Console.Write(firtstSymvol);