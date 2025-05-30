using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BottomCtrl : MonoBehaviour
{
    public static BottomCtrl instance;

    [SerializeField] private GameObject weaponPanel;
    [SerializeField] private GameObject storePanel;
    [SerializeField] private GameObject upgradePanel;
    public bool isWeaponPanelOn = false;
    public bool isStorePanelOn = false;
    public bool isUpgradePanelOn = false;

    private void Awake()
    {
        if(instance == null) instance = this;
    }

    public void WeaponBtnOnClick()
    {
        isWeaponPanelOn = true;
        WeaponPanel.instance.isOpen = true;
        WeaponPanel.instance.WeaponBgUpdate();
        if (isStorePanelOn)
        {
            storePanel.transform.DOMoveY(-650, 0.5f);
            isStorePanelOn = false;
        }
        if (isUpgradePanelOn)
        {
            upgradePanel.transform.DOMoveY(-650, 0.5f);
            isUpgradePanelOn = false;
        }
        weaponPanel.transform.DOMoveY(650,0.5f);
    }
    public void StoreBtnOnClick()
    {
        isStorePanelOn = true;
        if(isWeaponPanelOn)
        {
            weaponPanel.transform.DOMoveY(-650, 0.5f);
            isWeaponPanelOn=false;
        }
        if (isUpgradePanelOn)
        {
            upgradePanel.transform.DOMoveY(-650, 0.5f);
            isUpgradePanelOn = false;
        }
        storePanel.transform.DOMoveY(650, 0.5f);
    }
    public void UpgradeBtnOnClicl()
    {
        isUpgradePanelOn = true;
        if (isWeaponPanelOn)
        {
            weaponPanel.transform.DOMoveY(-650, 0.5f);
            isWeaponPanelOn = false;
        }
        if (isStorePanelOn)
        {
            storePanel.transform.DOMoveY(-650, 0.5f);
            isStorePanelOn = false;
        }
        upgradePanel.transform.DOMoveY(650, 0.5f);

    }
}
