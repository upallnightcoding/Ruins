using UnityEngine;

public class GameManagerCntrl : MonoBehaviour
{
    [SerializeField] private PlayingCardSO testCard01;
    [SerializeField] private PlayingCardSO testCard02;
    [SerializeField] private PlayingCardSO testCard03;

    [SerializeField] private GameObject playerCardPrefab;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RenderCard(testCard01, new Vector3(-6.0f, 0.0f, 0.0f));
        RenderCard(testCard02, new Vector3(0.0f, 0.0f, 0.0f));
        RenderCard(testCard03, new Vector3(6.0f, 0.0f, 0.0f));
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
