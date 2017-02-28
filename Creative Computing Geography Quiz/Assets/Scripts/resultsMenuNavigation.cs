using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class resultsMenuNavigation : MonoBehaviour {

    void Start()
    {

    }

    public void UserSelectmainMenu() // takes user back to the main menu
    {
        SceneManager.LoadScene("mainMenu"); // if questions done = all of them, load results screen
    }

    public void UserSelectQuiz() // takes user back to the main menu
    {
        SceneManager.LoadScene("quizScene"); // if questions done = all of them, load results screen
    }

    public void UserSelectLearnMenu()
    {
        SceneManager.LoadScene("learnMenu");
    }

    public void UserSelectNorthAmerica()
    {
        SceneManager.LoadScene("northAmerica");
    }

    public void UserSelectNorthAmerica2()
    {
        SceneManager.LoadScene("northAmerica2");
    }

    public void UserSelectSouthAmerica()
    {
        SceneManager.LoadScene("southAmerica");
    }

    public void UserSelectSouthAmerica2()
    {
        SceneManager.LoadScene("southAmerica2");
    }

    public void UserSelectEurope()
    {
        SceneManager.LoadScene("europe");
    }

    public void UserSelectEurope2()
    {
        SceneManager.LoadScene("europe1");
    }

    public void UserSelectAfrica()
    {
        SceneManager.LoadScene("africa");
    }

    public void UserSelectAfrica2()
    {
        SceneManager.LoadScene("africa1");
    }

    public void UserSelectAustralia()
    {
        SceneManager.LoadScene("australia");
    }

    public void UserSelectAustralia2()
    {
        SceneManager.LoadScene("australia1");
    }

    public void UserSelectAsia()
    {
        SceneManager.LoadScene("asia");
    }

    public void UserSelectAsia2()
    {
        SceneManager.LoadScene("asia1");
    }

    public void UserSelectAntarctica()
    {
        SceneManager.LoadScene("antarctica");
    }

    public void UserSelectAntarctica2()
    {
        SceneManager.LoadScene("antarctica1");
    }

    public void UserSelectEndEarly()
    {
        SceneManager.LoadScene("resultsScene"); // if questions done = all of them, load results screen
    }

    public void UserSelectTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }

    public void UserSelectQuit() // takes user back to the main menu
    {
        Application.Quit();
    }


}
