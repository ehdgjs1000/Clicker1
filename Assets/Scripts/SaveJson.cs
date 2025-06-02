using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

[System.Serializable]
public class SaveHaveWeapon
{
    public int weaponGrade1, weaponGrade2, weaponGrade3, weaponGrade4, weaponGrade5, weaponGrade6,
        weaponGrade7, weaponGrade8, weaponGrade9, weaponGrade10;
    public SaveHaveWeapon(int grade1, int grade2, int grade3, int grade4, int grade5, int grade6,int grade7,
        int grade8, int grade9, int grade10)
    {
        weaponGrade1 = grade1;
        weaponGrade2 = grade2;
        weaponGrade3 = grade3;
        weaponGrade4 = grade4;
        weaponGrade5 = grade5;
        weaponGrade6 = grade6;
        weaponGrade7 = grade7;
        weaponGrade8 = grade8;
        weaponGrade9 = grade9;
        weaponGrade10 = grade10;

    }
}

public class SaveJson : MonoBehaviour
{
    public static SaveJson instance;

    [SerializeField] public List<SaveHaveWeapon> saveHaveWeaponList;
    [SerializeField] public List<SaveHaveWeapon> loadHaveWeaponList;
    [SerializeField] public int[] haveWeaponDatas = new int[10];

    private void Awake()
    {
        if (instance == null) instance = this;
        
    }
    private void Start()
    {
        LoadGameData();
    }
    public void LoadGameData()
    {
        LoadHaveWeapon();
    }
    public void ResetJsonData()
    {
        string haveWeaponPath = Application.persistentDataPath + "/HaveWeapon.json";
        Debug.Log(haveWeaponPath);
        saveHaveWeaponList.Clear();
        File.WriteAllText(haveWeaponPath, null);
    }
    public void LoadHaveWeapon()
    {
        string haveWeaponPath = Application.persistentDataPath + "/HaveWeapon.json";
        string haveWeaponString = File.ReadAllText(haveWeaponPath);

        loadHaveWeaponList = JsonConvert.DeserializeObject<List<SaveHaveWeapon>>(haveWeaponString);

        if (loadHaveWeaponList != null)
        {
            HaveWeaponInfo.instance.axeInfo[0] = loadHaveWeaponList[0].weaponGrade1;
            HaveWeaponInfo.instance.axeInfo[1] = loadHaveWeaponList[0].weaponGrade2;
            HaveWeaponInfo.instance.axeInfo[2] = loadHaveWeaponList[0].weaponGrade3;
            HaveWeaponInfo.instance.axeInfo[3] = loadHaveWeaponList[0].weaponGrade4;
            HaveWeaponInfo.instance.axeInfo[4] = loadHaveWeaponList[0].weaponGrade5;
            HaveWeaponInfo.instance.axeInfo[5] = loadHaveWeaponList[0].weaponGrade6;
            HaveWeaponInfo.instance.axeInfo[6] = loadHaveWeaponList[0].weaponGrade7;
            HaveWeaponInfo.instance.axeInfo[7] = loadHaveWeaponList[0].weaponGrade8;
            HaveWeaponInfo.instance.axeInfo[8] = loadHaveWeaponList[0].weaponGrade9;
            HaveWeaponInfo.instance.axeInfo[9] = loadHaveWeaponList[0].weaponGrade10;
            HaveWeaponInfo.instance.hammerInfo[0] = loadHaveWeaponList[1].weaponGrade1;
            HaveWeaponInfo.instance.hammerInfo[1] = loadHaveWeaponList[1].weaponGrade2;
            HaveWeaponInfo.instance.hammerInfo[2] = loadHaveWeaponList[1].weaponGrade3;
            HaveWeaponInfo.instance.hammerInfo[3] = loadHaveWeaponList[1].weaponGrade4;
            HaveWeaponInfo.instance.hammerInfo[4] = loadHaveWeaponList[1].weaponGrade5;
            HaveWeaponInfo.instance.hammerInfo[5] = loadHaveWeaponList[1].weaponGrade6;
            HaveWeaponInfo.instance.hammerInfo[6] = loadHaveWeaponList[1].weaponGrade7;
            HaveWeaponInfo.instance.hammerInfo[7] = loadHaveWeaponList[1].weaponGrade8;
            HaveWeaponInfo.instance.hammerInfo[8] = loadHaveWeaponList[1].weaponGrade9;
            HaveWeaponInfo.instance.hammerInfo[9] = loadHaveWeaponList[1].weaponGrade10;
            HaveWeaponInfo.instance.bowInfo[0] = loadHaveWeaponList[2].weaponGrade1;
            HaveWeaponInfo.instance.bowInfo[1] = loadHaveWeaponList[2].weaponGrade2;
            HaveWeaponInfo.instance.bowInfo[2] = loadHaveWeaponList[2].weaponGrade3;
            HaveWeaponInfo.instance.bowInfo[3] = loadHaveWeaponList[2].weaponGrade4;
            HaveWeaponInfo.instance.bowInfo[4] = loadHaveWeaponList[2].weaponGrade5;
            HaveWeaponInfo.instance.bowInfo[5] = loadHaveWeaponList[2].weaponGrade6;
            HaveWeaponInfo.instance.bowInfo[6] = loadHaveWeaponList[2].weaponGrade7;
            HaveWeaponInfo.instance.bowInfo[7] = loadHaveWeaponList[2].weaponGrade8;
            HaveWeaponInfo.instance.bowInfo[8] = loadHaveWeaponList[2].weaponGrade9;
            HaveWeaponInfo.instance.bowInfo[9] = loadHaveWeaponList[2].weaponGrade10;
            HaveWeaponInfo.instance.daggerInfo[0] = loadHaveWeaponList[3].weaponGrade1;
            HaveWeaponInfo.instance.daggerInfo[1] = loadHaveWeaponList[3].weaponGrade2;
            HaveWeaponInfo.instance.daggerInfo[2] = loadHaveWeaponList[3].weaponGrade3;
            HaveWeaponInfo.instance.daggerInfo[3] = loadHaveWeaponList[3].weaponGrade4;
            HaveWeaponInfo.instance.daggerInfo[4] = loadHaveWeaponList[3].weaponGrade5;
            HaveWeaponInfo.instance.daggerInfo[5] = loadHaveWeaponList[3].weaponGrade6;
            HaveWeaponInfo.instance.daggerInfo[6] = loadHaveWeaponList[3].weaponGrade7;
            HaveWeaponInfo.instance.daggerInfo[7] = loadHaveWeaponList[3].weaponGrade8;
            HaveWeaponInfo.instance.daggerInfo[8] = loadHaveWeaponList[3].weaponGrade9;
            HaveWeaponInfo.instance.daggerInfo[9] = loadHaveWeaponList[3].weaponGrade10;
            HaveWeaponInfo.instance.staffInfo[0] = loadHaveWeaponList[4].weaponGrade1;
            HaveWeaponInfo.instance.staffInfo[1] = loadHaveWeaponList[4].weaponGrade2;
            HaveWeaponInfo.instance.staffInfo[2] = loadHaveWeaponList[4].weaponGrade3;
            HaveWeaponInfo.instance.staffInfo[3] = loadHaveWeaponList[4].weaponGrade4;
            HaveWeaponInfo.instance.staffInfo[4] = loadHaveWeaponList[4].weaponGrade5;
            HaveWeaponInfo.instance.staffInfo[5] = loadHaveWeaponList[4].weaponGrade6;
            HaveWeaponInfo.instance.staffInfo[6] = loadHaveWeaponList[4].weaponGrade7;
            HaveWeaponInfo.instance.staffInfo[7] = loadHaveWeaponList[4].weaponGrade8;
            HaveWeaponInfo.instance.staffInfo[8] = loadHaveWeaponList[4].weaponGrade9;
            HaveWeaponInfo.instance.staffInfo[9] = loadHaveWeaponList[4].weaponGrade10;
        }
    }

