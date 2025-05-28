using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WeaponPanel : MonoBehaviour
{
    public void WeaponCloseOnClick()
    {
        BottomCtrl.instance.isWeaponPanelOn = false;
        this.transform.DOMoveY(-650, 0.5f);
    }
}
