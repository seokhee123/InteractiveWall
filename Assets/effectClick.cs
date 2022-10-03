using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectClick : MonoBehaviour
{
    public GameObject starPrefab;
    float spawnsTime;
    public float defaultTime = 0.05f;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0) && spawnsTime >= defaultTime)
        {
            StarCreat();
            spawnsTime = 0;
        }
        spawnsTime += Time.deltaTime;
    }

    void StarCreat()
    {
        Vector3 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mPosition.z = 0;
        Instantiate(starPrefab, mPosition, Quaternion.identity);
    }
}
