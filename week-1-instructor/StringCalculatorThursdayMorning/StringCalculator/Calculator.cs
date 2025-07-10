
public class Calculator
{
    public int Add(string numbers)
    {
        List<char> delimeters = [',', '\n'];

        if (numbers == "")
        {
            return 0;
        }

        if(numbers.StartsWith("//"))
        {

            var delimeter = numbers[2];
            delimeters.Add(delimeter);
            numbers = numbers.Substring(4);
           
        }
 
        return numbers.Split(delimeters.ToArray()) //string[]
             .Select(int.Parse) // int[]
             .Sum();


    }
}
