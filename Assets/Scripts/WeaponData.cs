using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="weaponData", menuName ="Scriptable Object/Weapon")]
public class WeaponData : ScriptableObject
{
    public int damage;
    public float autoAttackTerm;

    public ParticleSystem hitParticcle;

}
