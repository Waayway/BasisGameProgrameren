using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour {
    private Button button;
    private GameManager gameManager;
    public int difficulty = 1;
    
    // Start is called before the first frame update
    void Start() {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button.onClick.AddListener(setDifficulty);
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void setDifficulty() {
        gameManager.startGame(difficulty);
    }
}
