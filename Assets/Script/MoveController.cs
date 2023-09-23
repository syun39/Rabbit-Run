using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// 壁を検出したり、床のないところを検出して移動を制御するコンポーネント
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class MoveController : MonoBehaviour
{
    /// <summary>移動速度</summary>
    [SerializeField] float _moveSpeed = 1f;
    /// <summary>壁を検出するための line のオフセット</summary>
    [SerializeField] Vector2 _lineForWall = Vector2.right;
    /// <summary>壁のレイヤー（レイヤーはオブジェクトに設定されている）</summary>
    [SerializeField] LayerMask _wallLayer = 0;
    /// <summary>移動方向</summary>
    Vector2 _moveDirection = Vector2.right;
    Rigidbody2D _rb = default;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveWithTurn();
    }

  
    // 前方に壁を検出するまで右に移動し、壁を検出したら左に移動する処理
   
    void MoveWithTurn()
    {
        Vector2 start = this.transform.position;
        Debug.DrawLine(start, start + _lineForWall);
        RaycastHit2D hit = Physics2D.Linecast(start, start + _lineForWall, _wallLayer);
        Vector2 velo = Vector2.zero;    // velo は速度ベクトル

        if (hit.collider)
        {
            //_moveDirection.x *= -1;
            _lineForWall.x *= -1;
            _moveSpeed = _moveSpeed * -1;
            GetComponent<SpriteRenderer>().flipX = true;  //当たったら反転
            if (_lineForWall.x == 1)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }

        }

        velo = _moveDirection.normalized * _moveSpeed;
        velo.y = _rb.velocity.y;
        _rb.velocity = velo;
    }
}