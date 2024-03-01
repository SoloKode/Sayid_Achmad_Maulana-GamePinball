using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public void MainMenu() => SceneManager.LoadScene("Main_Menu");
    public void CreditMenu() => SceneManager.LoadScene("Credit");
}
