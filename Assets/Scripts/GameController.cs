using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Window _mainMenuWindow;
    [SerializeField] private Window _pauseWindow;
    [SerializeField] private GameObject _hudVisual;

    private void Start()
    { 
        Time.timeScale = 0;
        _mainMenuWindow.Open();
        _mainMenuWindow.OnClose += StartGame;
        _pauseWindow.OnOpen += Pause;
        _pauseWindow.OnClose += UnPause;
    }

    private void StartGame()
    {
        _mainMenuWindow.OnClose -= StartGame;
        Time.timeScale = 1;
        _hudVisual.SetActive(true);
    }

    private void Pause()
    {
        _hudVisual.SetActive(false);
        Time.timeScale = 0;
    }

    private void UnPause()
    {
        Time.timeScale = 1;
        _hudVisual.SetActive(true);
    }
}
