using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class FloatingDamage : MonoBehaviour
{
    TextMeshPro damageMesh;
    private float dissapearTime = 1.0f;

    static Vector3 position;

    private void Awake()
    {
        damageMesh = GetComponent<TextMeshPro>();
    }
    private void Start()
    {
        StartCoroutine(Floating());
    }
    private void Update()
    {
        dissapearTime -= Time.deltaTime;
        if (dissapearTime <= 0.0f) Destroy(this.gameObject);
    }
    private IEnumerator Floating()
    {
        float randomX = Random.Range(-1.5f, 1.5f);
        float randomY = Random.Range(0.5f, 1.2f);
        float randomYM = Random.Range(-0.7f, -0.3f);
        transform.DOMoveX(randomX, 0.5f);
        transform.DOMoveY(position.y + randomY, 0.25f);
        yield return new WaitForSeconds(0.25f);
        transform.DOMoveY(position.y + randomYM, 0.25f);

    }
    public static FloatingDamage Create(Vector3 pos, float damage)
    {
        position = pos;
        Transform damagePopUpTransform = Instantiate(GameAsset.Instance.pfDamagePopUp,
            pos, Quaternion.identity);
        FloatingDamage damagePopUp = damagePopUpTransform.GetComponent<FloatingDamage>();
        damagePopUp.SetUp(damage);

        return damagePopUp;
    }
    public void SetUp(float damage)
    {
        damageMesh.SetText(Mathf.FloorToInt(damage).ToString());
    }
}
