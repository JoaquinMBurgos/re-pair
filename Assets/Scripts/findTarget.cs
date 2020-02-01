using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
            Debug.Log("Aca habria que tirar el win");
    }
    private void on(Collider other)
    {
    }

   

}
