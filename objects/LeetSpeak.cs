using System.Collections.Generic;

namespace LeetSpeakNS.Objects
{
  public class LeetSpeak
  {
    public LeetSpeak()
    {

    }

    public static string Translate(string english)
    {
      char[] array = english.ToCharArray();
      for (var i = 0; i < array.Length; i++)
      {
        if (array[i] == 'e')
        {
          array[i] = '3';
        }
      }
      string result = string.Join("", array);
      return result;
    }

  }
}
