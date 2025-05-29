using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WeaponPanel : MonoBehaviour
{
    public static WeaponPanel instance;

    public bool isOpen = false;
    [SerializeField] Weapon[] axeWeapons;
    [SerializeField] Weapon[] hammerWeapons;
    [SerializeField] Weapon[] bowWeapons;
    [SerializeField] Weapon[] daggerWeapons;
    [SerializeField] Weapon[] staffWeapons;
    private void Awake()
    {
        if(instance == null) instance = this;
    }

    public void WeaponCloseOnClick()
    {
        isOpen = false;
        BottomCtrl.instance.isWeaponPanelOn = false;
        this.transform.DOMoveY(-650, 0.5f);
    }
    public void WeaponBgUpdate()
    {
        for (int i = 0; i < axeWeapons.Length; i++)
        {
            if(HaveWeaponInfo.instance.axeInfo[i] != 0 )axeWeapons[i].BackGroundUpdate(true);
        }
        for (int i = 0; i < hammerWeapons.Length; i++)
        {
            if (HaveWeaponInfo.instance.hammerInfo[i] != 0) hammerWeapons[i].BackGroundUpdate(true);
        }
        for (int i = 0; i < bowWeapons.Length; i++)
        {
            if (HaveWeaponInfo.instance.bowInfo[i] != 0) bowWeapons[i].BackGroundUpdate(true);
        }
        for (int i = 0; i < daggerWeapons.Length; i++)
        {
            if (HaveWeaponInfo.instance.daggerInfo[i] != 0) daggerWeapons[i].BackGroundUpdate(true);
        }
        for (int i = 0; i < staffWeapons.Length; i++)
        {
            if (HaveWeaponInfo.instance.staffInfo[i] != 0) staffWeapons[i].BackGroundUpdate(true);
        }
    }

}
