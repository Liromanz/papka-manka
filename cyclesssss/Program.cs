/*Console.WriteLine("Сколько ложек сахара вы хотите?");
int num = Convert.ToInt32(Console.ReadLine());

for (int lojki = 1; lojki != num + 1; lojki++)
{
    Console.WriteLine("Добавила " + lojki + " ложек сахара");
}*/

/*for (int i = 1000; i > 0; i = i - 7)
{
    Console.WriteLine(i);
}*/

/*bool isListening;
do
{
    Console.WriteLine("Говорю");
    Console.WriteLine("Меня слушают?");
    isListening = Convert.ToBoolean(Console.ReadLine());
} while (isListening);*/
string colour;
do
{
    Console.WriteLine("Выберите цвет");
    Console.WriteLine("1. Красный");
    Console.WriteLine("2. Черный");
    Console.WriteLine("3. Белый");
    Console.WriteLine("4. Желтый");
    Console.WriteLine("5. никакой не хочу");
    colour = Console.ReadLine();

    if (colour == "1")
    {
        Console.WriteLine("очень красный");
    }
    else if (colour == "2")
    {
        Console.WriteLine("супер черный");
    }
} while (colour != "5");