using System;
using UnityEngine;

/// <summary>
/// 抽象クラス(インスタンス化不可)
/// TにはMonoBehaviourを継承している型のみ指定できる
/// </summary>
public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                Type t = typeof(T);

                //　シーン内のT型のオブジェクトを検索してセット
                _instance = (T)FindAnyObjectByType(t);
                if (_instance == null)
                {
                    Debug.LogError(t + "アタッチしているObjectはありません");
                }
            }
            return _instance;
        }
    }

    //インスタンスが存在するかをチェックする関数
    public static bool ExistInstance()
    {
        return _instance != null;
    }
    
    protected void Awake()
    {
        CheckInstance();
    }

    //このクラスがすでにシングルトンインスタンスとして設定しているかをチェックする関数
    protected bool CheckInstance()
    {
        if (_instance == null)
        {
            _instance = this as T;
            return true;
        }
        else if(Instance == this)
        {
            return true;
        }
        Destroy(this);
        return false;
    }
}
