using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PieceScript4 : MonoBehaviour
{
    public Vector3 RightPosition;
    public float RightRotation;

    public bool InRightPosition;
    public bool Selected;

    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        RightRotation = transform.rotation.z;

        string name = gameObject.name;
        Debug.Log(name);

        if (name == "Level 4_0")
            transform.position = new Vector3(6.6f, -3.7f);

        if (name == "Level 4_1")
            transform.position = new Vector3(6.1f, 3.1f);

        if (name == "Level 4_2")
            transform.position = new Vector3(6.0f, -0.7f);

        if (name == "Level 4_3")
            transform.position = new Vector3(5.6f, 1.6f);

        if (name == "Level 4_4")
            transform.position = new Vector3(6.6f, -3.7f);

        if (name == "Level 4_5")
            transform.position = new Vector3(6.6f, -3.7f);

        if (name == "Level 3_1")
            transform.position = new Vector3(6.1f, 3.1f);

        if (name == "Level 3_2")
            transform.position = new Vector3(6.0f, -0.7f);



        /* transform.position = new Vector3(5.3f, Random.Range(-4f, 4f)); */

        Quaternion randrotation = Quaternion.Euler(0, 0, Random.Range(-20f, 20f));
        transform.rotation = randrotation;

    }

    // Update is called once per frame
    void Update()
    {
        /* Debug.Log(gameObject.name);
        Debug.Log(transform.position); */

        /* .Log(transform.rotation.z - RightRotation); */
        if ((Vector3.Distance(transform.position, RightPosition) < 0.5f) && ((transform.rotation.z - RightRotation) < 0.05f && (transform.rotation.z - RightRotation) > -0.05f))
        {
            if (!Selected)
            {

                Quaternion fixrotation = Quaternion.Euler(0, 0, RightRotation);
                transform.rotation = fixrotation;

                transform.position = RightPosition;
                InRightPosition = true;

            }
        }


        var objects = GameObject.FindGameObjectsWithTag("Puzzle4");
        var objectCount = objects.Length;
        int count = 0;
        Debug.Log(count);
        foreach (var obj in objects)
        {
            Debug.Log(count);
            if (obj.GetComponent<PieceScript4>().InRightPosition)
            {
                count = count + 1;
                Debug.Log(count);
            }
        }

        if (count == objectCount - 2)
        {
            Debug.Log("Vyom");
            SceneManager.LoadScene(sceneName: "MainMenu");
        }

    }


}
