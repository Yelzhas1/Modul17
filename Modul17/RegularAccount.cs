public class RegularAccount : Account
{
    public override void CalculateInterest()
    {
        Interest = Balance * 0.4;

        if (Balance < 1000)
        {
            Interest -= Balance * 0.2;
        }
        else if (Balance >= 1000)
        {
            Interest -= Balance * 0.4;
        }
    }
}