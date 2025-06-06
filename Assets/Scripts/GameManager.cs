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
    [SerializeField] private Image timerImage;
    [SerializeField] private TextMeshProUGUI timerText;
    private float sec = 60;

    //Game Level System
    private int gameLevel = 1;
    private int saveGameLevel = 0;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Update()
    {
        Timer();

        gameLevelText.text = gameLevel.ToString();
        
    }
    private void Start()
    {
        saveGameLevel = PlayerPrefs.GetInt("saveGameLevel");
        MonsterSpawner.instance.SpawnMonster(saveGameLevel);
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("saveGameLevel", gameLevel);
    }
    public void ResetGame()
    {
        sec = 60;
        GameObject monsterGo = GameObject.FindGameObjectWithTag("Monster");
        Monster monster = monsterGo.GetComponent<Monster>();
        monster.Reset();
    }
    public void Timer()
    {
        sec -= Time.deltaTime;
        timerText.text = Mathf.Ceil(sec).ToString();
        timerImage.fillAmount = sec / 60;
        if(sec <= 0)
        {
            ResetGame();
        }
    }
    public void BeforeBtn()
    {
        if (gameLevel > 1)
        {
            GameObject monsterGo = GameObject.FindGameObjectWithTag("Monster");
            Monster monster = monsterGo.GetComponent<Monster>();
            monster.Eliminate();
            gameLevel--;
            MonsterSpawner.instance.SpawnMonster(gameLevel);
            ResetGame();
        }
    }
    public void NextBtn()
    {

    }
    public void ReTryOnClick()
    {
        ResetGame();
    }
    public IEnumerator RoundClear()
    {
        gameLevel++;
        MonsterSpawner.instance.SpawnMonster(gameLevel);
        ResetGame();
        yield return null;
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
        hpText.text = _nowHp.ToString("F1");
    }

}
