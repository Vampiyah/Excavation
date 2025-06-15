using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathScreenUI : MonoBehaviour
{
    public void LoadStartScene()
    {
        // loading starter scene, resetting the player to play again
        SceneManager.LoadScene("Title-Scene");
    }
}

