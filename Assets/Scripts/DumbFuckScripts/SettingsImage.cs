using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsImage : MonoBehaviour
{
    
    public void OnMouseEnter()
    {
       FindObjectOfType<AudioManager>().Play("Settings");
    }
    
}
