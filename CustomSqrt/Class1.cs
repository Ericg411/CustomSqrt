namespace CustomSqrt;
public class Class1
{
    public int MySqrt(int x)
    {
        double counter = 0;

        while (counter * counter <= x)
        {
            if (counter * counter <= x && (counter + 1) * (counter + 1) > x)
            {
                return (int)counter;
            }
            counter += 1;
        }

        return (int)counter;
    }
}
