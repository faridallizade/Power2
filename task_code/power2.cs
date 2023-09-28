//TASK 1

//int number, power , powerCopy;
//power = 2;
//powerCopy = power;
//Console.WriteLine("Eded daxil edin: ");
//number = Convert.ToInt32(Console.ReadLine());
//while (number > powerCopy)
//{
//    powerCopy *= 2;
//}
//if(powerCopy == number)
//{
//    Console.WriteLine(number + " ededi " + power + "-in quvvetidir" );
//}
//else
//{
//    Console.WriteLine(number + " ededi " + power + "-in quvveti deyil");
//}

//------------------------------------------
//TASK 2

Console.WriteLine("Tam bir eded daxil edin: ");
int number = Convert.ToInt32(Console.ReadLine());
bool check = true;
int numberCopy = number;
if(number == 1)
{
    check = false;
}
else if(number == 2)
{
    check = true;
}
else if(number % 2 == 0)
{
    check = false;
}
else
{
    for(int bolen = 3; bolen <= numberCopy; bolen++)
    {
        if( numberCopy % bolen == 0)
        {
            check = false;
            break;  
        }
    }
}
if (check)
{
    Console.WriteLine("Sade ededdir");
}
else
{
    Console.WriteLine("Murekkeb ededdir");
}