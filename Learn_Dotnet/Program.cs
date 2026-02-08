using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn_Dotnet
{
  class Program
  {
    public static void Main(string[] args)
    {
      DateTime the_date = new DateTime(2030, 4, 1);
      Console.WriteLine(FormatDateTime(the_date));
      string[] strs = new string[] { "hello", "world" };
      Console.WriteLine(FormatJoinStrings(strs));
    }

    public static string FormatDateTime(DateTime the_date)
    {
      return the_date.ToString("yyyy--M--d");
    }

    public static string FormatJoinStrings(string[] strs)
    {
      return string.Join(".", strs).ToUpper();
    }
  }
}