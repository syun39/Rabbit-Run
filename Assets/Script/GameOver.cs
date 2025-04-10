using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] string _enemyTag = "Enemy";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _enemyTag)
        {
            ChangeScene();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == _enemyTag)
        {
            ChangeScene();
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}
