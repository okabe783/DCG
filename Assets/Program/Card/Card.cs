using UnityEngine;
using UnityEngine.UI;

/// <summary>Cardにアタッチ</summary>
public class Card : MonoBehaviour
{
   #region カードの情報

   public int CardID;
   public string Name;
   public int Cost;
   public int Atk;
   public Sprite Icon;

   #endregion
   
   private void Start()
   {
      //ToDo:CardIDからView情報を取得する
   }
}