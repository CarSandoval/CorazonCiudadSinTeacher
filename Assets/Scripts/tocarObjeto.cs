using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocarObjeto : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select Stage
                if (hit.transform.name == transform.name)
                {
                    //<SceneManager.LoadScene("SceneTwo");
                    print("toque!!!");
                }
            }
        }

    }
}
