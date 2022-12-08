using System.ComponentModel.DataAnnotations;

int chislo = int.Parse(Console.ReadLine());
int k1 = -1;
int k2 = -1;
int k3 = -1;
while (chislo>10)
{
    k1 = k2;
    k2 = k3;
    k3 = chislo % 10;
    chislo = chislo / 10;
}
if (k1 < 0)
{
    Console.WriteLine("Третьего числа нет");
}
else {
    Console.WriteLine(k2);
}
