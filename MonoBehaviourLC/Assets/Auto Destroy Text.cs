using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]

public class AutoDestroyText : MonoBehaviour
{
    public float AutoDestroyTime = 10f;
    private TextMeshProUGUI Text;
    private float SpawnTime;
    
    private void Awake()
    {
        Text=GetComponent<TextMeshProUGUI>();
        AutoDestroyTime = 10f;
    }
    private void OnEnable()
    {
        SpawnTime = Time.time;

    }

    private void Update()
    {
        float remainingTime = (SpawnTime + AutoDestroyTime) - Time.time;
        Text.SetText($"{remainingTime.ToString("N2")}");
        if (remainingTime <= 0) 
        {
            Destroy(gameObject);
        }
    }

}
