using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScean : MonoBehaviour
{
    public void OnClickStartButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("TestCean");

    }

}