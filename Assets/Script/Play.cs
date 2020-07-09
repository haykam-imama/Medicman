using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void next_intro()
    {
        SceneManager.LoadScene("intro1");
    }

    public void goto_avianflu()
    {
        SceneManager.LoadScene("intro_avianflu");
    }

    public void mulai_game1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quit_game()
    {
        Application.Quit();
    }
}
