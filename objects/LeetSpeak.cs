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
      bool ignore = false;
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
      tests.Add('g', '9');
      tests.Add('G', '9');
      tests.Add('l', '1');

      for (var i = 0; i < array.Length; i++)
      {
        if( array[i] == '\'' )
        {
          if(ignore) ignore = false;
          else ignore = true;
        } else if(!ignore) {

          foreach( KeyValuePair<char,char> test in tests )
          {
            if( (Char.ToLower(test.Key) != 's' || i > 0) )
            {
              if( array[i] == test.Key)
              {
                array[i] = test.Value;
              } // end if array test
            } // end if first character s
          } // end foreach
        } // end if ignore
        /**/
      } // end for loop
      string result = string.Join("", array);
      return result;
    } // end Translate method

  } // end class
} // end namespace
