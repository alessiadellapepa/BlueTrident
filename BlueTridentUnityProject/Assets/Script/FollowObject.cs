using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraLocation;
    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
        //cameraLocation = transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + cameraLocation;
        transform.position += transform.forward * Time.deltaTime * 5;
        transform.LookAt(target, Vector3.up);
    }
}
