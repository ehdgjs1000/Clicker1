using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //Basic Stats
    [SerializeField] protected string monsterName;
    [SerializeField] protected float hp;
    protected float initHp;
    [SerializeField] protected float regenHpAmount;
    [SerializeField] protected float regenHpTime;
    private float tempRegenHpTime;


    protected void InitMonster(float _hp, float _regenHpAmount, float _regenHpTime, string _monsterName)
    {
        hp = _hp;
        initHp = _hp;
        regenHpAmount = _regenHpAmount;
        regenHpTime = _regenHpTime;
        tempRegenHpTime = _regenHpTime;
        monsterName = _monsterName;
    }
    private void Update()
    {
        regenHpTime -= Time.deltaTime;
        if (regenHpTime <= 0.0f) RegenHp();

        if (Input.GetKeyDown(KeyCode.Space)) GetDamage(10);

    }
    private void Start()
    {
        InitMonster(hp, regenHpAmount, regenHpTime, monsterName);
        GameManager.instance.InitMonster(initHp, hp, monsterName);

        if (hp <= 0.0f)
        {
            Die();
        }
    }
    private void GetDamage(float _damage)
    {
        hp -= _damage;
        if(hp <= 0.0f)
        {
            hp = 0.0f;
            Die();
        }
    }
    protected void RegenHp()
    {
        hp += regenHpAmount;
        if (hp >= initHp) hp = initHp;
        regenHpTime = tempRegenHpTime;
    }
    protected void Die()
    {
        Debug.Log("Monster Die");

    } 

}
