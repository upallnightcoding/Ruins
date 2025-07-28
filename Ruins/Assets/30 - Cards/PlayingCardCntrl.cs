using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayingCardCntrl : MonoBehaviour
{
    [SerializeField] private Image enemyImage;
    [SerializeField] private TMP_Text upperRibbonName;
    [SerializeField] private TMP_Text lowerRibbonName;

    private PlayingCardSO playingCard;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Set(PlayingCardSO playingCard)
    {
        this.playingCard = playingCard;

        enemyImage.sprite = playingCard.cardImage;

        lowerRibbonName.text = playingCard.cardName;
        upperRibbonName.text = playingCard.cardName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
