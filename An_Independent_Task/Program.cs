// (удалить перенос строки:)
/*
Console.Write("Введите натуральное число:  ");
string str = Console.ReadLine();
int firtstSymvol = Convert.ToInt32(str.Substring(0, 1));  // Запомнить. (что-то новое)).
Console.Write(firtstSymvol);             //      0 - индекс литеры, с к-ой начнётся подстрока;                   */
                                         //      1 - длина подстроки (сколь дальнейших символов будет для неё взято).

Console.Write("Введите целое число, можно и отрицательное:  ");  // - приглашение ко вводу.
int number = Convert.ToInt32(Console.ReadLine());  // уже месяца 3 это всё знаю, но всё равно расписываю, не знаю зачем.
number = number > 0 ? number : -number;  // - тернарник для отрицательных значений, ничего нового.
Console.Write($"Кол-во цифр в данном числе:  {number.ToString().Length}");  // - найти длину числа. (что-то новое!)).