using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocarObjeto : MonoBehaviour
{
    public GameObject personaje;
    public float distancia = 15f;
    public string url;
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
                if (hit.transform.name == transform.name && Vector3.Distance(transform.position, personaje.transform.position)<distancia)
                {
                    //<SceneManager.LoadScene("SceneTwo");
                    Application.OpenURL(url);
                    print("toque!!!");
                }
            }
        }

    }
}
