using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warn : MonoBehaviour
{
    public GameObject RedWarn;
    public GameObject BlueE;
    public GameObject RedE;
    Color BlueC, RedC;
    void Start()
    {
        BlueC = BlueE.GetComponent<SpriteRenderer>().color;
        RedC = RedE.GetComponent<SpriteRenderer>().color;
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        RedWarn.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        RedWarn.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        RedWarn.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        RedWarn.SetActive(false);
        yield return new WaitForSeconds(0.3f);
    }
    private void OnMouseDown()
    {
        StartCoroutine(FadeIO());
    }
    IEnumerator FadeIO()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        while (BlueC.a > 0)
        {
            BlueC.a -= 0.1f;
            BlueE.GetComponent<SpriteRenderer>().color = BlueC;
            RedC.a += 0.1f;
            RedE.GetComponent<SpriteRenderer>().color = RedC;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
