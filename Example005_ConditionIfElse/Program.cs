Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "Маша")
{
    //Console.ReadLine("Ура, это же МАША");
    Console.WriteLine("Ура, это же Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}