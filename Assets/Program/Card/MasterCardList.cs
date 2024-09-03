using System.Collections.Generic;

//全てのカードを管理
public class MasterCardList : SingletonMonoBehaviour<MasterCardList>
{
    public List<CardDataBase> CardDataBaseList = new();
}