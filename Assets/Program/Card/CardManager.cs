using System.Collections.Generic;
using UnityEngine;

/// <summary>Cardの情報を管理</summary>
public class CardManager : SingletonMonoBehaviour<CardManager>
{
   [SerializeField, Header("全てのカードリスト")] private MasterCardList _masterCardList;
   [SerializeField, Header("Card")]　private Card _card;
   [SerializeField, Header("初期手札")] private int _firsthand;

   private List<Card> _hand = new();
   
   //ゲーム開始時にカードを3枚配る
   public void FirstHand(PlayerHand hand)
   {
      var random = Random.Range(0, _masterCardList.CardDataBaseList.Count);
         //カードを生成してhandの子オブジェクトにしてCardIdを渡す
         var addCard = Instantiate(_card, hand.transform);
         //カードにIDを渡す
         addCard.SetID(random);
         //手札にカードを追加
         _hand.Add(addCard);
   }
}
