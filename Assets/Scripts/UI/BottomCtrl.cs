using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BottomCtrl : MonoBehaviour
{
    [SerializeField] private GameObject weaponPanel;

    public void WeaponBtnOnClick()
    {
        weaponPanel.transform.DOMoveY(650,0.5f);
    }
}
