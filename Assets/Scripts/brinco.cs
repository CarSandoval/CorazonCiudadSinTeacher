using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brinco : MonoBehaviour
{

    public float velocidad=1;
    public float amplitud=1;

    int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.transform.Translate(0,amplitud*Mathf.Sin((float)cont*velocidad),0);
        cont++;
    }
}
