using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    private bool _toggleState;
    public void ToggleLightState()
    {
        if (_toggleState)
        {
            this.gameObject.SetActive(true);
            _toggleState = false;
        }
        else
        {
            this.gameObject.SetActive(false);
            _toggleState = true;
        }
    }
}
