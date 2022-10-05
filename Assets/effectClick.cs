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
            StarCreate();
            spawnsTime = 0;
        }
        spawnsTime += Time.deltaTime;
    }
     
    void StarCreate()
    {
        Vector3 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mPosition.z = 0;
        Debug.Log(mPosition.ToString());
        Instantiate(starPrefab, mPosition, Quaternion.identity);
    }
}
