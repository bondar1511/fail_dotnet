int [] arr= new int [10000];
for (int i = 0; i < arr.length; i++)
{
    arr[1] = Random.Shared.Next(0,30);
}
System.Console.Writeline(string.Join( ' ' , arr));

int [] el = new int [30];
for (int i = 0; i < arr.length; i++) el[arr[i]] += 1;
  for (int i = 0; i < el.length; i++)
  {
    if (el[i]) != 0;
    {
    System.Console.Writeline($"{i} -{el[i]}");
  }  
  }
