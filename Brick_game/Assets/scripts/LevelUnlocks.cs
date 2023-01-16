using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Klasa odpowiedzialna za aktywacje poziom�w w menu poziom�w
/// </summary>

public class LevelUnlocks : MonoBehaviour
{

    public Button[] buttons;


    /// <summary>
    /// Funkcja wywo�ywana przy za�adowaniu obiektu klasy. Odblokowywuje przyciski od poziom�w.
    /// </summary>
    void Start()
    {
        int LevelReached = PlayerPrefs.GetInt("LevelReached", 0);

        for (int i = 0; i < buttons.Length; i++)
        {
            if(i>LevelReached)

            buttons[i].interactable = false;
        }
    }


}
