using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponContainer : MonoBehaviour
{
    public static WeaponContainer instance;

    [SerializeField] private WeaponData[] weapons;

    private void Awake()
    {
        if(instance == null) instance = this;
    }
    public WeaponData ReturnWeapon(int num)
    {
        return weapons[num];
    }
}
