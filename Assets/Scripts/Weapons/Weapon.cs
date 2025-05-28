using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class Weapon : MonoBehaviour
{
    public WeaponData weapon;

    [SerializeField] Image weaponImage;
    [SerializeField] TextMeshProUGUI weaponName;
    [SerializeField] TextMeshProUGUI weaponDamage;



    private void Start()
    {
        InitWeaponInfo();
    }
    public void WeaponOnClick()
    {
        Player.instance.equipedWeapon = weapon;
        EquipedWeapon.instance.UpdateEquipedWeaponInfo(weapon.weaponImage, weapon.weaponName);
    }
    private void InitWeaponInfo()
    {
        weaponImage.sprite = weapon.weaponImage;
        weaponName.text = weapon.weaponName;
        weaponDamage.text = weapon.damage.ToString();
    }

}
