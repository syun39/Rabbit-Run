using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    void Start()
    {
        GetComponent<Image>().enabled = true;
    }

   public void EndFadeInAnimation()
    {
        Destroy(this.gameObject);
    }
}
