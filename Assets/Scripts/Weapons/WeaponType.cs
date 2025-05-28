using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponType : MonoBehaviour
{
    [SerializeField] GameObject[] weaponSets;

    public void WeaponTopOnClick(int num)
    {
        for(int a = 0; a<weaponSets.Length; a ++)
        {
            if(a == num) weaponSets[a].gameObject.SetActive(true);
            else weaponSets[a].gameObject.SetActive(false);
        }
    }
}
