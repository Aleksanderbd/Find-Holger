// Main holger variables
var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
var charArray = new char[40];
var gridArray = new string[40];
var random = new Random();
var holgerX = random.Next(40);
var holgerY = random.Next(40);

// Farve array  
ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.Cyan, ConsoleColor.White, ConsoleColor.DarkRed, ConsoleColor.DarkGreen, ConsoleColor.DarkBlue, ConsoleColor.DarkYellow, ConsoleColor.DarkMagenta, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.Gray };

// Loop that makes the grid.
for (int i = 0; i < gridArray.Length; i++)
    
{   
        // Loop that makes string of random char.
        for (int j = 0; j < charArray.Length; j++)
        {
            if (j == holgerX && i == holgerY)
        {
            charArray[j] = '@';
        }
        else
            charArray[j] = chars[random.Next(chars.Length)];

        }
    // Converts charArray to string.
    var finalString = new String(charArray);
    gridArray[i] = finalString;
}

// Loop that prints out the grid.
foreach (var item in gridArray)
{   
    foreach (char c in item)
    {   
        // Random color for letters.
        Console.ForegroundColor = colors[random.Next(colors.Length)];
        Console.Write(c);
    }
    Console.ResetColor();
    Console.WriteLine();
}
Console.WriteLine(holgerX);
Console.WriteLine(holgerY);