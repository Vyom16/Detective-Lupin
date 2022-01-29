using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragandDrop4 : MonoBehaviour
{
    public GameObject SelectedPiece;
    public int count = 0;
    public Button shootButton;

    // Start is called before the first frame update
    void Start()
    {
        shootButton = GameObject.FindGameObjectWithTag("Hide").GetComponent<Button>();
        shootButton.onClick.Invoke();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle4"))
            {
                Debug.Log("Vyom");
                if (!hit.transform.GetComponent<PieceScript4>().InRightPosition)
                {
                    Debug.Log("Vyom2");
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PieceScript4>().Selected = true;
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<PieceScript4>().Selected = false;
                SelectedPiece = null;
            }
        }

        float horizontal = Input.GetAxis("Horizontal");
        /*Debug.Log(horizontal);*/
        SelectedPiece.transform.Rotate(Vector3.forward * -0.1f * horizontal);


        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }




    }
}
