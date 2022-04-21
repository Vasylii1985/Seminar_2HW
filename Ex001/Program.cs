// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число: ");
int number =  Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

