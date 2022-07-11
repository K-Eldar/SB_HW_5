static string GetSentence(string userSentence)
{
    string[] array = userSentence.Split(' ');
    string ReverseUserSentence = ReverseWord(array);
    return ReverseUserSentence;
}
static string ReverseWord(string[] userSentence) // 
{
    Array.Reverse(userSentence);
    string str = string.Join(" ", userSentence);
    return str;
}


Console.WriteLine("Введите предложение: ");

string text = Console.ReadLine();

text = GetSentence(text);


Console.WriteLine(text);
Console.ReadLine();