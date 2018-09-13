using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Upgrade
{
    public static int mSH = 0, mEN = 0, mAT = 0;
    public static int cSH = 10, cEN = 10, cAT = 10;

    public static void moreSH()
    {
        mSH = mSH + 1;
        cSH = cSH * 2;
    }

    public static void moreEN()
    {
        mEN = mEN + 1;
        cEN = cEN * 2;
    }

    public static void moreAT()
    {
        mAT = mAT + 1;
        cAT = cAT * cAT;
    }

}
