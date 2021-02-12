using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Example
{
    static void Main(string[] args)
    {

        string str = "Длинный длинный строк";
        char c = ' ';
        Debug.Log(StringExtension.CharCount(str, c));
    }
}

public static class StringExtension
{
    public static int CharCount(this string str, char c)
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != c)
            {
                counter++;
            }

        }
        return counter;
    }
}


