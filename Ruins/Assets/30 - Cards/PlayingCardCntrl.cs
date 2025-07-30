using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class PlayingCardCntrl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject enemyImage;
    [SerializeField] private GameObject inventoryImage;
    [SerializeField] private TMP_Text upperRibbonName;
    [SerializeField] private TMP_Text lowerRibbonName;

    [SerializeField] private GameObject healthIcon;
    [SerializeField] private GameObject damageIcon;

    [SerializeField] private GameObject lowerRibbon;
    [SerializeField] private GameObject upperRibbon;

    [SerializeField] private TMP_Text description;

    private PlayingCardSO playingCard;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Set(PlayingCardSO playingCard)
    {
        this.playingCard = playingCard;

        enemyImage.GetComponent<Image>().sprite = playingCard.cardImage;
        inventoryImage.GetComponent<Image>().sprite = playingCard.cardImage;

        lowerRibbonName.text = playingCard.cardName;
        upperRibbonName.text = playingCard.cardName;

        description.text = playingCard.description;

        healthIcon.SetActive(false);
        damageIcon.SetActive(false);

        upperRibbon.SetActive(false);
        lowerRibbon.SetActive(false);

        enemyImage.SetActive(false);
        inventoryImage.SetActive(false);

        switch (playingCard.playingCardType)
        {
            case PlayingCardType.DECK:
                enemyImage.SetActive(true);
                break;
            case PlayingCardType.ENEMY:
                healthIcon.SetActive(true);
                damageIcon.SetActive(true);
                enemyImage.SetActive(true);
                lowerRibbon.SetActive(true);
                break;
            case PlayingCardType.INVENTORY:
                inventoryImage.SetActive(true);
                upperRibbon.SetActive(true);
                damageIcon.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("On Pointer Enter ...");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("On Pointer Exit ...");
    }
}
