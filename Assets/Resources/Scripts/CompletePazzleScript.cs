using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompletePazzleScript : MonoBehaviour
{
    public Transform pazzle1Position;
    public Transform pazzle2Position;
    public Transform pazzle4Position;
    public Transform pazzle5Position;
    public Transform pazzle6Position;
    public Transform pazzle7Position;
    public Transform pazzle8Position;
    public Transform pazzle9Position;
    public Image completePazzlePanel;
    public Timer timerPazzle;
    public Text timeScore;
    public GameObject starPanelPazzleComplete1;
    public GameObject starPanelPazzleComplet2;
    public GameObject starPanelPazzleComplete3;
    public GameObject starBack1;
    public GameObject starBack2;
    public GameObject starBack3;
    string pazzleLevelScene;
   
    private void Start()
    {
        completePazzlePanel.gameObject.SetActive(false);
        starPanelPazzleComplete1.SetActive(false);
        starPanelPazzleComplet2.SetActive(false);
        starPanelPazzleComplete3.SetActive(false);
        starBack1.SetActive(false);
        starBack2.SetActive(false);
        starBack3.SetActive(false);
        pazzleLevelScene = SceneManager.GetActiveScene().name;
       
    }
    void CompletePazzle3x3()
    {
        if (pazzle1Position.transform.position.x == -1.66f && pazzle1Position.transform.position.y == 1.66f &&
            pazzle2Position.transform.position.x == 0f && pazzle2Position.transform.position.y == 1.66f &&
            pazzle4Position.transform.position.x == -1.66f && pazzle4Position.transform.position.y == 0f &&
            pazzle5Position.transform.position.x == 0f && pazzle5Position.transform.position.y == 0f &&
            pazzle6Position.transform.position.x == 1.66f && pazzle6Position.transform.position.y == 0f &&
            pazzle7Position.transform.position.x == -1.66f && pazzle7Position.transform.position.y == -1.66f &&
            pazzle8Position.transform.position.x == 0f && pazzle8Position.transform.position.y == -1.66f &&
            pazzle9Position.transform.position.x == 1.66f && pazzle9Position.transform.position.y == -1.66f)
        {
            Time.timeScale = 0;
            completePazzlePanel.gameObject.SetActive(true);
            starBack1.SetActive(true);
            starBack2.SetActive(true);
            starBack3.SetActive(true);
            if (pazzleLevelScene == "3x3 Pazzle 1")
            {
                TimeManager.timeScoreLevelOneMinute = timerPazzle.minute;
                TimeManager.timeScoreLevelOneSecond = timerPazzle.second;
                timeScore.text = timerPazzle.minuteText.text + ":" + timerPazzle.secondText.text;
                if (TimeManager.timeScoreLevelOneMinute == 0.0f && TimeManager.timeScoreLevelOneSecond <= 59.0f ||
                    TimeManager.timeScoreLevelOneMinute == 1.0f && TimeManager.timeScoreLevelOneSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelOne = 3;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                    starPanelPazzleComplete3.SetActive(true);
                }
                if (TimeManager.timeScoreLevelOneMinute == 1.0f && TimeManager.timeScoreLevelOneSecond >= 31.0f ||
                    TimeManager.timeScoreLevelOneMinute == 2.0f && TimeManager.timeScoreLevelOneSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelOne = 2;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                }
                if (TimeManager.timeScoreLevelOneMinute == 2.0f && TimeManager.timeScoreLevelOneSecond >= 31.0f ||
                    TimeManager.timeScoreLevelOneMinute >= 3.0f && TimeManager.timeScoreLevelOneSecond >= 0.0f)
                {
                    StarsManager.starsScoreLevelOne = 1;
                    starPanelPazzleComplete1.SetActive(true);
                }
            }
            if (pazzleLevelScene == "3x3 Pazzle 2")
            {
                TimeManager.timeScoreLevelTwoMinute = timerPazzle.minute;
                TimeManager.timeScoreLevelTwoSecond = timerPazzle.second;
                timeScore.text = timerPazzle.minuteText.text + ":" + timerPazzle.secondText.text;
                if (TimeManager.timeScoreLevelTwoMinute == 0.0f && TimeManager.timeScoreLevelTwoSecond <= 59.0f ||
                    TimeManager.timeScoreLevelTwoMinute == 1.0f && TimeManager.timeScoreLevelTwoSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelTwo = 3;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                    starPanelPazzleComplete3.SetActive(true);
                }
                if (TimeManager.timeScoreLevelTwoMinute == 1.0f && TimeManager.timeScoreLevelTwoSecond >= 31.0f ||
                    TimeManager.timeScoreLevelTwoMinute == 2.0f && TimeManager.timeScoreLevelTwoSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelTwo = 2;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                }
                if (TimeManager.timeScoreLevelTwoMinute == 2.0f && TimeManager.timeScoreLevelTwoSecond >= 31.0f ||
                    TimeManager.timeScoreLevelTwoMinute >= 3.0f && TimeManager.timeScoreLevelTwoSecond >= 0.0f)
                {
                    StarsManager.starsScoreLevelTwo = 1;
                    starPanelPazzleComplete1.SetActive(true);
                }
            }
            if (pazzleLevelScene == "3x3 Pazzle 3")
            {
                TimeManager.timeScoreLevelThreeMinute = timerPazzle.minute;
                TimeManager.timeScoreLevelThreeSecond = timerPazzle.second;
                timeScore.text = timerPazzle.minuteText.text + ":" + timerPazzle.secondText.text;
                if (TimeManager.timeScoreLevelThreeMinute == 0.0f && TimeManager.timeScoreLevelThreeSecond <= 59.0f ||
                    TimeManager.timeScoreLevelThreeMinute == 1.0f && TimeManager.timeScoreLevelThreeSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelThree = 3;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                    starPanelPazzleComplete3.SetActive(true);
                }
                if (TimeManager.timeScoreLevelThreeMinute == 1.0f && TimeManager.timeScoreLevelThreeSecond >= 31.0f ||
                    TimeManager.timeScoreLevelThreeMinute == 2.0f && TimeManager.timeScoreLevelThreeSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelThree = 2;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                }
                if (TimeManager.timeScoreLevelThreeMinute == 2.0f && TimeManager.timeScoreLevelThreeSecond >= 31.0f ||
                    TimeManager.timeScoreLevelThreeMinute >= 3.0f && TimeManager.timeScoreLevelThreeSecond >= 0.0f)
                {
                    StarsManager.starsScoreLevelThree = 1;
                    starPanelPazzleComplete1.SetActive(true);
                }
            }
            if (pazzleLevelScene == "3x3 Pazzle 4")
            {
                TimeManager.timeScoreLevelFourMinute = timerPazzle.minute;
                TimeManager.timeScoreLevelFourSecond = timerPazzle.second;
                timeScore.text = timerPazzle.minuteText.text + ":" + timerPazzle.secondText.text;
                if (TimeManager.timeScoreLevelFourMinute == 0.0f && TimeManager.timeScoreLevelFourSecond <= 59.0f ||
                    TimeManager.timeScoreLevelFourMinute == 1.0f && TimeManager.timeScoreLevelFourSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelFour = 3;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                    starPanelPazzleComplete3.SetActive(true);
                }
                if (TimeManager.timeScoreLevelFourMinute == 1.0f && TimeManager.timeScoreLevelFourSecond >= 31.0f ||
                    TimeManager.timeScoreLevelFourMinute == 2.0f && TimeManager.timeScoreLevelFourSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelFour = 2;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                }
                if (TimeManager.timeScoreLevelFourMinute == 2.0f && TimeManager.timeScoreLevelFourSecond >= 31.0f ||
                    TimeManager.timeScoreLevelFourMinute >= 3.0f && TimeManager.timeScoreLevelFourSecond >= 0.0f)
                {
                    StarsManager.starsScoreLevelFour = 1;
                    starPanelPazzleComplete1.SetActive(true);
                }
            }
            if (pazzleLevelScene == "3x3 Pazzle 5")
            {
                TimeManager.timeScoreLevelFiveMinute = timerPazzle.minute;
                TimeManager.timeScoreLevelFiveSecond = timerPazzle.second;
                timeScore.text = timerPazzle.minuteText.text + ":" + timerPazzle.secondText.text;
                if (TimeManager.timeScoreLevelFiveMinute == 0.0f && TimeManager.timeScoreLevelFiveSecond <= 59.0f ||
                    TimeManager.timeScoreLevelFiveMinute == 1.0f && TimeManager.timeScoreLevelFiveSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelFive = 3;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                    starPanelPazzleComplete3.SetActive(true);
                }
                if (TimeManager.timeScoreLevelFiveMinute == 1.0f && TimeManager.timeScoreLevelFiveSecond >= 31.0f ||
                    TimeManager.timeScoreLevelFiveMinute == 2.0f && TimeManager.timeScoreLevelFiveSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelFive = 2;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                }
                if (TimeManager.timeScoreLevelFiveMinute == 2.0f && TimeManager.timeScoreLevelFiveSecond >= 31.0f ||
                    TimeManager.timeScoreLevelFiveMinute >= 3.0f && TimeManager.timeScoreLevelFiveSecond >= 0.0f)
                {
                    StarsManager.starsScoreLevelFive = 1;
                    starPanelPazzleComplete1.SetActive(true);
                }
            }
            if (pazzleLevelScene == "3x3 Pazzle 6")
            {
                TimeManager.timeScoreLevelSixMinute = timerPazzle.minute;
                TimeManager.timeScoreLevelSixSecond = timerPazzle.second;
                timeScore.text = timerPazzle.minuteText.text + ":" + timerPazzle.secondText.text;
                if (TimeManager.timeScoreLevelSixMinute == 0.0f && TimeManager.timeScoreLevelSixSecond <= 59.0f ||
                    TimeManager.timeScoreLevelSixMinute == 1.0f && TimeManager.timeScoreLevelSixSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelSix = 3;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                    starPanelPazzleComplete3.SetActive(true);
                }
                if (TimeManager.timeScoreLevelSixMinute == 1.0f && TimeManager.timeScoreLevelSixSecond >= 31.0f ||
                    TimeManager.timeScoreLevelSixMinute == 2.0f && TimeManager.timeScoreLevelSixSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelSix = 2;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                }
                if (TimeManager.timeScoreLevelSixMinute == 2.0f && TimeManager.timeScoreLevelSixSecond >= 31.0f ||
                    TimeManager.timeScoreLevelSixMinute >= 3.0f && TimeManager.timeScoreLevelSixSecond >= 0.0f)
                {
                    StarsManager.starsScoreLevelSix = 1;
                    starPanelPazzleComplete1.SetActive(true);
                }
            }
            if (pazzleLevelScene == "3x3 Pazzle 7")
            {
                TimeManager.timeScoreLevelSevenMinute = timerPazzle.minute;
                TimeManager.timeScoreLevelSevenSecond = timerPazzle.second;
                timeScore.text = timerPazzle.minuteText.text + ":" + timerPazzle.secondText.text;
                if (TimeManager.timeScoreLevelSevenMinute == 0.0f && TimeManager.timeScoreLevelSevenSecond <= 59.0f ||
                    TimeManager.timeScoreLevelSevenMinute == 1.0f && TimeManager.timeScoreLevelSevenSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelSeven = 3;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                    starPanelPazzleComplete3.SetActive(true);
                }
                if (TimeManager.timeScoreLevelSevenMinute == 1.0f && TimeManager.timeScoreLevelSevenSecond >= 31.0f ||
                    TimeManager.timeScoreLevelSevenMinute == 2.0f && TimeManager.timeScoreLevelSevenSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelSeven = 2;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                }
                if (TimeManager.timeScoreLevelSevenMinute == 2.0f && TimeManager.timeScoreLevelSevenSecond >= 31.0f ||
                    TimeManager.timeScoreLevelSevenMinute >= 3.0f && TimeManager.timeScoreLevelSevenSecond >= 0.0f)
                {
                    StarsManager.starsScoreLevelSeven = 1;
                    starPanelPazzleComplete1.SetActive(true);
                }
            }
            if (pazzleLevelScene == "3x3 Pazzle 8")
            {
                TimeManager.timeScoreLevelEightMinute = timerPazzle.minute;
                TimeManager.timeScoreLevelEightSecond = timerPazzle.second;
                timeScore.text = timerPazzle.minuteText.text + ":" + timerPazzle.secondText.text;
                if (TimeManager.timeScoreLevelEightMinute == 0.0f && TimeManager.timeScoreLevelEightSecond <= 59.0f ||
                    TimeManager.timeScoreLevelEightMinute == 1.0f && TimeManager.timeScoreLevelEightSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelEight = 3;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                    starPanelPazzleComplete3.SetActive(true);
                }
                if (TimeManager.timeScoreLevelEightMinute == 1.0f && TimeManager.timeScoreLevelEightSecond >= 31.0f ||
                    TimeManager.timeScoreLevelEightMinute == 2.0f && TimeManager.timeScoreLevelEightSecond <= 30.0f)
                {
                    StarsManager.starsScoreLevelEight = 2;
                    starPanelPazzleComplete1.SetActive(true);
                    starPanelPazzleComplet2.SetActive(true);
                }
                if (TimeManager.timeScoreLevelEightMinute == 2.0f && TimeManager.timeScoreLevelEightSecond >= 31.0f ||
                    TimeManager.timeScoreLevelEightMinute >= 3.0f && TimeManager.timeScoreLevelEightSecond >= 0.0f)
                {
                    StarsManager.starsScoreLevelEight = 1;
                    starPanelPazzleComplete1.SetActive(true);
                }
            }
        }
        SaveGame.SaveStars();
    }
    #region Debug
    //This debug region
    public void BuildPazzle()
    {
        pazzle1Position.transform.position = new Vector2(-1.66f, 1.66f);

        pazzle2Position.transform.position = new Vector2(0f, 1.66f);

        pazzle4Position.transform.position= new Vector2(-1.66f, 0f);

        pazzle5Position.transform.position = new Vector2(0f, 0f);

        pazzle6Position.transform.position = new Vector2(1.66f, 0f);

        pazzle7Position.transform.position = new Vector2(-1.66f, -1.66f);

        pazzle8Position.transform.position = new Vector2(0f, -1.66f);

        pazzle9Position.transform.position = new Vector2(1.66f, -1.66f);
           
    }

    #endregion
    private void Update()
    {
        CompletePazzle3x3();
        if(Input.GetKey(KeyCode.Space))
        {
            BuildPazzle();
        }
    }
}
