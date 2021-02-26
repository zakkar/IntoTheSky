using MofaLib.Utilities.EventSystem;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{
    bool isSoundActive = true;
    public Button PauseButton;
    public Button SoundButton;

    public SimpleEvent OnGamePausedEvent;
    public SimpleEvent OnGameResumedEvent;

    public Sprite SoundOn;
    public Sprite SoundOff;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void OnPauseGame()
    {
        OnGamePausedEvent.Raise();
        gameObject.SetActive(true);
        PauseButton.gameObject.SetActive(false);
    }

    public void OnHomeButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void OnSoundButton()
    {
        if(isSoundActive)
        {
            SoundButton.image.sprite = SoundOff;
        }
        else
        {
            SoundButton.image.sprite = SoundOn;
        }
        isSoundActive = !isSoundActive;
    }

    public void OnResumeGame()
    {
        OnGameResumedEvent.Raise();
        gameObject.SetActive(false);
        PauseButton.gameObject.SetActive(true);
    }

    public void OnPlayerDeath()
    {
         PauseButton.gameObject.SetActive(false); 
    }
}