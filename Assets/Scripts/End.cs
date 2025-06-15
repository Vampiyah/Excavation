using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{



    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        //get the object we collide with
        Collider2D objectWeCollideWith = collisionData.collider;
        //change the scene to "End" which is the winning scene at the END of the game.
        ChangeScene("End");
    }
    public void ChangeScene(string sceneName)

    {
        // loading the selected scene
        SceneManager.LoadScene(sceneName);
    }



}

