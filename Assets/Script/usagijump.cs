using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usagijump : MonoBehaviour
{
    //ƒWƒƒƒ“ƒv‚·‚é—Í
    [SerializeField] float _jumppower = 1f;
    private Rigidbody2D _rigidbody2D;
    int _jumpcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this._jumpcount < 1)
        {
            _rigidbody2D.AddForce(transform.up * _jumppower);
            _jumpcount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _jumpcount = 0;
        }
    }
}
