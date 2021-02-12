using System.Collections.Generic;
using UnityEngine;

public class ExampleListT : MonoBehaviour
{
    private void Start()
    {
        List<string> list = new List<string>() { "Длинный", "длинный", "строк" };
        var str = TestList2<string, int>(list);

        Debug.Log(str);
    }
    public static Dictionary<int, int> TestList (List<int> i)
    {
        Dictionary<int, int> tl = new Dictionary<int, int>();
        foreach(int k in i)
        {
            if (!tl.ContainsKey(k))
            {
                tl.Add(k, 1);
            }
            else
            {
                tl[k]++;
            }
        } 
        
        return tl;
    }

    public static Dictionary<T, int> TestList2 <T, value> (List < T > o)
    {
        Dictionary<T, int> tl2 = new Dictionary<T, int>();
        foreach (T k in o)
        {
            if (!tl2.ContainsKey(k))
            {
                tl2.Add(k, 1);
            }
            else
            {
                tl2[k]++;
            }
        }

        return tl2;
    }

}
