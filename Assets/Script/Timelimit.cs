using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timelimit : MonoBehaviour
{
    float currentTime = 0;
    public float startingTime = 10f;
    public TMP_Text CountDownText;
    public GameObject gameOverPanel;

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
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
