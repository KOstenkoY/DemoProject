using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private tk2dButton _exitButton;

    private void Start()
    {
        _exitButton.ButtonPressedEvent += Button_ButtonPressedEvent;
    }

    private void OnDestroy()
    {
        _exitButton.ButtonPressedEvent -= Button_ButtonPressedEvent;
    }

    protected virtual void Button_ButtonPressedEvent(tk2dButton source)
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
