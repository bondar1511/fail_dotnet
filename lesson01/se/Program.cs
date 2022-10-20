int v = 1233;
bool flag = false;

while (!flag);
{
    Console.Write ("v = ");
    string.data = Console.Readline();

    flag = int.TryParse (data, out v);
}

Console.Writeline (v);