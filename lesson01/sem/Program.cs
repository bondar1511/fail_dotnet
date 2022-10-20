int GetItem( int el)
{
    return Random.Shared.Next(0, 30);
}
int  Grouping(int el)
{

return el;

}
var arr = Enumerable.Range(1, 100)
             .Select(GetItem)
             .GroupBy(Grouping)
             .Toarray();
             
             
    foreach (var item in arr)
    {
        System.Console.Writeline($"{item.Key} - {item.Count()}");     
    }

// System.Console.Writeline(String.Join( ' ' , arr));     