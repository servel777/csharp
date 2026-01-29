class Porgram
{
    public static void Main(String[] args)
    {
       string bankrecords="""
            DEPOSIT,10000, Initial balance
            DEPOSIT,500, regular deposit
            WITHDRAWAL, 1000, rent
            DEPOSIT,
            2000, freelance payment
            WITHDRAWAL, 300, groceries
            DEPOSIT,
            700, gift from friend
            WITHDRAWAL, 150, utility bill
            DEPOSIT,
            1200, tax refund
            WITHDRAWAL, 500, car maintenance
            DEPOSIT,
            400, cashback reward
            WITHDRAWAL, 250, dining out
            DEPOSIT,
            3000, bonus payment
            WITHDRAWAL, 800, loan repayment
            DEPOSIT,
            600, stock dividends
            WITHDRAWAL, 100, subscription fee
            DEPOSIT,
            1500, side hustle income
            WITHDRAWAL, 200, fuel expenses
            DEPOSIT,
            900, refund from store
            WITHDRAWAL, 350, shopping
            DEPOSIT,
            2500, project milestone payment
            WITHDRAWAL, 400, entertainment    
            """;
    double currentbalance=0.0;
    var reader=new StringReader(bankrecords);

    string? line;
    while((line=reader.ReadLine())is not null)
        {
            if(string.IsNullOrWhiteSpace(line))continue;

            string[]parts=line.Split(',');

            string? transactionType=parts[0]?.Trim();
            if(double.TryParse(parts[1].Trim(),out double amount))
            {
                if(transactionType?.ToUpper() is "DEPOSIT")
                    currentbalance+=amount;
                else if(transactionType?.ToUpper() is "WITHDRAWAL")
                    currentbalance-=amount;
                Console.WriteLine($"{line.Trim()}=>parse amount:{amount},new balance:{currentbalance}");
            }
        }
    }
}