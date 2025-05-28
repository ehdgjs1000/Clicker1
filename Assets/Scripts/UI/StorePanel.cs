using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StorePanel : MonoBehaviour
{
    public void StoreCloseOnClick()
    {
        BottomCtrl.instance.isStorePanelOn = false;
        this.transform.DOMoveY(-650, 0.5f);
    }

}
