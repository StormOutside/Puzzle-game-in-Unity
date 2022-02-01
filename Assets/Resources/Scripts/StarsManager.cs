using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsManager : MonoBehaviour
{
    public static int starsScoreLevelOne;
    public static int starsScoreLevelTwo;
    public static int starsScoreLevelThree;
    public static int starsScoreLevelFour;
    public static int starsScoreLevelFive;
    public static int starsScoreLevelSix;
    public static int starsScoreLevelSeven;
    public static int starsScoreLevelEight;

    private void Start()
    {
        StarsLevelScore();
    }
    public GameObject[] stars = new GameObject[23];
    
    public void StarsLevelScore()
    {
        if(starsScoreLevelOne == 3)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);

        }
        if (starsScoreLevelOne == 2)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);

        }
        if (starsScoreLevelOne == 1)
        {
            stars[0].SetActive(true);
        }
        if (starsScoreLevelTwo == 3)
        {

            stars[3].SetActive(true);
            stars[4].SetActive(true);
            stars[5].SetActive(true);
        }
        if (starsScoreLevelTwo == 2)
        {
            stars[3].SetActive(true);
            stars[4].SetActive(true);
        }
        if (starsScoreLevelTwo == 1)
        {
            stars[3].SetActive(true);

        }
        if (starsScoreLevelThree == 3)
        {
            stars[6].SetActive(true);
            stars[7].SetActive(true);
            stars[8].SetActive(true);
        }
        if (starsScoreLevelThree == 2)
        {

            stars[6].SetActive(true);
            stars[7].SetActive(true);
        }
        if (starsScoreLevelThree == 1)
        {

            stars[6].SetActive(true);
        }
        if (starsScoreLevelFour == 3)
        {
            stars[9].SetActive(true);
            stars[10].SetActive(true);
            stars[11].SetActive(true);
        }
        if (starsScoreLevelFour == 2)
        {
            stars[9].SetActive(true);
            stars[10].SetActive(true);

        }
        if (starsScoreLevelFour == 1)
        {
            stars[9].SetActive(true);
        }
        if (starsScoreLevelFive == 3)
        {
            stars[12].SetActive(true);
            stars[13].SetActive(true);
            stars[14].SetActive(true);
        }
        if (starsScoreLevelFive == 2)
        {
            stars[12].SetActive(true);
            stars[13].SetActive(true);

        }
        if (starsScoreLevelFive == 1)
        {
            stars[12].SetActive(true);

        }
        if (starsScoreLevelSix == 3)
        {
            stars[15].SetActive(true);
            stars[16].SetActive(true);
            stars[17].SetActive(true);
        }
        if (starsScoreLevelSix == 2)
        {
            stars[15].SetActive(true);
            stars[16].SetActive(true);

        }
        if (starsScoreLevelSix== 1)
        {
            stars[15].SetActive(true);

        }
        if (starsScoreLevelSeven == 3)
        {
            stars[18].SetActive(true);
            stars[19].SetActive(true);
            stars[20].SetActive(true);
        }
        if (starsScoreLevelSeven == 2)
        {
            stars[18].SetActive(true);
            stars[19].SetActive(true);
        }
        if (starsScoreLevelSeven == 1)
        {
            stars[18].SetActive(true);

        }
        if (starsScoreLevelEight== 3)
        {
            stars[21].SetActive(true);
            stars[22].SetActive(true);
            stars[23].SetActive(true);
        }
        if (starsScoreLevelEight == 2)
        {
            stars[21].SetActive(true);
            stars[22].SetActive(true);

        }
        if (starsScoreLevelEight == 1)
        {
            stars[21].SetActive(true);

        }
    }
}
