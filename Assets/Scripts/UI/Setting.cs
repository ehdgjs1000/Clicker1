using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    [SerializeField] GameObject settingPanel;

    public void SettingBtnOnClick()
    {
        settingPanel.SetActive(true);
    }
    public void EXitSettingOnClick()
    {
        settingPanel.SetActive(false);
    }
    public void ResetBtnOnClick()
    {
        settingPanel.SetActive(false);
        SaveJson.instance.ResetJsonData();
        SavePlayerPrefabs.instance.ResetPlayerPrefs();
        SceneManager.LoadScene(1);   
    }
}
