static void GetSentence(string userSentence)
{
    string[] array = { userSentence };

}
static string GetSpliteUserSentences(string userSentence)
{
    string[] array = userSentence.Split(' ');
    foreach (var arr in array)
    {
        Console.WriteLine(arr);
    }

    return array[0];
}


Console.WriteLine("Введите предложение");
string userSentence = Console.ReadLine();

GetSpliteUserSentences(userSentence);