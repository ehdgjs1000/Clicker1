using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //UI
    [SerializeField] private Image hpImage;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI monsterName;
    [SerializeField] private TextMeshProUGUI gameLevelText;

    //Game Level System
    private int gameLevel = 1;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Update()
    {
        gameLevelText.text = gameLevel.ToString();
    }

    public void InitMonster(float _initHp, float _nowHp, string _monsterName)
    {
        monsterName.text = _monsterName;
        hpImage.fillAmount = (_nowHp / _initHp);
        hpText.text = _nowHp.ToString();
    }
    public void HpGageUpdate(float _initHp, float _nowHp)
    {
        if(_nowHp <= 0.0f) _nowHp = 0.0f;
        hpImage.fillAmount = (_nowHp / _initHp);
        hpText.text = _nowHp.ToString();
    }

}
