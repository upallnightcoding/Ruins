using UnityEngine;

public class MazeNodeCntrl : MonoBehaviour
{
    [SerializeField] private GameObject nodeBase;
    [SerializeField] private GameObject northLink;
    [SerializeField] private GameObject southLink;
    [SerializeField] private GameObject eastLink;
    [SerializeField] private GameObject westLink;

    private void SetNorthLink() => northLink.SetActive(true);
    private void SetSouthLink() => southLink.SetActive(true);
    private void SetEastLink() => eastLink.SetActive(true);
    private void SetWestLink() => westLink.SetActive(true);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        northLink.SetActive(false);
        southLink.SetActive(false);
        eastLink.SetActive(false);
        westLink.SetActive(false);
    }

    public void Set(MazeNode node)
    {
        if (node.NorthNode != null) SetNorthLink();
        if (node.SouthNode != null) SetSouthLink();
        if (node.EastNode != null) SetEastLink();
        if (node.WestNode != null) SetWestLink();

        switch(node.GetMazeNodeType())
        {
            case MazeNodeType.STARTING:
                nodeBase.GetComponent<Renderer>().material.color = Color.green;
                break;
        }
    }
}
