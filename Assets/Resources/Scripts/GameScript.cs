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
    // 
    //private Vector3 topLeftPos = 
    // Square prefab to be inserted into the board.
    public GameObject squarePrefab;
    // Start is called before the first frame update
    void Start()
    {
        for( int i = 0; i < boardWidth * boardHeight; i++)
        {
            GameObject newSpace = Instantiate(squarePrefab, gameBoard.transform);
            newSpace.transform.SetParent(gameBoard.transform);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
