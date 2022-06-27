while (true)
{
    Console.WriteLine("Please enter a word");

    string input = Console.ReadLine();
    if (input == "")
    {
        Console.WriteLine("Please enter text to translate");
        continue;
    }

    char first = input[0];
    char[] letterBank = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    if (letterBank.Contains(first))
    {
        ConvertVowel(ref input);
    }

    else // starts with consonant     
    {
        ConsonantConvert(ref input);
    }

    Console.WriteLine("Do you want to translate another word? y/n ");
    string restart = Console.ReadLine().ToLower();
    if (restart == "yes" || restart == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("thanks for playing!");
        break;
    }
}

static string ConvertVowel(ref string input)
{
    string newWord = (input + "way");
    Console.WriteLine(newWord);
    return newWord;

}

static void ConsonantConvert(ref string input) // does variable name after ref have to match? 
{
    int vowelPosition = -1; // keeping track of where my first vowel is; starting at -1 so it gets to 0 with first loop through
    string newStart = ""; // first letters of the new word 
    string moveThis = ""; // the chunk of letters i need to move 

    char[] letterBank = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    foreach (char letter in input)
    {
        vowelPosition++;

        if (letterBank.Contains(letter))
        {
            moveThis = input.Substring(0, vowelPosition); // saves the letters to be moved as its own string 

            int remainingLetters = (input.Length - moveThis.Length); // to make sure all remaining letters are accounted for after I substring out "move this"

            newStart = input.Substring(vowelPosition, remainingLetters); // this starts at vowel position, and takes all remaining letters as rest of substring

            string newWord = (newStart + moveThis + "ay");
            Console.WriteLine(newWord);
            break; // exit the loop once we find the first vowel 
        }
    }

}

// found potential addition to loop - user enters string of characters without a vowel 

