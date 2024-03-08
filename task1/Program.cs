double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double rezult = numenator / denomenator;
    return rezult;
}
double rezult = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(rezult);