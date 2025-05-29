using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class DrawWeaponGo : MonoBehaviour
{
    [SerializeField] Image weaponImage;
    [SerializeField] TextMeshProUGUI weaponName;
    [SerializeField] TextMeshProUGUI weaponDamage;
    [SerializeField] TextMeshProUGUI weaponGrade;
    [SerializeField] Image weaponBG;

    public WeaponData weaponData;

    public void CardOnClick()
    {
        int ranXPos = Random.Range(0, 2);
        if(ranXPos == 0)
        {
            this.transform.DOMoveX(2000,0.5f);
        }
        else
        {
            this.transform.DOMoveX(-1000, 0.5f);
        }
        

    }
    public void WeaponDataUpdate()
    {
        weaponImage.sprite = weaponData.weaponImage;
        weaponName.text = weaponData.weaponName;
        weaponDamage.text = weaponData.damage.ToString();
        weaponGrade.text = weaponData.weaponGrade.ToString();

        Color color;
        switch (weaponData.weaponGrade)
        {
            case 0:
                weaponBG.color = Color.white;
                break;
            case 1:
                ColorUtility.TryParseHtmlString("#A2FF7C", out color);
                weaponBG.color = color;
                break;
            case 2:
                ColorUtility.TryParseHtmlString("#00FF0D", out color);
                weaponBG.color = color;
                break;
            case 3:
                ColorUtility.TryParseHtmlString("#4CFFEB", out color);
                weaponBG.color = color;
                break;
            case 4:
                ColorUtility.TryParseHtmlString("#0D66FF", out color);
                weaponBG.color = color;
                break;
            case 5:
                ColorUtility.TryParseHtmlString("#C46EFF", out color);
                weaponBG.color = color;
                break;
            case 6:
                ColorUtility.TryParseHtmlString("#9200FF", out color);
                weaponBG.color = color;
                break;
            case 7:
                ColorUtility.TryParseHtmlString("#FF8873", out color);
                weaponBG.color = color;
                break;
            case 8:
                ColorUtility.TryParseHtmlString("#FF001C", out color);
                weaponBG.color = color;
                break;
            case 9:
                ColorUtility.TryParseHtmlString("#FFF600", out color);
                weaponBG.color = color;
                break;

        }
    }

}
