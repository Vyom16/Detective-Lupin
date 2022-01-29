using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public Button shootButton;
    public Button Start1;
    public Button LevelSelect;
    public Button Level1;
    public Button Level2;
    public Button Level3;
    public Button Level4;
    public Button Level5;
    public Button Quit;



    // Start is called before the first frame update
    void Start()
    {
        shootButton = GameObject.FindGameObjectWithTag("Hide").GetComponent<Button>();
        shootButton.onClick.Invoke();



        Debug.Log("abcd");

        Start1 = GameObject.FindGameObjectWithTag("Start").GetComponent<Button>();
        Start1.onClick.AddListener(TaskOnClick1);

        Quit = GameObject.FindGameObjectWithTag("Quit").GetComponent<Button>();
        Quit.onClick.AddListener(CloseGame);

        /* Level1 = GameObject.FindGameObjectWithTag("Level1").GetComponent<Button>();
        Level1.onClick.AddListener(TaskOnClick); */

        LevelSelect = GameObject.FindGameObjectWithTag("LevelSelect").GetComponent<Button>();
        LevelSelect.onClick.AddListener(LevelSelector);


        Debug.Log("5678");

    }

    // Update is called once per frame
    void Update()
    {



    }

    void CloseGame()
    {
        Application.Quit();
    }

    void TaskOnClick1()
    {
        SceneManager.LoadScene(sceneName: "Level 1");
    }

    void TaskOnClick2()
    {
        SceneManager.LoadScene(sceneName: "Level 2");
    }

    void TaskOnClick3()
    {
        SceneManager.LoadScene(sceneName: "Level 3");
    }

    void TaskOnClick4()
    {
        SceneManager.LoadScene(sceneName: "Level 4");
    }

    void TaskOnClick5()
    {
        SceneManager.LoadScene(sceneName: "Level 5");
    }

    void LevelSelector()
    {
        Level1 = GameObject.FindGameObjectWithTag("Level1").GetComponent<Button>();
        Level1.onClick.AddListener(TaskOnClick1);

        Level2 = GameObject.FindGameObjectWithTag("Level2").GetComponent<Button>();
        Level2.onClick.AddListener(TaskOnClick2);

        Level3 = GameObject.FindGameObjectWithTag("Level3").GetComponent<Button>();
        Level3.onClick.AddListener(TaskOnClick3);

        Level4 = GameObject.FindGameObjectWithTag("Level4").GetComponent<Button>();
        Level4.onClick.AddListener(TaskOnClick4);

        Level5 = GameObject.FindGameObjectWithTag("Level5").GetComponent<Button>();
        Level5.onClick.AddListener(TaskOnClick5);
    }




}
