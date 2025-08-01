using UnityEngine;

public class MazeCntrl : MonoBehaviour
{
    [SerializeField] private GameObject mazeNodePrefab;

    private float size = 12.0f;
    private int width = 5;
    private int height = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RenderMaze();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateMaze()
    {

    }

    private void RenderMaze()
    {
        for (int h = 0; h < height; h++)
        {
            for (int w = 0; w < width; w++)
            {
                GameObject go = Instantiate(mazeNodePrefab, gameObject.transform);
                go.transform.SetLocalPositionAndRotation(new Vector3(w*size, 0.0f, h*size), Quaternion.identity);
            }
        }
    }
}
