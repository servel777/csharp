using System;
using System.Collections.Generic;
using System.IO;

public class Program1
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Invalid
    }

    static IEnumerable<(TransactionType type, double amount)> TransactionRecords(string inputtext)
    {
        // Limpieza de saltos de línea después de la coma
        string normalized = inputtext.Replace(",\r\n", ",").Replace(",\n", ",");
        using var reader = new StringReader(normalized);
        
        string? line;
        while ((line = reader.ReadLine()) is not null)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(',');
            if (parts.Length < 2) 
            {
                yield return (TransactionType.Invalid, 0.0);
                continue;
            }

            string typeStr = parts[0].Trim().ToUpper();
            bool isAmountValid = double.TryParse(parts[1].Trim(), out double amount);

            if (isAmountValid)
            {
                var type = typeStr switch
                {
                    "DEPOSIT" => TransactionType.Deposit,
                    "WITHDRAWAL" => TransactionType.Withdrawal,
                    _ => TransactionType.Invalid
                };
                yield return (type, amount);
            }
            else
            {
                yield return (TransactionType.Invalid, 0.0);
            }
        }
    }

    public static void Main(string[] args)
    {
        double currentBalance = 0.0;
        string bankrecords = """
            DEPOSIT,10000
            DEPOSIT,500
            WITHDRAWAL, 1000
            DEPOSIT,
            2000
            """;

        Console.WriteLine($"{"Type",-12} | {"Amount",8} | {"Balance",10}");
        Console.WriteLine(new string('-', 35));

        foreach (var transaction in TransactionRecords(bankrecords))
        {
            // Usamos un switch expression para actualizar el balance de forma limpia
            currentBalance += transaction switch
            {
                (TransactionType.Deposit, var amount) => amount,
                (TransactionType.Withdrawal, var amount) => -amount,
                _ => 0.0
            };

            Console.WriteLine($"{transaction.type,-12} | {transaction.amount,8} | {currentBalance,10}");
        }
    }
}