using System.Text;

string? stringValue = Console.ReadLine();

Console.WriteLine(MyAtoi(stringValue)); 
Console.ReadLine();


 static int MyAtoi(string? stringValue)
{
    string removedSpace = string.Join(" ", stringValue.Split(new char[] { ' ' }, 
        StringSplitOptions.RemoveEmptyEntries));
    char[] array = removedSpace.ToCharArray();
    StringBuilder sb = new StringBuilder(); 
    for(int i = 0; i < array.Length; i++)
    {
        if (Char.IsDigit(array[i]) || array[i]=='-')
        {
            sb.Append(array[i]);
        }
    }
    int integerValue = Convert.ToInt32(sb.ToString()); 
    return integerValue;
}