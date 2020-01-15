using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFieldSlotComparerscript : IComparer<GameObject>
{
    public int Compare(GameObject x, GameObject y)
    {
        int position = x.name.IndexOf("(");
        int position2 = x.name.IndexOf(")");
        int position3 = y.name.IndexOf(")");
        int numberx = Convert.ToInt32(x.name.Substring(position + 1, position2 - position - 1));
        int numbery = Convert.ToInt32(y.name.Substring(position + 1, position3 - position - 1));
        return numberx.CompareTo(numbery);
    }
}
