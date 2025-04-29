Console.Write("Customer name: ");
string name = Console.ReadLine();
Console.Write("Units Consumed: ");
double units = Convert.ToDouble(Console.ReadLine());

double total = CalculateBill(units);
Console.WriteLine($"{name}'s bill total is {total.ToString("C2")}");

double CalculateBill(double d)
{
    switch(d)
    {
        case < 200: return d * 1.2;
        case < 400: return 238.8 + (d - 199) * 1.5;
        case < 600: return 238.8 + 300 + (d - 399) * 1.8;
        default: return 238.8 + 300 + 360 + (d - 599) * 2;
    }
}