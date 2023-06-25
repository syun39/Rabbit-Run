using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class usagiidou : MonoBehaviour
{
    //‘¬“x
    [SerializeField] float _speed = 5f;
    private SpriteRenderer _renderer;
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalKey = Input.GetAxis("Horizontal");

        if (Input.GetKey("left"))
        {
            _rigidbody2D.velocity = new Vector2(-_speed, _rigidbody2D.velocity.y);

            _renderer.flipX = true;
        }
        else if (Input.GetKey("right"))
        {
            
            _rigidbody2D.velocity = new Vector2(_speed, _rigidbody2D.velocity.y);
            _renderer.flipX = false;
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
       
    }
}
