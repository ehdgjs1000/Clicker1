using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWeapon : MonoBehaviour
{
    [SerializeField] private GameObject draw1Panel;
    [SerializeField] private GameObject draw10Panel;
    [SerializeField] private DrawWeaponGo draw1G0;
    [SerializeField] private DrawWeaponGo[] draw10G0s;
    private WeaponData draw1Data;
    private WeaponData[] draw10Datas = new WeaponData[10];

    [SerializeField] private WeaponData[] axeWeaponDatas;
    [SerializeField] private WeaponData[] hammerWeaponDatas;
    [SerializeField] private WeaponData[] bowWeaponDatas;
    [SerializeField] private WeaponData[] daggerWeaponDatas;
    [SerializeField] private WeaponData[] staffWeaponDatas;
    public float[] weaponDrawProbs = new float[10];

    
    public void DrawPanelExitOnClick(int num)
    {
        if(num == 0)
        {
            InitCardPos(num);
            draw1Panel.SetActive(false);
        }
        else if(num == 1)
        {
            InitCardPos(num);
            draw10Panel.SetActive(false);
        }
    }

    public void DrawWeapons(int _drawAmount)
    {
        if(_drawAmount == 1 && AccountInfo.instance.gem >= 100)
        {
            AccountInfo.instance.gem -= 100;
            DrawOne();
        }else if (_drawAmount == 10 && AccountInfo.instance.gem >= 990)
        {
            AccountInfo.instance.gem -= 990;
            DrawTen();
        }
    }
    private void InitCardPos(int _type)
    {
        if(_type == 0)
        {
            draw1G0.transform.position = new Vector3(540, draw1G0.transform.position.y,
                draw1G0.transform.position.z);
        }
        else
        {
            for(int a = 0; a<10; a++)
            {
                draw10G0s[a].transform.position = new Vector3(540, draw1G0.transform.position.y + 360-40*a,
                draw1G0.transform.position.z);
            }
        }
        
    }
    private void DrawOne()
    {
        draw1Panel.SetActive(true);

        draw1Data = Draw();
        draw1G0.weaponData = draw1Data;
        draw1G0.WeaponDataUpdate();
        AccountInfo.instance.GoldUpdate();
    }
    private void DrawTen()
    {
        draw10Panel.SetActive(true);

        for (int a = 0; a< draw10G0s.Length; a++)
        {
            draw10Datas[a] = Draw();
            draw10G0s[a].weaponData = draw10Datas[a];
            draw10G0s[a].WeaponDataUpdate();
        }
        AccountInfo.instance.GoldUpdate();
    }
    private WeaponData Draw()
    {
        int weaponGrade = 0;
        WeaponData drawWeapon = null;

        float randomProb = Random.Range(0.000f,100.000f);
        if (randomProb < weaponDrawProbs[0]) weaponGrade = 0;
        else if (randomProb >= weaponDrawProbs[0] && randomProb < weaponDrawProbs[1]) weaponGrade = 1;
        else if (randomProb >= weaponDrawProbs[1] && randomProb < weaponDrawProbs[2]) weaponGrade = 2;
        else if (randomProb >= weaponDrawProbs[2] && randomProb < weaponDrawProbs[3]) weaponGrade = 3;
        else if (randomProb >= weaponDrawProbs[3] && randomProb < weaponDrawProbs[4]) weaponGrade = 4;
        else if (randomProb >= weaponDrawProbs[4] && randomProb < weaponDrawProbs[5]) weaponGrade = 5;
        else if (randomProb >= weaponDrawProbs[5] && randomProb < weaponDrawProbs[6]) weaponGrade = 6;
        else if (randomProb >= weaponDrawProbs[6] && randomProb < weaponDrawProbs[7]) weaponGrade = 7;
        else if (randomProb >= weaponDrawProbs[7] && randomProb < weaponDrawProbs[8]) weaponGrade = 8;
        else weaponGrade = 9;



        int randomWeaponType = Random.Range(0, 5);
        Debug.Log("Type : " + randomWeaponType + " Grade : " + weaponGrade);
        HaveWeaponInfo.instance.GetWeapon(randomWeaponType, weaponGrade);
        switch (randomWeaponType)
        {
            case 0:
                drawWeapon = axeWeaponDatas[weaponGrade];
                break;
            case 1:
                drawWeapon = hammerWeaponDatas[weaponGrade];
                break;
            case 2:
                drawWeapon = bowWeaponDatas[weaponGrade];
                break;
            case 3:
                drawWeapon = daggerWeaponDatas[weaponGrade];
                break;
            case 4:
                drawWeapon = staffWeaponDatas[weaponGrade];
                break;
        }
        return drawWeapon;

    }
}
