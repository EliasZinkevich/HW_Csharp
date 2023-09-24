Console.WriteLine("Здравствуйте, меня зовут Глаша. ");
Console.WriteLine("А как Вас зовут?");
string username = Console.ReadLine();
Console.Write("Очень приятно, ");
Console.Write(username);
Console.WriteLine(". Вы хотите посчитать сумму двух чисел? Введите да или нет");
string decision = Console.ReadLine();
if(decision.ToLower() == "да")
{
    Console.WriteLine("Пожалуйста, введите первое число");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("А теперь введите второе число");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int result = numberA + numberB;
    Console.Write("Сумма Ваших чисел = ");
    Console.Write(result);
}
else if(decision.ToLower() == "нет")
{
    Console.WriteLine("Очень жаль =(");
}
else Console.WriteLine("Ну я же просила, ну че ты...");

