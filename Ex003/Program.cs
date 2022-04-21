//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) 
{
    txtResult = $". Ура! Это выходной день!";
}
else 
{
    txtResult = $", рабочий день.";
    Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
}

