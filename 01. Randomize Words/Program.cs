string[] words = Console.ReadLine().Split().ToArray() ;

Random random = new Random();

for (int i = 0; i < words.Length; i++)
{
    int randomIndex = random.Next(0, words.Length);
    string tempWord = words[i];
    words[i] = words[randomIndex];
    words[randomIndex] = tempWord;
}

Console.WriteLine(string.Join(Environment.NewLine, words));
