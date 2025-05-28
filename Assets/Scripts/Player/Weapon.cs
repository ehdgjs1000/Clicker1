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
    /// �����ϰ� �ִ� ���� BG Color ���� (Black -> Color)
    /// </summary>
    public void WeaponBgChange()
    {
        if (isOwned)
        {

        }
    }

}
