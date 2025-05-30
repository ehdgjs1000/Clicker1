using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeGo : MonoBehaviour
{
    public TextMeshProUGUI costText;
    public TextMeshProUGUI upgardeAmountText;

    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private TextMeshProUGUI amount;

    public void UpdateInfo(int upgradeType)
    {
        level.text = "Lv." + PlayerStats.instance.upgradeLevel[upgradeType].ToString();
        costText.text = UpgradeManager.instance.upgradeCost[upgradeType].ToString();
        if (upgradeType == 0 || upgradeType == 2)
        {
            amount.text = (100 + PlayerStats.instance.upgradeAmount[upgradeType]).ToString() + "%";
        }else if (upgradeType == 1)
        {
            amount.text = PlayerStats.instance.upgradeAmount[upgradeType].ToString() + "%";
        }
        else if (upgradeType == 3)
        {
            amount.text = PlayerStats.instance.upgradeAmount[upgradeType].ToString("F3") + "s";
        }
         
    }

}
