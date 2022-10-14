//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84,A (7,-5, 0); B (1,-1,9) -> 11.53

double GetValue (string text);
{
Console.Write(text + ":");
double value = Convert.Todoudle (Console.Readline());
return  value;
}

void Print (double ax, doudle ay, double bx, doudle by, double az, doudle bz);
{

    string output ="|A(" + ax + ", " + ay + ", " + az + "); B("+ bx + ", " + by + "," + bz + ")|  = " + result;

       Console.Writeline (output);
double GetDistance (double ax, doudle ay, double bx, doudle by, double az, doudle bz);
double x = Math.Pow(ax -bx, 3);
double y = Math.Pow(ay -by, 3);
double z = Math.Pow(az -bz, 3);
double result = Math.Pow(var,(1.0/3.0));
return  result;
}
Sistem.Console.Writeline(CetDistance(3,6,8,2,1,-7));