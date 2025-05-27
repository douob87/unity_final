using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 使用 LoadScene 必要的引用程式敘述 !!
public class Home : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_01");
    }
}
