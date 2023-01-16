using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Klasa odpowiedzialna za resetowanie post�pu
/// </summary>
public class ResetProgrss : MonoBehaviour
{

    /// <summary>
    /// Funkcja resetuj�ca post�p
    /// </summary>
    public void HardReset()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("LevelReached", 0);
        PlayerPrefs.SetInt("Gold", 0);
        MenuVars.gold = 0;
        MenuVars.BG = PlayerPrefs.GetInt("Background", 1);
        MenuVars.Padle = PlayerPrefs.GetInt("Paddle", 1);
        MenuVars.Ball = PlayerPrefs.GetInt("Ball", 1);
    }


}

