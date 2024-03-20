using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timelimit : MonoBehaviour
{
    float currentTime = 0;
    public float startingTime = 10f;
    public TMP_Text CountDownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;

    }

    // Update is called once per frame
    void Update()
    {
        currentTime -=1 * Time.deltaTime;
        CountDownText.text = "Remaining Time:" + currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            Time.timeScale = 0;
        }

        if (currentTime == 0) 
        {
            SceneManager.LoadSceneAsync(2);
        }

    }
}
