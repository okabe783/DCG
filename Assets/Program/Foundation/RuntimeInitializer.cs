using UnityEngine;

/// <summary>Editor実行時に呼び出される </summary>
public class RuntimeInitializer : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void InitializeBeforeSceneLoad()
    {
        var cardManager = Resources.Load("CardManager");
        DontDestroyOnLoad(cardManager);
    }
}