using UnityEngine;

//Characterを動かす
public class CharacterMove : MonoBehaviour
{
    private Rigidbody _rb;
    private Animator _anim;

    #region 動かすための変数

    [SerializeField, Header("走る速さ")] private float _speed;
    [SerializeField, Header("目標地点")]　private Transform _point;
    private float _horizontal;
    private float _vertical;

    #endregion

    //Animation
    private static readonly int MoveSpeed = Animator.StringToHash("MoveSpeed");

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        AutoMove();
    }

    //自動で前に移動する
    private void AutoMove()
    {
        Transform target = _point;
        transform.position =
            Vector3.MoveTowards(transform.position, target.transform.position, _speed * Time.deltaTime);

        // ターゲットに近づくにつれてアニメーションを減速
        float distance = Vector3.Distance(transform.position, target.position);
        float smoothSpeed = Mathf.Lerp(0f, 2f, distance / 3f); // 距離が3未満の場合に減速
        _anim.SetFloat(MoveSpeed, smoothSpeed);

        // ターゲットに到達したかをチェック
        if (distance < 0.0000001f)
        {
            
            transform.position = target.position; // 位置を完全に合わせる
            _anim.SetFloat(MoveSpeed, 0f); // アニメーション停止

            // // 次のポイントに移動
            // _currentPointIndex = (_currentPointIndex + 1) % _points.Length;
        }
    }
}