using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Upgrade
{
    public static int mHP, mSH, mEN, mAT;
    public static int cHP, cSH, cEN, cAT;

    public static void moreHP()
    {
        cHP = cHP * 2;
    }

    public static void moreSH()
    {
        cSH = cSH * 2;
    }

    public static void moreEN()
    {
        cEN = cEN * 2;
    }

    public static void moreAT()
    {
        cAT = cAT * cAT;
    }

}
