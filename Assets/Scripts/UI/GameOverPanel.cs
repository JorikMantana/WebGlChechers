using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public GameObject Board;
    public TextMeshProUGUI WinnerText;
    public GameAudio GameAudio;

    private Animator gameOverPanelAnimator;

    [SerializeField] private GameObject blackWin;
    [SerializeField] private GameObject whiteWin;

    private void Awake()
    {
        gameOverPanelAnimator = GetComponent<Animator>();
    }

    public void SetWinnerText(PawnColor winnerPawnColor)
    {
        if(winnerPawnColor == PawnColor.White)
        {
            blackWin.SetActive(false);
            whiteWin.SetActive(true);
        }

        if(winnerPawnColor == PawnColor.Black)
        {
            whiteWin.SetActive(false);
            blackWin.SetActive(true);
        }
    }

    public void DisableBoard()
    {
        Board.SetActive(false);
    }

    public void ReturnToMenu()
    {
        gameOverPanelAnimator.SetTrigger("ReturnToMenu");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void FadeGameMusic()
    {
        GameAudio.FadeGameMusic();
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}