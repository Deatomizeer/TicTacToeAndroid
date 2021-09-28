using UnityEngine;

// The main script responsible for the game,
// controlling players' input and checking for win.
public class GameScript : MonoBehaviour
{
    // Board size in spaces.
    public const int boardWidth = 3;
    public const int boardHeight = 3;
    // Game board reference for inserting interactable spaces.
    public GameObject gameBoard;
    // Space prefab to be inserted into the board.
    public GameObject spacePrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newSpace = Instantiate(spacePrefab);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
