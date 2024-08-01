FileStream file = null;

try
{
    double n1, n2, division;
    Console.WriteLine("Ingrese N1");
    n1=double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese N2");
    n2 = double.Parse(Console.ReadLine());

    division= n1/n2;
    Console.WriteLine($ "La division es { division}");
} catch(Exception e)
{
    Console.WriteLine(e.Message);
}