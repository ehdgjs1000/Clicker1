using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="weaponData", menuName ="Scriptable Object/Weapon")]
public class WeaponData : ScriptableObject
{
    public float damage;
    public float autoAttackTerm;
    public Sprite weaponImage;
    public int weaponGrade;

    public ParticleSystem hitParticcle;

}
