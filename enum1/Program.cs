using System;
using System.Collections.Generic;
using System.IO;

public class Program1
{
    public enum TransactionType // Corregido: CamelCase
    {
        Deposit,
        Withdrawal,
        Invalid
    }

    static IEnumerable<(TransactionType type, double amount)> TransactionRecords(string inputtext)
    {
        // Limpieza: Une líneas donde el monto quedó abajo (ej: "DEPOSIT,\n 2000")
        string normalized = inputtext.Replace(",\r\n", ",").Replace(",\n", ",");
        var reader = new StringReader(normalized);
        
        string? line;
        while ((line = reader.ReadLine()) is not null) // Corregido: ReadLine
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(',');
            string typeStr = parts[0].Trim().ToUpper();

            // Verificamos que existan al menos dos partes (Tipo y Monto)
            if (parts.Length >= 2 && double.TryParse(parts[1].Trim(), out double amount))
            {
                if (typeStr == "DEPOSIT")
                    yield return (TransactionType.Deposit, amount);
                else if (typeStr == "WITHDRAWAL")
                    yield return (TransactionType.Withdrawal, amount);
                else
                    yield return (TransactionType.Invalid, 0.0);
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
            DEPOSIT,10000, Initial
            DEPOSIT,500
            WITHDRAWAL, 1000
            DEPOSIT,
            2000
            """;

        foreach (var transaction in TransactionRecords(bankrecords))
        {
            // Corregido: Usar el Enum correcto y minúsculas/mayúsculas exactas
            if (transaction.type == TransactionType.Deposit)
                currentBalance += transaction.amount;
            else if (transaction.type == TransactionType.Withdrawal)
                currentBalance -= transaction.amount;

            Console.WriteLine($"{transaction.type,-12} | Amount: {transaction.amount,8} | Balance: {currentBalance,10}");
        }
    }
}