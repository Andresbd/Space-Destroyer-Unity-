using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Upgrade
{
    public static int mSH, mEN, mAT;
    public static int cSH = 10, cEN = 10, cAT = 10;

    public static void moreSH()
    {
        mSH += 1;
        cSH = cSH * 2;
    }

    public static void moreEN()
    {
        mEN += 1;
        cEN = cEN * 2;
    }

    public static void moreAT()
    {
        mAT += 1;
        cAT = cAT * 2;
    }

}
