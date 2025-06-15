using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenUI : MonoBehaviour
{
    public void LoadStartScene()
    {
        SceneManager.LoadScene("Title-Scene");
    }
}
