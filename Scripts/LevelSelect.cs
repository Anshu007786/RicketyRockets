using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    public void Level1()
    {
        SceneManager.LoadScene("1.Flyover");
    }

    public void Level2()
    {
        SceneManager.LoadScene("2.inBetween");
    }

    public void Level3()
    {
        SceneManager.LoadScene("3.ToandFro");
    }

    public void Level4()
    {
        SceneManager.LoadScene("4.MovingGap");
    }

    public void Level5()
    {
        SceneManager.LoadScene("5.PreciseLanding");
    }

    public void Level6()
    {
        SceneManager.LoadScene("6.BackToTheBeginning");
    }

    public void Level7()
    {
        SceneManager.LoadScene("7.HiddenLanding");
    }

    public void Level8()
    {
        SceneManager.LoadScene("8.3rdDimension");
    }

    public void Level9()
    {
        SceneManager.LoadScene("9.TightSpaces");
    }

    public void Level10()
    {
        SceneManager.LoadScene("10.ClosedDoor");
    }

    public void Level11()
    {
        SceneManager.LoadScene("11.ThrusterDown");
    }

    public void Level12()
    {
        SceneManager.LoadScene("12.Spiral");
    }

    public void Level13()
    {
        SceneManager.LoadScene("13.Impossible");
    }

    public void Level14()
    {
        SceneManager.LoadScene("14.CloseButFar");
    }

    public void Level15()
    {
        SceneManager.LoadScene("15.Inverted");
    }

    public void Level16()
    {
        SceneManager.LoadScene("16.Falling");
    }

    public void Level17()
    {
        SceneManager.LoadScene("17.Journey'sEnd");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("0.MainM");
    }


}
