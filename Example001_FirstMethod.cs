// Вид 1
    void Method1();
    {
        Console.WriteLine("Автор Андрей Бородин");
    }
    // Вызываются так:
    Method1();


// Вид 2
    void Method2(string msg)
    {
        Console.WriteLine(msg);
    }
    // Вызываются так:
    Method2("Текст сообщения");


// Вид 3
    int Method3();
    {
        return DateTime.Now.Year;
    }
    //Вызываются так:
    int year = Method3();


// Вид 4
    string Method4(int count, string text)
    {
        int i = 0;
        string result = String.Empty;

        while (i < count)
        {
            result = result + text;
            i++;
        }
        return result;
    }

    string res = Method4(10, "asdf");
    Console.WriteLine(res);