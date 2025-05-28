using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    //Auto Attack
    public bool canAutoAttack = false;
    private float autoAttackTerm = 0.5f;

    Vector2 mousePos;
    public float damage;
    public WeaponData equipedWeapon;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Start()
    {
        
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
    }
    public void WeaponChange(WeaponData _weaponData)
    {
        equipedWeapon = _weaponData;
    }
    private void Attack(Vector3 _clickPos)
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        Monster monster = enemy.GetComponent<Monster>();
        monster.GetDamage(equipedWeapon.damage);
        Instantiate(equipedWeapon.hitParticcle, _clickPos
            , Quaternion.identity);
    }
    private void AutoAttack()
    {
        autoAttackTerm = equipedWeapon.autoAttackTerm;
        GameObject enemy =  GameObject.FindGameObjectWithTag("Enemy");
        Monster monster = enemy.GetComponent<Monster>();
        monster.GetDamage(equipedWeapon.damage);
        Instantiate(equipedWeapon.hitParticcle, monster.transform.position, Quaternion.identity);
    }


}
