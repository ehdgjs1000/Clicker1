using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class FloatingGold : MonoBehaviour
{
    TextMeshPro goldMesh;
    private float dissapearTime = 1.75f;

    static Vector3 position;

    private void Awake()
    {
        goldMesh = GetComponent<TextMeshPro>();
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
        transform.DOMoveY(position.y + 3, 0.5f);
        yield return new WaitForSeconds(1.0f);
        transform.DOMove(new Vector3(-2.75f, 1.5f, 0),0.25f);
        transform.DOScale(new Vector3(0,0,0),0.25f);
    }
    public static FloatingGold Create(Vector3 pos, float amount)
    {
        position = pos;
        Transform goldPopUpTransform = Instantiate(GameAsset.Instance.pfGoldPopUp,
            pos, Quaternion.identity);
        FloatingGold goldPopUp = goldPopUpTransform.GetComponent<FloatingGold>();
        goldPopUp.SetUp(amount);


        return goldPopUp;
    }
    public void SetUp(float amount)
    {
        goldMesh.SetText(amount.ToString());
    }
}
