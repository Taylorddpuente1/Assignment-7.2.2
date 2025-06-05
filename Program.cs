//Given a string s, reverse only all the vowels in the string and return it.
using System.Reflection.PortableExecutable;

public class Program
{
    static string ReverseVowels(string s)
    {
        if (string.IsNullOrEmpty(s))
            return s;

        char[] chars = s.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;

        while (left < right)
        {
            // move left until vowel is found 
            while (left < right && !IsVowel(chars[left]))
                left++;
            // move right until vowel if found

            while (right < left && !IsVowel(chars[right]))
                right--;



            // swap vowels
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;

            left++;
            right--;
        }
        return new string(chars);
    }
    public static bool IsVowel(char c)
    {
        c = Char.ToLower(c);  // convers to lowercase
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
    public static void Main()
    {
        Console.WriteLine(ReverseVowels("hello"));      
        Console.WriteLine(ReverseVowels("avacado"));    
        Console.WriteLine(ReverseVowels("intelligent")); 
    }
}
