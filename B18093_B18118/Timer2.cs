using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer2 : MonoBehaviour
{
    public GameObject textDisplay;
    public int seconds = 40;
    public bool take = false;

    IEnumerator TimerTake()
    {
        take = true;
        yield return new WaitForSeconds(1);
        seconds -= 1;
        textDisplay.GetComponent<Text>().text = "00:" + seconds;
        take = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + seconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (take == false && seconds > 0)
        {
            StartCoroutine(TimerTake());
        }
        if (seconds == 0)
        {
            SceneManager.LoadScene(sceneName: "MainMenu");
        }
    }
}
