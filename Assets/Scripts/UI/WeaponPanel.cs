using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WeaponPanel : MonoBehaviour
{
    public void WeaponCloseOnClick()
    {
        this.transform.DOMoveY(-650, 0.5f);
    }
}
