using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    void Update()
	{
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            SceneManager.LoadScene(1);
        }
	}
}
