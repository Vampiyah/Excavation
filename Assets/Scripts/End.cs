using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void ChangeScene(string sceneName)
    {
        //the end of the game
    public string End;


    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        //get the object we collide with
        Collider2D objectWeCollideWith = collisionData.collider;
    }
        public void ChangeScene(string sceneName)

        {
            SceneManager.LoadScene("End");
        }



    }
}
