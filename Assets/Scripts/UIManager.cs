using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    /*
    public void OnMouseEnter()
    {
       FindObjectOfType<AudioManager>().Play("Start");
    }
    */
    /*
    void OntriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SettingsImage")
        {
            FindObjectOfType<AudioManager>().Play("Settings");
        }

        else if (other.gameObject.name == "PartyImage")
        {
            FindObjectOfType<AudioManager>().Play("Party");
        }

        else if (other.gameObject.name == "InvetoryImage")
        {
            FindObjectOfType<AudioManager>().Play("Equipmey");
        }

        else if (other.gameObject.name == "player")
        {
            FindObjectOfType<AudioManager>().Play("Start");
        }

        else if (other.gameObject.name == "player")
        {
            FindObjectOfType<AudioManager>().Play("Start");
        }

    }
    */

    public void Settings()
    {
        FindObjectOfType<AudioManager>().Play("Settings");
    }

    public void PartyImage()
    {
        FindObjectOfType<AudioManager>().Play("Party");
        Debug.Log("Played sound");
    }

    public void InventoryImage()
    {
        FindObjectOfType<AudioManager>().Play("Equipmey");
        Debug.Log("Played sound");
    }

    public void Credits()
    {   
        FindObjectOfType<AudioManager>().Play("Something");
    }

    public void Play()
    {
        FindObjectOfType<AudioManager>().Play("Start");
    }

    public void Hide()
    {
        canvasGroup.alpha = 0f; //this makes everything transparent
        canvasGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
    }

    public void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

}
