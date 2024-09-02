using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTransation : MonoBehaviour
{
    public GameObject resultPanel;
    public void onClosaedResultPanel()
    {
        resultPanel.SetActive(false);
    }

    public void onHomebackTransition()
    {
        SceneManager.LoadScene("IntroScene");
    }

}
