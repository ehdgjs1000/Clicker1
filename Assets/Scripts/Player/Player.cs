using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public static Player instance;

    [SerializeField] TextMeshProUGUI dpmText;

    //Auto Attack
    public bool canAutoAttack = false;
    private float autoAttackTerm = 0.5f;
    private bool critical = false;

    Vector2 mousePos;
    public float damage;
    public WeaponData equipedWeapon;


    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Update()
    {
        autoAttackTerm -= Time.deltaTime;
        if (canAutoAttack && autoAttackTerm <= 0.0f)
        {
            AutoAttack();
        }
        if (Input.GetMouseButtonDown(0))
        {
            //수정하기
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Attack(new Vector3(0,1,0));
        }

        DPMUpdate();
    }
    private void DPMUpdate()
    {
        dpmText.text = "DPM : " + Mathf.FloorToInt(equipedWeapon.damage * 60).ToString();

    }
    public void WeaponChange(WeaponData _weaponData)
    {
        equipedWeapon = _weaponData;
    }
    private void Attack(Vector3 _clickPos)
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Monster");
        Monster monster = enemy.GetComponent<Monster>();
        monster.GetDamage(CalcPlayerStats(equipedWeapon.damage), critical);
        Instantiate(equipedWeapon.hitParticcle, _clickPos
            , Quaternion.identity);
    }
    private void AutoAttack()
    {
        autoAttackTerm = equipedWeapon.autoAttackTerm;
        GameObject enemy =  GameObject.FindGameObjectWithTag("Enemy");
        Monster monster = enemy.GetComponent<Monster>();
        monster.GetDamage(CalcPlayerStats(equipedWeapon.damage), critical);
        Instantiate(equipedWeapon.hitParticcle, monster.transform.position, Quaternion.identity);
    }
    private float CalcPlayerStats(float _damage)
    {
        float statDamage = _damage;
        statDamage *= (PlayerStats.instance.upgradeAmount[0] + 100)/100;

        float criChance = Random.Range(0.00f,100.00f);
        if (criChance <= PlayerStats.instance.upgradeAmount[1])
        {
            statDamage *= (PlayerStats.instance.upgradeAmount[2] + 100) / 100.0f;
            critical = true;
        }
        else critical = false;

        return statDamage;
    }


}
