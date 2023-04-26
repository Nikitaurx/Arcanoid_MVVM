using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField]
    [Range(10f, 60f)]
    private float speedPlayer = 15f;
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(speedPlayer * Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.7f, 7.7f), transform.position.y, transform.position.z);
    }
}
