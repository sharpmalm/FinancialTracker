namespace FinancialTracker;

class Expences
{
    public Expences(int amount, DateTime date, string description)
    {
        Amount = amount;
        Date = date;
        Description = description;

    }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"{Amount},{Date},{Description}";
    }

}