


/*
try
{
    int first = 0;
    int second = 0;

    int result = first / second;
}
catch (Exception excp)
{
    Console.WriteLine("Divide by zero error :\n"+excp.ToString());
}
finally
{
    Console.WriteLine("\nWe got an error and need to change the logic here");
}
*/


try
{
    DivideZero();
}
catch (Exception excp)
{
    Console.WriteLine(excp.StackTrace);
}

void DivideZero()
{
    try
    {
        int first = 0;
        int second = 0;

        int result = first / second;
    }
    catch (Exception excp)
    {
        throw excp;
    }
}
