using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    [SerializeField]
    string _goalTag = "goal";


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _goalTag)
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GameClear");

    }
}
  