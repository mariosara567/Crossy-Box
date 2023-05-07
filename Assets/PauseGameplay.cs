using UnityEngine;
using UnityEngine.UI;

public class PauseGameplay : MonoBehaviour
{
    float previousTimeScale;
    public Button optionButton;

    public void Start()
    {
        // tambahkan event listener pada tombol option
        optionButton.onClick.AddListener(PauseGame);
    }

    public void PauseGame()
    {
        // simpan nilai sebelumnya dari Time.timeScale
        previousTimeScale = Time.timeScale;

        // matikan pergerakan waktu pada game
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        // jika game sedang pause, kembalikan nilai Time.timeScale ke semula
        if (Time.timeScale == 0f)
        {
            Time.timeScale = previousTimeScale;
        }
    }
}
