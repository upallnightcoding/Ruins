using UnityEngine;

[CreateAssetMenu(fileName = "PlayingCard", menuName = "Ruins/Playing Card")]
public class PlayingCardSO : ScriptableObject
{
    public PlayingCardType playingCardType;

    public string cardName;

    public Sprite cardImage;

    public int health;
    public int damage;
}

public enum PlayingCardType
{
    ENEMY,
    INVENTORY
}
