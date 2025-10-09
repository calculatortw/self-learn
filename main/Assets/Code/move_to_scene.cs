using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move_to_scene : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("game");
    }
}
