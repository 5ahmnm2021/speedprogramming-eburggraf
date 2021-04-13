using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Button wrongButton1;
    public Button wrongButton2;
    private string errorMsg = "Try again!";
    public void ButtonRightAnswer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Button1WrongAnswer()
    {
        var text = wrongButton1.GetComponentInChildren<Text>().text;
        text = errorMsg;
    }

    public void Button2WrongAnswer()
    {
        var text = wrongButton1.GetComponentInChildren<Text>().text;
        text = errorMsg;
    }
}
