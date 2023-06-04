using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class usahicontroller : MonoBehaviour
{
    //‘¬“x
    [SerializeField] float _speed = 5f;
    //ƒWƒƒƒ“ƒv‚·‚é—Í
    [SerializeField] float _jumppower = 1f;
    private SpriteRenderer _renderer;
    private Rigidbody2D _rigidbody2D;
    int _jumpcount = 0;
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody2D = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if(Input.GetKeyDown(KeyCode.Space) && _jumpcount < 1)
        {
            // _rigidbody2D.AddForce(Vector2.up * _jumppower);
            _rigidbody2D.AddForce(Vector2.up * _jumppower, ForceMode2D.Impulse);
            _jumpcount++;
        }

        if (Input.GetKey("left"))
        {
            position.x -= _speed;
            _renderer.flipX = true;
        }
        else if (Input.GetKey("right"))
        {
            position.x += _speed;
            _renderer.flipX = false;
        }

        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _jumpcount = 0;
        }
    }
}
