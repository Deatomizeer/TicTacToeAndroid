using UnityEngine;
using UnityEngine.UI;

// A piece of code responsible for an individual button's responsiveness.
public class SquareScript : MonoBehaviour
{
    // Game code reference to validate moves and check for game over.
    public GameScript gs;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(OnClickFunction);
    }
    // Connect the references to other objects and scripts when spawned.
    void Initialize(GameScript gs)
    {
        this.gs = gs;
    }

    private void OnClickFunction()
    {
        Debug.Log("It just works");
    }
}
