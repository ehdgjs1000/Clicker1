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
    public int gold;
    private bool isDie = false;


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
        if (hp <= 0.0f) hp = 0.0f;

    }
    private void Start()
    {
        InitMonster(hp, regenHpAmount, regenHpTime, monsterName);
        GameManager.instance.InitMonster(initHp, hp, monsterName);
    }
    public void Reset()
    {
        hp = initHp;
        GameManager.instance.HpGageUpdate(initHp, hp);
    }
    public void GetDamage(float _damage, bool _critical)
    {
        FloatingDamage.Create(new Vector3(this.transform.position.x, this.transform.position.y+1f,
            -3.0f), _damage, _critical);

        hp -= _damage;
        GameManager.instance.HpGageUpdate(initHp, hp);
        if (hp <= 0.0f && !isDie)
        {
            Die();
        }
    }
    protected void RegenHp()
    {
        hp += regenHpAmount;
        if (hp >= initHp) hp = initHp;
        regenHpTime = tempRegenHpTime;
    }
    public void Eliminate()
    {
        Destroy(this.gameObject);
    }
    protected void Die()
    {
        Debug.Log("Monster Die");
        isDie = true;

        //GameManager
        AccountInfo.instance.gold += gold;
        AccountInfo.instance.GoldUpdate();

        Destroy(this.gameObject);
        StartCoroutine(GameManager.instance.RoundClear());
    } 

}
