using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody playerRB;
    Camera viewC;
    Vector3 velocity;

    void Start(){
        playerRB = GetComponent<Rigidbody>();
        viewC = Camera.main;
    }

    void Update()    {
        Vector3 mousepos = viewC.ScreenToWorldPoint( new Vector3( Input.mousePosition.x, Input.mousePosition.y, viewC.transform.position.y));
        transform.LookAt( mousepos + Vector3.up * transform.position.y);
        velocity = new Vector3( Input.GetAxisRaw( "Horizontal"), 0, Input.GetAxisRaw( "Vertical")).normalized * moveSpeed;
    }
    private void FixedUpdate(){
        playerRB.MovePosition(playerRB.position + velocity * Time.fixedDeltaTime);
    }
}
