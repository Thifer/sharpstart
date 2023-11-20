// See https://aka.ms/new-console-template for more information
if (args.Length>0)
{
    int a = Int32.Parse(args[0]);
    int b = Int32.Parse(args[2]);
    string action = args[1];
    float res = action switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" => a / b,
        _ => 0
    };
    Console.WriteLine("Ответ : " + res);
}
else Console.WriteLine("Вы ввели неправильные данные ");