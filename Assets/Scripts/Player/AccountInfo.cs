using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AccountInfo : MonoBehaviour
{
    public static AccountInfo instance;

    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private TextMeshProUGUI gemText;
    public float gem = 0;
    public float gold = 0;

    private void Awake()
    {
        if(instance == null) instance = this;
    }
    private void Start()
    {
        GoldUpdate();
        GemUpdate();
    }

    public void GoldUpdate()
    {
        goldText.text = gold.ToString();
    }
    public void GemUpdate()
    {
        gemText.text = gem.ToString();
    }

}
