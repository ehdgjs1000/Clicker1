using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponData weaponData;
    private bool isOwned = true;

    public void WeaponOnClick()
    {
        if (isOwned)
        {
            Player.instance.WeaponChange(weaponData);
        }
    }
    /// <summary>
    /// 소유하고 있는 무기 BG Color 변경 (Black -> Color)
    /// </summary>
    public void WeaponBgChange()
    {
        if (isOwned)
        {

        }
    }

}
