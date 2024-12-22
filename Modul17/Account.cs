public abstract class Account
{
    public double Balance { get; set; }
    public double Interest { get; protected set; }

    public abstract void CalculateInterest();
}