using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uraruto : MonoBehaviour
{
    [SerializeField]
    string _UrarutoTag = "Ura";


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _UrarutoTag)
        {
            ChangeScene();
        }

    }
    
    void ChangeScene()
    {
        SceneManager.LoadScene("Uraruto");

    }
}
