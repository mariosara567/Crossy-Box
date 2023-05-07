using UnityEngine;
using UnityEngine.UI;

public class ResumeGameplay : MonoBehaviour
{
    public Button resumeButton;

    public void Start()
    {
        // tambahkan event listener pada tombol resuming
        resumeButton.onClick.AddListener(Resume);
    }

    public void Resume()
    {
        // temukan gameObject dengan script PauseGameplay dan panggil method ResumeGame()
        GameObject pauseGameplayObject = GameObject.FindGameObjectWithTag("PlayManager");
        if (pauseGameplayObject != null)
        {
            PauseGameplay pauseGameplay = pauseGameplayObject.GetComponent<PauseGameplay>();
            if (pauseGameplay != null)
            {
                pauseGameplay.ResumeGame();
            }
        }
    }
}
