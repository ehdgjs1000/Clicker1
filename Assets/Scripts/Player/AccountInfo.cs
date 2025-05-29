using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AccountInfo : MonoBehaviour
{
    public static AccountInfo instance;

    [SerializeField] private TextMeshProUGUI goldText;
    public float gold = 0;

    private void Awake()
    {
        if(instance == null) instance = this;
    }
    private void Start()
    {
        GoldUpdate();
    }

    public void GoldUpdate()
    {
        goldText.text = gold.ToString();
    }

}
