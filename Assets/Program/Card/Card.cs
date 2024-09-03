using UnityEngine;
using UnityEngine.UI;

/// <summary>Cardにアタッチ</summary>
public class Card : MonoBehaviour
{
    public int CardID { get; private set; }

   [SerializeField, Header("名前のtext")]　private Text _nameText;
   [SerializeField, Header("コストText")] private Text _costText;
   [SerializeField, Header("アイコン")]　private Image _icon;

   //Cardをセット
   public void SetID(int id)
   {
      CardID = id;
      Debug.Log(CardID);
      Debug.Log($"名前は{MasterCardList.Instance.CardDataBaseList[CardID].Name}");
      Debug.Log($"コストは{MasterCardList.Instance.CardDataBaseList[CardID].Cost}");
      
      _nameText.text = MasterCardList.Instance.CardDataBaseList[CardID].Name;
      _costText.text = MasterCardList.Instance.CardDataBaseList[CardID].Cost.ToString();
      _icon.sprite = MasterCardList.Instance.CardDataBaseList[CardID].Icon;
   }
}