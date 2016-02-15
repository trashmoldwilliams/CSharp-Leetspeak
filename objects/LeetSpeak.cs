using System.Collections.Generic;
using System;

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
      Dictionary<char, char> tests = new Dictionary<char, char> {};
      tests.Add('e', '3');
      tests.Add('E', '3');
      tests.Add('o', '0');
      tests.Add('O', '0');
      tests.Add('I', '1');
      tests.Add('t', '7');
      tests.Add('T', '7');
      tests.Add('s', 'z');
      tests.Add('S', 'Z');
      for (var i = 0; i < array.Length; i++)
      {
        foreach( KeyValuePair<char,char> test in tests )
        {
          if( Char.ToLower(test.Key) != 's' || i > 0 )
          {
            if( array[i] == test.Key)
            {
              array[i] = test.Value;
            }
          }
        }
        /*
        if ( Char.ToLower(array[i]) == 'e' )
        {
          array[i] = '3';
        } else if( Char.ToLower(array[i]) == 'o' )
        {
          array[i] = '0';
        } /**/
      }
      string result = string.Join("", array);
      return result;
    }

  }
}
