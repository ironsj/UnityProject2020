using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene2 : MonoBehaviour
{
    [SerializeField] private string loadLevel;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && GlobalControl.Instance.collectedPages == 3)
        {
            SceneManager.LoadScene(loadLevel);
        }
    }
}
