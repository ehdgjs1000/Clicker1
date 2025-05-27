using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private Image hpImage;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI monsterName;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public void InitMonster(float _initHp, float _nowHp, string _monsterName)
    {
        monsterName.text = _monsterName;
        hpImage.fillAmount = (_nowHp / _initHp);
        hpText.text = _nowHp.ToString();
    }
    public void HpGageUpdate(float _initHp, float _nowHp)
    {
        hpImage.fillAmount = (_nowHp / _initHp);
        hpText.text = _nowHp.ToString();
    }

}
