using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] float backAndForth;
    [SerializeField] float speed;

    private Vector3 startingPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startingPosition;
        v.z += backAndForth * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
