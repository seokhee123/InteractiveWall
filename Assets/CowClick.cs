using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowClick : MonoBehaviour
{
    public GameObject boom;
    public bool cowActive;

    private void Update()
    {
        if(cowActive == true)
        {
            Cow();
        }
    }
    void Cow()
    {
        StartCoroutine("Boom");
    }

    IEnumerator Boom()
    {
        boom.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        boom.SetActive(false);
        cowActive = false;
    }
}
