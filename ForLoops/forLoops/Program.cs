//int counter =  0;
//do
//{

//    Console.WriteLine($"Counter: {counter}");
//    counter++;
//} while (counter < 10);



//for (int counter = 0; counter < 10; counter++)
//if (counter >= 5)
//        {
//    Console.WriteLine($"Counter: {counter} is greater than or equal to 5");
//}
//    else if (counter <= 5)
//    {
//    Console.WriteLine($"Counter : {counter} tutaj jest mnijszy i ttoo");
//} else if (counter <3)
//{
//    Console.WriteLine("michal is crazy ");
//}


//for (int i = 0; i<7;i++)
//{
//    if (i==3)
//    {

//    }
//    Console.WriteLine(i);
//}

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}