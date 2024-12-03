using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private float AutoDestroyTime = 10f;
    [SerializeField]
    private bool SpawnInFixedUpdate = false;
    [SerializeField]
    private AutoDestroyText Prefab;
    // Update is called once per frame
    private void Update()
    {
        if (!SpawnInFixedUpdate)
        {
            SpawnObject();

        }
        
    }
    private void FixedUpdate()
    {
        if (SpawnInFixedUpdate) 
        {
            SpawnObject();

        }
    }

        private void SpawnObject()
    {
        AutoDestroyText text=Instantiate(Prefab,new Vector3(Random.Range(0,Screen.width),Random.Range(0,Screen.height),0),Quaternion.identity,transform);
        text.AutoDestroyTime = AutoDestroyTime;
    }
}
