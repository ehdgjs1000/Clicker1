using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="weaponData", menuName ="Scriptable Object/Weapon")]
public class WeaponData : ScriptableObject
{
    public string weaponName;
    public float damage;
    public float autoAttackTerm;
    public Sprite weaponImage;
    public int weaponGrade;

    public ParticleSystem hitParticcle;
}
#if UNITY_EDITOR
[CustomEditor(typeof(WeaponData))]
public class GuiTest : Editor
{
    WeaponData value;

    private void OnEnable()
    {
        Debug.Log("OnEnable");
        value = (WeaponData)target;
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginVertical();

        EditorGUILayout.Space();
        value.weaponImage = (Sprite)EditorGUILayout.ObjectField("무기 이미지",
            value.weaponImage, typeof(Sprite), true);

        EditorGUILayout.Space();
        GUILine(4);
        EditorGUILayout.Space();

        base.OnInspectorGUI();

        EditorGUILayout.EndVertical();
    }

    void GUILine(int lineHeight = 1)
    {
        EditorGUILayout.Space();
        Rect rect = EditorGUILayout.GetControlRect(false, lineHeight);
        rect.height = lineHeight;
        EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
        EditorGUILayout.Space();
    }
}
#endif


