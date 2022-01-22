using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentHandler : MonoBehaviour
{
    public GameObject card;
    public bool Spells;
    public void AddOneCard(int id)
    {
        GameObject _Obj = Instantiate(card,transform);
        _Obj.GetComponent<TowerCardDeckSelecter>().initiziate(id);
    }

    private void Awake()
    {
        if (!Spells)
        {
            AddTowers();
        }
        else
        {
            AddSpells();
        }
    }

    public void AddTowers()
    {
        if (GameManager.instance == null) return;
        TowerData[] towers = GetTowerData();

        for (int i = 0; i < towers.Length; i++)
        {
            AddOneCard(towers[i].cardID);
        }
    }

    public void AddSpells()
    {
        if (GameManager.instance == null) return;
        SpellData[] towers = GetSpellData();

        for (int i = 0; i < towers.Length; i++)
        {
            AddOneCard(towers[i].cardID);
        }
    }

    public SpellData[] GetSpellData()
    {
        List<SpellData> result = new List<SpellData>();
        foreach (CardData cardData in GameManager.instance.cardDatabase.cardData)
        {
            if (cardData.GetType() == typeof(SpellData))
            {
                result.Add((SpellData)cardData);
            }
        }
        return result.ToArray();
    }

    public TowerData[] GetTowerData()
    {
        List<TowerData> result = new List<TowerData>();
        foreach(CardData cardData in GameManager.instance.cardDatabase.cardData)
        {
            if (cardData.GetType() == typeof(TowerData))
            {
                result.Add((TowerData)cardData);
            }
        }
        return result.ToArray();
    } 
}
