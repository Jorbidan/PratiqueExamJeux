using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helice : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") !=0)
        {
            /*Quaternion myRotation = this.transform.rotation;
            this.transform.rotation = new Quaternion(myRotation.x,
               myRotation.y,myRotation.z + 10,myRotation.w); Erreur ne sais pas pourquoi*/
            this.transform.Rotate(Vector3.back);
        }    
    }
}
