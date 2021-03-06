﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUpgrade : MonoBehaviour
{

    public GameObject aOne, aTwo, aThree, aFour, aFive, aSix, sOne, sTwo, sThree, sFour, sFive, sSix;
    
    void Update()
    {
        int a = Upgrade.mAT;
        int s = Upgrade.mSH;

        ShowUpgrade(a, s);
    }

    public void upShiedld()
    {
        int g = player.gold;
        if (g >= Upgrade.cSH && Upgrade.mSH <= 6)
        {
            player.gold -= Upgrade.cSH;
            Upgrade.moreSH();
        }
    }

    public void upAttack()
    {
        int g = player.gold;
        if (g >= Upgrade.cAT && Upgrade.mAT <= 6)
        {
            player.gold -= Upgrade.cAT;
            Upgrade.moreAT();
        }
    }

    public void upEnergy()
    {
        int g = player.gold;
        if (g >= Upgrade.cEN && Upgrade.mEN <= 6)
        {
            player.gold -= Upgrade.cEN;
            Upgrade.moreEN();
        }
    }

    void ShowUpgrade(int a, int s)
    {
        switch (a)
        {
            case 6:
                aSix.SetActive(true);
                aFive.SetActive(true);
                aFour.SetActive(true);
                aThree.SetActive(true);
                aTwo.SetActive(true);
                aOne.SetActive(true);
                break;
                
            case 5:
                aSix.SetActive(false);
                aFive.SetActive(true);
                aFour.SetActive(true);
                aThree.SetActive(true);
                aTwo.SetActive(true);
                aOne.SetActive(true);   
                break;
			
            case 4:
                aSix.SetActive(false);
                aFive.SetActive(false);
                aFour.SetActive(true);
                aThree.SetActive(true);
                aTwo.SetActive(true);
                aOne.SetActive(true);    
                break;
			
            case 3:
                aSix.SetActive(false);
                aFive.SetActive(false);
                aFour.SetActive(false);
                aThree.SetActive(true);
                aTwo.SetActive(true);
                aOne.SetActive(true);   
                break;
			
            case 2:
                aSix.SetActive(false);
                aFive.SetActive(false);
                aFour.SetActive(false);
                aThree.SetActive(false);
                aTwo.SetActive(true);
                aOne.SetActive(true);    
                break;
			
            case 1:
                aSix.SetActive(false);
                aFive.SetActive(false);
                aFour.SetActive(false);
                aThree.SetActive(false);
                aTwo.SetActive(false);
                aOne.SetActive(true);    
                break;
            case 0:
                aSix.SetActive(false);
                aFive.SetActive(false);
                aFour.SetActive(false);
                aThree.SetActive(false);
                aTwo.SetActive(false);
                aOne.SetActive(false);    
                break;
        }
        
        switch (s)
        {
            case 6:
                sSix.SetActive(true);
                sFive.SetActive(true);
                sFour.SetActive(true);
                sThree.SetActive(true);
                sTwo.SetActive(true);
                sOne.SetActive(true);
                break;
                
            case 5:
                sSix.SetActive(false);
                sFive.SetActive(true);
                sFour.SetActive(true);
                sThree.SetActive(true);
                sTwo.SetActive(true);
                sOne.SetActive(true);   
                break;
			
            case 4:
                sSix.SetActive(false);
                sFive.SetActive(false);
                sFour.SetActive(true);
                sThree.SetActive(true);
                sTwo.SetActive(true);
                sOne.SetActive(true);    
                break;
			
            case 3:
                sSix.SetActive(false);
                sFive.SetActive(false);
                sFour.SetActive(false);
                sThree.SetActive(true);
                sTwo.SetActive(true);
                sOne.SetActive(true);   
                break;
			
            case 2:
                sSix.SetActive(false);
                sFive.SetActive(false);
                sFour.SetActive(false);
                sThree.SetActive(false);
                sTwo.SetActive(true);
                sOne.SetActive(true);    
                break;
			
            case 1:
                sSix.SetActive(false);
                sFive.SetActive(false);
                sFour.SetActive(false);
                sThree.SetActive(false);
                sTwo.SetActive(false);
                sOne.SetActive(true);    
                break;
            case 0:
                sSix.SetActive(false);
                sFive.SetActive(false);
                sFour.SetActive(false);
                sThree.SetActive(false);
                sTwo.SetActive(false);
                sOne.SetActive(false);    
                break;
        }
    }
}
