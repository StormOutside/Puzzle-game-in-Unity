using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
  public static void SaveStars()
    {
        PlayerPrefs.SetInt("StarsLOne", StarsManager.starsScoreLevelOne);
        PlayerPrefs.SetInt("StarsLTwo", StarsManager.starsScoreLevelTwo);
        PlayerPrefs.SetInt("StarsLThree", StarsManager.starsScoreLevelThree);
        PlayerPrefs.SetInt("StarsLFour", StarsManager.starsScoreLevelFour);
        PlayerPrefs.SetInt("StarsLFive", StarsManager.starsScoreLevelFive);
        PlayerPrefs.SetInt("StarsLSix", StarsManager.starsScoreLevelSix);
        PlayerPrefs.SetInt("StarsLSeven", StarsManager.starsScoreLevelSeven);
        PlayerPrefs.SetInt("StarsLEight", StarsManager.starsScoreLevelEight);
        PlayerPrefs.Save();

    }
    public static void LoadStars()
    {
        StarsManager.starsScoreLevelOne = PlayerPrefs.GetInt("StarsLOne");
        StarsManager.starsScoreLevelTwo = PlayerPrefs.GetInt("StarsLTwo");
        StarsManager.starsScoreLevelThree = PlayerPrefs.GetInt("StarsLThree");
        StarsManager.starsScoreLevelFour = PlayerPrefs.GetInt("StarsLFour");
        StarsManager.starsScoreLevelFive = PlayerPrefs.GetInt("StarsLFive");
        StarsManager.starsScoreLevelSix = PlayerPrefs.GetInt("StarsLSix");
        StarsManager.starsScoreLevelSeven = PlayerPrefs.GetInt("StarsLSeven");
        StarsManager.starsScoreLevelEight = PlayerPrefs.GetInt("StarsLEight");
    }
    private void Awake()
    {
        LoadStars();
    }

}
