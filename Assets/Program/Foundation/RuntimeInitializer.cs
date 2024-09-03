using UnityEngine;

/// <summary>Editor実行時に呼び出される </summary>
public class RuntimeInitializer : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void InitializeBeforeSceneLoad()
    {
        // ResourcesフォルダからCardManagerをロード
        var cardManagerPrefab = Resources.Load<GameObject>("CardManager");
        
        if (cardManagerPrefab != null)
        {
            // CardManagerをシーンにインスタンス化
            var cardManagerInstance = Object.Instantiate(cardManagerPrefab);
            
            // インスタンス化されたオブジェクトをシーン切り替えで破棄しないように設定
            DontDestroyOnLoad(cardManagerInstance);
        }
        else
        {
            Debug.LogError("CardManagerがResourcesフォルダ内に見つかりませんでした");
        }
    }
}