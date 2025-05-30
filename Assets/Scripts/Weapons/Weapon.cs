using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class Weapon : MonoBehaviour
{
    public WeaponData weapon;

    [SerializeField] Image weaponImage;
    [SerializeField] GameObject weaponBg;
    [SerializeField] TextMeshProUGUI weaponName;
    [SerializeField] TextMeshProUGUI weaponDamage;

    private void Start()
    {
        InitWeaponInfo();
    }
    public void WeaponOnClick()
    {
        Debug.Log("WeaponType : " + weapon.weaponType + "WeaponGrade : " + weapon.weaponGrade + 
            " have : " + HaveWeaponInfo.instance.CheckHaveWeapon(weapon.weaponType, weapon.weaponGrade));
        if (HaveWeaponInfo.instance.CheckHaveWeapon(weapon.weaponType, weapon.weaponGrade) != 0)
        {
            Player.instance.equipedWeapon = weapon;
            EquipedWeapon.instance.UpdateEquipedWeaponInfo(weapon.weaponImage, weapon.weaponName);
        }
    }
    private void InitWeaponInfo()
    {
        weaponImage.sprite = weapon.weaponImage;
        weaponName.text = weapon.weaponName;
        weaponDamage.text = weapon.damage.ToString();
    }
    public void BackGroundUpdate(bool _haveWeapon)
    {
        if(_haveWeapon == true)
        {
            weaponBg.SetActive(false);
        }
        else
        {
            weaponBg.SetActive(true);
        }
    }

}
