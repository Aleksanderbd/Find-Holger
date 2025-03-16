var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
var charArray = new char[40];
var gridArray = new string[40];
var random = new Random();
var holgerX = random.Next(40);
var holgerY = random.Next(40);

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
    Console.WriteLine(item);
}
Console.WriteLine(holgerX);
Console.WriteLine(holgerY);