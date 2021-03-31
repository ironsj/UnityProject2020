using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (GlobalControl.Instance.collectedPages == 1)
            {
                this.gameObject.SetActive(false);
            }
        }
        else if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            if(GlobalControl.Instance.collectedPages == 3)
            {
                this.gameObject.SetActive(false);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (GlobalControl.Instance.collectedPages == 6)
            {
                this.gameObject.SetActive(false);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (GlobalControl.Instance.collectedPages == 10)
            {
                this.gameObject.SetActive(false);
            }
        }


    }
}
