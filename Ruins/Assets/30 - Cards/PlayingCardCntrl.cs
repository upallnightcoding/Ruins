using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class PlayingCardCntrl : MonoBehaviour
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

    [SerializeField] private GameObject highLight;

    [SerializeField] private GameObject vfx;

    private bool highLightSw = false;

    private string cardName;

    void Start()
    {
        
    }

    public void Set(PlayingCardSO playingCard)
    {
        cardName = playingCard.playingCardType.ToString() + " " + playingCard.cardName;

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

    public void SetHighLight()
    {
        highLightSw = true;
        highLight.SetActive(highLightSw);
    }

    public void UnSetHighLight()
    {
        highLightSw = false;
        highLight.SetActive(highLightSw);
    }

    public void TurnOver()
    {
        transform.DORotate(new Vector3(0.0f, 0.0f, 180.0f), 1.0f);
        Instantiate(vfx, transform.position, Quaternion.identity);
    }

    public override string ToString()
    {
        return (cardName);
    }
}

public enum PlayingCardType
{
    ENEMY,
    INVENTORY,
    DECK
}

