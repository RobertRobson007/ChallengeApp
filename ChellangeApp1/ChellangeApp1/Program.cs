//Zadanie dzień 5

long number = 67895439334780;
string numberAsString = number.ToString();
char[] digist = numberAsString.ToCharArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char digit in digist)
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1')
    {
        counter1++;
    }
    else if(digit == '2')
    {
        counter2++;
    }
    else if (digit == '3')
    { 
        counter3++; 
    }
    else if (digit == '4')
    {
        counter4++;
    }
    else if (digit == '5')
    {
        counter5++;
    }
    else if (digit == '6')
    {
        counter6++;
    }
    else if (digit == '7')
    {
        counter7++;
    }
    else if (digit == '8')
    {
        counter8++;
    }
    else if (digit == '9')
    {
        counter9++;
    }
}

Console.WriteLine("W liczbie: " + number);
Console.WriteLine();
Console.WriteLine("Cyfra 0" + " wystąpiła " + counter0 + " razy");
Console.WriteLine("Cyfra 1" + " wystąpiła " + counter1 + " razy");
Console.WriteLine("Cyfra 2" + " wystąpiła " + counter2 + " razy");
Console.WriteLine("Cyfra 3" + " wystąpiła " + counter3 + " razy");
Console.WriteLine("Cyfra 4" + " wystąpiła " + counter4 + " razy");
Console.WriteLine("Cyfra 5" + " wystąpiła " + counter5 + " razy");
Console.WriteLine("Cyfra 6" + " wystąpiła " + counter6 + " razy");
Console.WriteLine("Cyfra 7" + " wystąpiła " + counter7 + " razy");
Console.WriteLine("Cyfra 8" + " wystąpiła " + counter8 + " razy");
Console.WriteLine("Cyfra 9" + " wystąpiła " + counter9 + " razy");
