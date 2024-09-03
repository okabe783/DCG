using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    [SerializeField, Header("手札")]　private PlayerHand _playerHand;
    /// <summary>Start時にカードを配る</summary>
    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            CardManager.Instance.FirstHand(_playerHand);
        }
    }
}
