using System;

class Program
{
    static void Main(string[] args)
    {
        // Uncomment the part you want to test and comment others
        //---------------------------------------------------------------------
        // Part 1: Create variables of different types, assign values to them, and print them to the console

        // int variable
        int enemy_health = 100;
        Console.WriteLine("Enemy Health: " + enemy_health);

        // double variable
        double game_currency = 2500.50;
        Console.WriteLine("Game Currency: " + game_currency);

        // string variable
        string player_name = "John Doe";
        Console.WriteLine("Player Name: " + player_name);

        // bool variable
        bool isalive = true;
        Console.WriteLine("Is Alive: " + isalive);

        // char variable
        char patrol_state = 'S';  // 'S' for "Standby"
        Console.WriteLine("Patrol State: " + patrol_state);

        // byte variable
        byte player_age = 25;
        Console.WriteLine("Player Age: " + player_age);

        // long variable
        long score = 1000000000;
        Console.WriteLine("Score: " + score);

        // decimal variable
        decimal price = 100.50M;  // M is used for decimal literal
        Console.WriteLine("Price: " + price);

        // null variable (nullable type)
        int? null_variable = null;  // Nullable int
        Console.WriteLine("Null Variable: " + null_variable);

        // float variable
        float speed = 100.50F;  // F is used for float literal
        Console.WriteLine("Speed: " + speed);

        //---------------------------------------------------------------------

        // Part 17: Declaration of Constants
        const double Pi = 3.14159;
        Console.WriteLine("Pi: " + Pi);

        // Part 18: Declaration of Constants
        const string CompanyName = "ABC Corporation";
        Console.WriteLine("Company Name: " + CompanyName);

        // Part 19: Declaration of Constants
        const int MaxRetries = 3;
        Console.WriteLine("Max Retries: " + MaxRetries);

        // Part 20: Declaration of Constants
        const double Gravity = 9.8;
        Console.WriteLine("Gravity: " + Gravity);

        // Part 21: Declaration of Constants
        const int MonthsInYear = 12;
        Console.WriteLine("Months in Year: " + MonthsInYear);
    }
}
