using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveWeaponInfo : MonoBehaviour
{
    public static HaveWeaponInfo instance;

    public int[] axeInfo = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int[] hammerInfo = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int[] bowInfo = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int[] daggerInfo = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int[] staffInfo = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    
    private void Awake()
    {
        if(instance == null) instance = this;
    }
    public int CheckHaveWeapon(int weaponType, int weaponGrade)
    {
        if (weaponType == 0) return axeInfo[weaponGrade];
        else if(weaponType == 1) return hammerInfo[weaponGrade];
        else if (weaponType == 2) return bowInfo[weaponGrade];
        else if (weaponType == 3) return daggerInfo[weaponGrade];
        else return staffInfo[weaponGrade];
    }
    public void GetWeapon(int weaponType, int weaponGrade)
    {
        switch (weaponType)
        {
            case 0:
                if (axeInfo[weaponGrade] == 0) axeInfo[weaponGrade]++;
                else AccountInfo.instance.gold += Mathf.Pow(2, weaponGrade+1);
                break;
            case 1:
                if (hammerInfo[weaponGrade] == 0) hammerInfo[weaponGrade]++;
                else AccountInfo.instance.gold += Mathf.Pow(2, weaponGrade + 1);
                break;
            case 2:
                if (bowInfo[weaponGrade] == 0) bowInfo[weaponGrade]++;
                else AccountInfo.instance.gold += Mathf.Pow(2, weaponGrade + 1);
                break;
            case 3:
                if (daggerInfo[weaponGrade] == 0) daggerInfo[weaponGrade]++;
                else AccountInfo.instance.gold += Mathf.Pow(2, weaponGrade + 1);
                break;
            case 4:
                if (staffInfo[weaponGrade] == 0) staffInfo[weaponGrade]++;
                else AccountInfo.instance.gold += Mathf.Pow(2, weaponGrade + 1);
                break;
        }
        //Json 연동하기

    }


}
