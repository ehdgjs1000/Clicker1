using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager instance;

    [SerializeField] private UpgradeGo[] upgradeGos;
    public float[] upgradeCost = new float[4] {10,500,10000,50000};

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Start()
    {
        InitUpgradeManager();
    }
    private void InitUpgradeManager()
    {
        for (int a = 0; a < upgradeGos.Length; a++)
        {
            upgradeGos[a].UpdateInfo(a);
        }
        IniUpgrade();
    }
    public void IniUpgrade()
    {
        upgradeCost[0] = Mathf.FloorToInt(10 * Mathf.Pow(1.1f, PlayerStats.instance.upgradeLevel[0]));
        upgradeCost[1] = Mathf.FloorToInt(500 * Mathf.Pow(1.1f, PlayerStats.instance.upgradeLevel[1]));
        upgradeCost[2] = Mathf.FloorToInt(10000 * Mathf.Pow(1.1f, PlayerStats.instance.upgradeLevel[2]));
        upgradeCost[3] = Mathf.FloorToInt(50000 * Mathf.Pow(1.5f, PlayerStats.instance.upgradeLevel[3]));
        for (int a = 0; a < upgradeGos.Length; a++)
        {
            upgradeGos[a].UpdateInfo(a);
        }
    }

    public void PowerUpgradeOnClick()
    {
        if(AccountInfo.instance.gold >= upgradeCost[0])
        {
            AccountInfo.instance.gold -= upgradeCost[0];
            IniUpgrade();
            AccountInfo.instance.GoldUpdate();
            PlayerStats.instance.upgradeAmount[0] += 5;
            PlayerStats.instance.upgradeLevel[0]++;
            SavePlayerPrefabs.instance.SaveUpgrade();
            upgradeGos[0].UpdateInfo(0);
        }
        
    }
    public void CriticalChanceUpgradeOnClick()
    {
        if (AccountInfo.instance.gold >= upgradeCost[1])
        {
            AccountInfo.instance.gold -= upgradeCost[1];
            IniUpgrade();
            AccountInfo.instance.GoldUpdate();
            PlayerStats.instance.upgradeAmount[1] += 1;
            PlayerStats.instance.upgradeLevel[1]++;
            SavePlayerPrefabs.instance.SaveUpgrade();
            upgradeGos[1].UpdateInfo(1);
        }
        
    }
    public void CriticalDamageUpgradeOnClick()
    {
        if (AccountInfo.instance.gold >= upgradeCost[2])
        {
            AccountInfo.instance.gold -= upgradeCost[2];
            IniUpgrade();
            AccountInfo.instance.GoldUpdate();
            PlayerStats.instance.upgradeAmount[2] += 10;
            PlayerStats.instance.upgradeLevel[2]++;
            SavePlayerPrefabs.instance.SaveUpgrade();
            upgradeGos[2].UpdateInfo(2);
        }
        
    }
    public void AutoClickUpgradeOnClick()
    {
        if (AccountInfo.instance.gold >= upgradeCost[3])
        {
            AccountInfo.instance.gold -= upgradeCost[3];
            IniUpgrade();
            AccountInfo.instance.GoldUpdate();
            PlayerStats.instance.upgradeAmount[3] *= 0.97f;
            PlayerStats.instance.upgradeAmount[3]++;
            SavePlayerPrefabs.instance.SaveUpgrade();
            upgradeGos[3].UpdateInfo(3);
        }
        
    }
    public void ExitBtnOnClick()
    {
        this.transform.DOMoveY(-650, 0.5f);
    }

}
