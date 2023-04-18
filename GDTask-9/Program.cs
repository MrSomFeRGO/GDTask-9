Console.WriteLine(shifr_rot13("AZaz23#@"));

static string shifr_rot13(string input)
{
    string output = "";
    foreach (var el in input)
    {
        if (65 <= (int)el && (int)el <= 90)
        {
            int new_char = (int)el + 13;
            if (new_char > 90)
            {
                new_char -= 26;
            }

            output += (char)new_char;
        }
        else if (97 <= (int)el && (int)el <= 122)
        {
            int new_char = (int)el + 13;
            if (new_char > 122)
            {
                new_char -= 26;
            }

            output += (char)new_char;
        }
        else
        {
            output += el;
        }
    }

    return output;
}