using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
        player.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}