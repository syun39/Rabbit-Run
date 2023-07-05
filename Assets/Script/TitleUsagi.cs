using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TitleUsagi : MonoBehaviour
{
    public static Vector2 _posistion;
    static bool _posistionSave = false;

    public void SavePosition()
    {
        _posistion = transform.position;
        _posistionSave = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (_posistionSave)
        {
            transform.position = _posistion;
        }
    }


}
