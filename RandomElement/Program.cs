string[] snacks = { "sushi", "Pizza", "Burger", "chicken wings", "Asian takeway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonaight we are going to eat {snacks[randomIndex]}.");
