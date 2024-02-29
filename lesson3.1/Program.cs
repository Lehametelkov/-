double CalculateFormula(int a, int b, int c, int d)
{
    double  numenator = a * b;
    int denaminator = c * d;
    double result = numenator / denaminator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);