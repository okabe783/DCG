using UnityEngine;

[CreateAssetMenu(fileName = "CardData")]
public class CardDataBase : ScriptableObject
{
   [SerializeField, Header("CardId")] private int _cardID;
   [SerializeField,Header("名前")] private string _name;
   [SerializeField, Header("Icon")] private Sprite _icon;
   [SerializeField, Header("コスト")] private int _cost;
   [SerializeField, Header("攻撃力")] private int _atk;

   public string Name => _name;

   public Sprite Icon => _icon;

   public int Cost => _cost;

   public int Atk => _atk;
}