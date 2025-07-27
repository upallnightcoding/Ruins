using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PlayingCard", menuName = "Ruins/Playing Card")]
public class PlayingCardSO : ScriptableObject
{
    public PlayingCardType playingCardType;

    public string cardName;

    public Image image;

    public int health;
    public int damage;
}

public enum PlayingCardType
{
    ENEMY,
    INVENTORY
}
