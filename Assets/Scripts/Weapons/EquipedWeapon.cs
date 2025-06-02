using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquipedWeapon : MonoBehaviour
{
    public static EquipedWeapon instance;
    [SerializeField] Image equipedWeaponImage;
    [SerializeField] TextMeshProUGUI euqipedWeaponName;

    private void Awake()
    {
        if(instance == null) instance = this;
    }
    private void Start()
    {
        //초기 설정
        if (Player.instance.equipedWeapon != null)
        {
            UpdateEquipedWeaponInfo(Player.instance.equipedWeapon.weaponImage,
            Player.instance.equipedWeapon.weaponName);
        }
    }
    public void UpdateEquipedWeaponInfo(Sprite _image, string _weaponName)
    {
        equipedWeaponImage.sprite = _image;
        euqipedWeaponName.text = _weaponName;
    }
}
