using UnityEngine;

public class GameManagerCntrl : MonoBehaviour
{
    [SerializeField] private PlayingCardSO testCardXX;
    [SerializeField] private PlayingCardSO testCard00;
    [SerializeField] private PlayingCardSO testCard01;
    [SerializeField] private PlayingCardSO testCard02;
    [SerializeField] private PlayingCardSO testCard03;
    [SerializeField] private PlayingCardSO testCard04;
    [SerializeField] private PlayingCardSO testCard05;

    [SerializeField] private PlayingCardSO testInv00;
    [SerializeField] private PlayingCardSO testInv01;
    [SerializeField] private PlayingCardSO testInv02;
    [SerializeField] private PlayingCardSO testInv03;
    [SerializeField] private PlayingCardSO testInv04;

    [SerializeField] private GameObject playerCardPrefab;

    private float topRow = 6.0f;
    private float bottomRow = -3.0f;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RenderCard(testCardXX, new Vector3(-18.0f, 0.0f, 1.5f));
        RenderCard(testCard01, new Vector3(-12.0f, 0.0f, topRow));
        RenderCard(testCard02, new Vector3(-6.0f, 0.0f, topRow));
        RenderCard(testCard03, new Vector3(0.0f, 0.0f, topRow));
        RenderCard(testCard04, new Vector3(6.0f, 0.0f, topRow));
        RenderCard(testCard05, new Vector3(12.0f, 0.0f, topRow));

        //RenderCard(testCard00, new Vector3(-18.0f, 0.0f, bottomRow));
        RenderCard(testInv00, new Vector3(-12.0f, 0.0f, bottomRow));
        RenderCard(testInv01, new Vector3(-6.0f, 0.0f, bottomRow));
        RenderCard(testInv02, new Vector3(0.0f, 0.0f, bottomRow));
        RenderCard(testInv03, new Vector3(6.0f, 0.0f, bottomRow));
        RenderCard(testInv04, new Vector3(12.0f, 0.0f, bottomRow));
    }

    private void RenderCard(PlayingCardSO playingCard, Vector3 position)
    {
        GameObject go = Instantiate(playerCardPrefab, position, Quaternion.identity);
        go.GetComponent<PlayingCardCntrl>().Set(playingCard);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
