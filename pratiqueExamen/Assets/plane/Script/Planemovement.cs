using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Planemovement : MonoBehaviour
{
    Rigidbody myRigidbody;
    public float movementSpeed;
    public float rotationSpeed;
    public ParticleSystem smokeEffect;
    public GameObject smoke;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = this.GetComponent<Rigidbody>();
        movementSpeed = 1000;
        rotationSpeed = 500;
        smokeEffect.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            if (!smokeEffect.isPlaying)
            {
                print("okays");
                smokeEffect.Play(true);
            }
           // Destroy(Instantiate(smoke,this.transform),1);
            myRigidbody.AddRelativeForce(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        else
        {
            smokeEffect.Stop();
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            myRigidbody.AddRelativeTorque(Vector3.right * Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            myRigidbody.AddRelativeTorque(Vector3.forward * Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime*-1);
        }
    }
}
