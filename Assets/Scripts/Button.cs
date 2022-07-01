using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    //public Transform button;
    //public Transform buttonUp;
    //public Transform buttonDown;

    public Transform buttonPos, buttonUpPos, buttonDownPos;

    public UnityEvent onButtonPressed;
    public UnityEvent onButtonReleased;


    public void OnPressed()
    {
        buttonPos.position = buttonDownPos.position;
        onButtonPressed.Invoke();
    }

    public void OnReleased()
    {
        buttonPos.position = buttonUpPos.position;
        onButtonReleased.Invoke();
    }
}
