using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public enum LevelType
    {
        TIMER,
        OBSTACLE,
        MOVES,
    };
    public TextMeshProUGUI puntajeCanva;
    public Grid grid;
    public int score1Star;
    public int score2Star;
    public int score3Star;
    protected LevelType type;
    public LevelType Type
    {
        get { return type; }
    }
    protected int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void GameWin()
    {
        Debug.Log("Ganaste");
        puntajeCanva.GetComponent<TextMeshProUGUI>().text = "Ganaste";
        grid.GameOver();
    }
    public virtual void GameLose()
    {
        Debug.Log("Perdiste");
        puntajeCanva.GetComponent<TextMeshProUGUI>().text = "Perdiste";
        grid.GameOver();
    }
    public virtual void OnMove()
    {
        Debug.Log("te moviste");
    }
    public virtual void OnPieceCleared(GamePiece piece)
    {
        currentScore += piece.score;
        Debug.Log("Score: " + currentScore);
    }
}
