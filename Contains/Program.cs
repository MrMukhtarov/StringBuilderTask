using Containss.Builder;
using System;
using System.Text;
//string word = Console.ReadLine();
//char find = 'a';
//bool Contains(string word,char find)
//{
//    for(int i = 0; i < word.Length; i++)
//    {
//        if (word[i] == find)
//        {
//            return true;
//        }
//    }
//    return false;
//}
//Console.WriteLine(Contains(word,find));



//string word = "Hello World";
//string word2 = "ella";
#region Contains
//bool Contains(string word, string word2)
//{
//    for (int i = 0; i <= word.Length - word2.Length; i++)
//    {
//        bool match = true;
//        for (int j = 0; j < word2.Length; j++)
//        {
//            if (word[i + j] != word2[j])
//            {
//                match = false;
//                break;
//            }
//        }
//        if (match)
//        {
//            return true;
//        }
//    }
//    return false;
//}
//Console.WriteLine(Contains(word, word2));
#endregion
#region Remove
/*string str = "Hello World";
//Console.WriteLine(str.Remove(-2));
string Remove(string str, int startIndex)
{
    string newStr = string.Empty;
    if (startIndex > 0)
    {
        for (int i = 0; i < startIndex; i++)
        {
            newStr += str[i];
        }
    }
    else
    {
        throw new Exception("startIndex cannot be less than zero");
    }
    return newStr;
}
Console.WriteLine(Remove(str, -2));*/

//string str = "Nicat";
//int count = 2;
//int startindex = 2;
//string Remove(string str, int count, int startIndex)
//{
//    string newStr = string.Empty;
//    for (int i = 0; i < str.Length; i++)
//    {
//        if (i < startIndex || i >= startindex + count)
//        {
//            newStr += str[i];
//        }
//    }
//    return newStr;
//}
//Console.WriteLine(Remove(str, count, startindex));
#endregion


#region StringBuilder
StringBuilder sb = new StringBuilder();
sb.Append('a');
sb.Append('a');
sb.Append('a');
Console.WriteLine(sb);

CustomBuilder cb = new CustomBuilder();
cb.Append('a');
cb.Append('b');
cb.Append('c');
//Console.WriteLine(cb.Length);
//cb.Remove(1, 1);
Console.WriteLine(cb);
#endregion

//DateTime date1 = new DateTime(2023, 4, 30,7,28,22);
//Console.WriteLine(date1.ToString());
//Console.WriteLine(DateTime.MinValue);
//Console.WriteLine(DateTime.MaxValue);

System.TimeSpan duration = new System.TimeSpan(30, 0, 0, 0);
System.DateTime newDate1 = DateTime.Now.Add(duration);
System.Console.WriteLine(newDate1); // 1/19/2016 11:47:52 AM 

// Adding days to a date  
DateTime today = DateTime.Now; // 12/20/2015 11:48:09 AM  
DateTime newDate2 = today.AddDays(30); // Adding one month(as 30 days)  
Console.WriteLine(newDate2); // 1/19/2016 11:48:09 AM

string date = "Wed Dec 30, 2015";
DateTime datetime = DateTime.Parse(date);
Console.WriteLine(datetime);

DateTime todays = DateTime.Now;
bool equal = todays.DayOfWeek == DayOfWeek.Sunday;
Console.WriteLine(equal);
