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
    public void UpdateEquipedWeaponInfo(Sprite _image, string _weaponName)
    {
        equipedWeaponImage.sprite = _image;
        euqipedWeaponName.text = _weaponName;
    }
}
