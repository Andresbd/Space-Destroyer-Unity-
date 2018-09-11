using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeMenu : MonoBehaviour {

    public int acMultiply;
    public float hpMultiply;
    public float shieldMultiply;
    public float enMultiply;
    public float spdMultiply;

    public static upgradeMenu UM;

    void Awake()
    {

        //Check if Upgrade Menu exists
        if (UM == null)
        {
            DontDestroyOnLoad(gameObject);
            UM = this;
        }
        else if (UM != this)
        {
            Destroy(gameObject);
        }
    }
}
