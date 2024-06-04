using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float horizontal;
    public float vertical;
    private Rigidbody2D _compRigidbody2D;
    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        _compRigidbody2D.velocity = new Vector2(speed * horizontal, speed * vertical);
    }
}
