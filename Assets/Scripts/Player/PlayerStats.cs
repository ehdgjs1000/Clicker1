using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;

    public int[] upgradeLevel = new int[] {0,0,0,0};
    public float[] upgradeAmount = new float[] {0,0,5,1};

    private void Awake()
    {
        if (instance == null) instance = this;

        SavePlayerPrefabs.instance.LoadUpgrade();
    }


}
