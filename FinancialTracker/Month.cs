namespace FinancialTracker;

class Month
{
    public Month(List<int> expences, List<int> income, string monthName)
    {
        Expences = expences;
        Income = income;
        MonthName = monthName;
    }

    public List<int> Expences { get; set; }
    public List<int> Income { get; set; }
    public string MonthName {  get; set; }

}