    public void SaveHaveWeapon()
    {
        string haveWeaponPath = Application.persistentDataPath + "/HaveWeapon.json";
        Debug.Log(haveWeaponPath);
        string haveWeaponData = null;
        saveHaveWeaponList.Clear();
        File.WriteAllText(haveWeaponPath, null);

        saveHaveWeaponList.Add(new SaveHaveWeapon(HaveWeaponInfo.instance.axeInfo[0],
            HaveWeaponInfo.instance.axeInfo[1],
            HaveWeaponInfo.instance.axeInfo[2],
            HaveWeaponInfo.instance.axeInfo[3],
            HaveWeaponInfo.instance.axeInfo[4],
            HaveWeaponInfo.instance.axeInfo[5],
            HaveWeaponInfo.instance.axeInfo[6],
            HaveWeaponInfo.instance.axeInfo[7],
            HaveWeaponInfo.instance.axeInfo[8],
            HaveWeaponInfo.instance.axeInfo[9]));
        saveHaveWeaponList.Add(new SaveHaveWeapon(HaveWeaponInfo.instance.hammerInfo[0],
            HaveWeaponInfo.instance.hammerInfo[1],
            HaveWeaponInfo.instance.hammerInfo[2],
            HaveWeaponInfo.instance.hammerInfo[3],
            HaveWeaponInfo.instance.hammerInfo[4],
            HaveWeaponInfo.instance.hammerInfo[5],
            HaveWeaponInfo.instance.hammerInfo[6],
            HaveWeaponInfo.instance.hammerInfo[7],
            HaveWeaponInfo.instance.hammerInfo[8],
            HaveWeaponInfo.instance.hammerInfo[9]));
        saveHaveWeaponList.Add(new SaveHaveWeapon(HaveWeaponInfo.instance.bowInfo[0],
            HaveWeaponInfo.instance.bowInfo[1],
            HaveWeaponInfo.instance.bowInfo[2],
            HaveWeaponInfo.instance.bowInfo[3],
            HaveWeaponInfo.instance.bowInfo[4],
            HaveWeaponInfo.instance.bowInfo[5],
            HaveWeaponInfo.instance.bowInfo[6],
            HaveWeaponInfo.instance.bowInfo[7],
            HaveWeaponInfo.instance.bowInfo[8],
            HaveWeaponInfo.instance.bowInfo[9]));
        saveHaveWeaponList.Add(new SaveHaveWeapon(HaveWeaponInfo.instance.daggerInfo[0],
            HaveWeaponInfo.instance.daggerInfo[1],
            HaveWeaponInfo.instance.daggerInfo[2],
            HaveWeaponInfo.instance.daggerInfo[3],
            HaveWeaponInfo.instance.daggerInfo[4],
            HaveWeaponInfo.instance.daggerInfo[5],
            HaveWeaponInfo.instance.daggerInfo[6],
            HaveWeaponInfo.instance.daggerInfo[7],
            HaveWeaponInfo.instance.daggerInfo[8],
            HaveWeaponInfo.instance.daggerInfo[9]));
        saveHaveWeaponList.Add(new SaveHaveWeapon(HaveWeaponInfo.instance.staffInfo[0],
            HaveWeaponInfo.instance.staffInfo[1],
            HaveWeaponInfo.instance.staffInfo[2],
            HaveWeaponInfo.instance.staffInfo[3],
            HaveWeaponInfo.instance.staffInfo[4],
            HaveWeaponInfo.instance.staffInfo[5],
            HaveWeaponInfo.instance.staffInfo[6],
            HaveWeaponInfo.instance.staffInfo[7],
            HaveWeaponInfo.instance.staffInfo[8],
            HaveWeaponInfo.instance.staffInfo[9]));


        haveWeaponData = JsonConvert.SerializeObject(saveHaveWeaponList, Formatting.Indented);
        File.WriteAllText(haveWeaponPath, haveWeaponData);
    }

}
