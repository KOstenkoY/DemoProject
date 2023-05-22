using UnityEngine;

public class Window : MonoBehaviour
{
    [SerializeField] private GameObject _visual;
    [SerializeField] private tk2dButton _buttonOpenWindow;
    [SerializeField] private tk2dButton _buttonCloseWindow;

    public event System.Action OnOpen;
    public event System.Action OnClose;


    private void Start()
    {
        if(_buttonOpenWindow != null)
            _buttonOpenWindow.ButtonPressedEvent += ButtonOpenWindow_ButtonPressedEvent; ;
        if (_buttonCloseWindow != null)
            _buttonCloseWindow.ButtonPressedEvent += ButtonCloseWindow_ButtonPressedEvent;
    }

    private void OnDestroy()
    {
        if (_buttonOpenWindow != null)
            _buttonOpenWindow.ButtonPressedEvent -= ButtonOpenWindow_ButtonPressedEvent; ;
        if (_buttonCloseWindow != null)
            _buttonCloseWindow.ButtonPressedEvent -= ButtonCloseWindow_ButtonPressedEvent;
    }

    private void ButtonOpenWindow_ButtonPressedEvent(tk2dButton source)
    {
        Open();
    }

    private void ButtonCloseWindow_ButtonPressedEvent(tk2dButton source)
    {
        Close();
    }

    public virtual void Open()
    {
        _visual.SetActive(true);
        OnOpen?.Invoke();
    }    

    public void Close()
    {
        _visual.SetActive(false);
        OnClose?.Invoke();
    }
}
