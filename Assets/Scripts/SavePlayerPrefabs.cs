using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPrefabs : MonoBehaviour
{
    public static SavePlayerPrefabs instance;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
    public void SaveUpgrade()
    {
        PlayerPrefs.SetInt("UpgradeLevel1", PlayerStats.instance.upgradeLevel[0]);
        PlayerPrefs.SetInt("UpgradeLevel2", PlayerStats.instance.upgradeLevel[1]);
        PlayerPrefs.SetInt("UpgradeLevel3", PlayerStats.instance.upgradeLevel[2]);
        PlayerPrefs.SetInt("UpgradeLevel4", PlayerStats.instance.upgradeLevel[3]);

        PlayerPrefs.SetFloat("UpgradeAmount1", PlayerStats.instance.upgradeAmount[0]);
        PlayerPrefs.SetFloat("UpgradeAmount2", PlayerStats.instance.upgradeAmount[1]);
        PlayerPrefs.SetFloat("UpgradeAmount3", PlayerStats.instance.upgradeAmount[2]);
        PlayerPrefs.SetFloat("UpgradeAmount4", PlayerStats.instance.upgradeAmount[3]);

        /*PlayerPrefs.SetFloat("UpgradeCost1", UpgradeManager.instance.upgradeCost[0]);
        PlayerPrefs.SetFloat("UpgradeCost2", UpgradeManager.instance.upgradeCost[1]);
        PlayerPrefs.SetFloat("UpgradeCost3", UpgradeManager.instance.upgradeCost[2]);
        PlayerPrefs.SetFloat("UpgradeCost4", UpgradeManager.instance.upgradeCost[3]);*/
    }
    public void LoadUpgrade()
    {
        PlayerStats.instance.upgradeLevel[0] = PlayerPrefs.GetInt("UpgradeLevel1");
        PlayerStats.instance.upgradeLevel[1] = PlayerPrefs.GetInt("UpgradeLevel2");
        PlayerStats.instance.upgradeLevel[2] = PlayerPrefs.GetInt("UpgradeLevel3");
        PlayerStats.instance.upgradeLevel[3] = PlayerPrefs.GetInt("UpgradeLevel4");

        PlayerStats.instance.upgradeAmount[0] = PlayerPrefs.GetFloat("UpgradeAmount1");
        PlayerStats.instance.upgradeAmount[1] = PlayerPrefs.GetFloat("UpgradeAmount2");
        PlayerStats.instance.upgradeAmount[2] = PlayerPrefs.GetFloat("UpgradeAmount3");
        PlayerStats.instance.upgradeAmount[3] = PlayerPrefs.GetFloat("UpgradeAmount4");

        /*UpgradeManager.instance.upgradeCost[0] = PlayerPrefs.GetFloat("UpgradeCost1");
        UpgradeManager.instance.upgradeCost[1] = PlayerPrefs.GetFloat("UpgradeCost2");
        UpgradeManager.instance.upgradeCost[2] = PlayerPrefs.GetFloat("UpgradeCost3");
        UpgradeManager.instance.upgradeCost[3] = PlayerPrefs.GetFloat("UpgradeCost4");*/
    }
    public void SaveAccount()
    {
        PlayerPrefs.SetFloat("Gold", AccountInfo.instance.gold);
        PlayerPrefs.SetFloat("Gem", AccountInfo.instance.gem);

    }
    public void LoadAccount()
    {
        if (PlayerPrefs.HasKey("Gold"))
        {
            AccountInfo.instance.gold = PlayerPrefs.GetFloat("Gold");
        }
        else
        {
            AccountInfo.instance.gold = 0;
        }

        if (PlayerPrefs.HasKey("Gem"))
        {
            AccountInfo.instance.gem = PlayerPrefs.GetFloat("Gem");
        }
        else
        {
            AccountInfo.instance.gem = 100;
        }

    }

}
