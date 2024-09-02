using System.Collections.Generic;
using UnityEngine;

/// <summary>Cardの情報を管理</summary>
public class CardManager : SingletonMonoBehaviour<CardManager>
{
   [SerializeField,Header("カードの情報")] private List<CardDataBase> _cardData;
   [SerializeField, Header("Card")]　private Card _card;
   [SerializeField, Header("初期手札")] private int _firsthand;

   private List<Card> _hand = new();
   
   //ゲーム開始時にカードを3枚配る
   public void FirstHand(GameObject hand)
   {
      var randomCardId = Random.Range(0, _cardData.Count);
      for (int i = 0; i < _firsthand; i++)
      {
         //カードを生成してhandの子オブジェクトにしてCardIdを渡す
         var addCard = Instantiate(_card, hand.transform.parent);
         addCard.CardID = randomCardId;
         //手札にカードを追加
         _hand.Add(addCard);
      }
   }
}
