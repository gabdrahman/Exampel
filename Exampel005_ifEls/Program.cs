Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "марсель")
{
    Console.WriteLine("Ура, это же Марсель!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}