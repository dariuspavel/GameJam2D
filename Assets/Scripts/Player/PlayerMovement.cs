using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    Vector2 storeMovement;
    Vector2 storeMousePosition;
    public Camera mousePointCamera;

    public Rigidbody2D playerRigidBody;

    // Update is called once per frame
    void Update()
    {
        storeMovement.x = Input.GetAxisRaw("Horizontal");
        storeMovement.y = Input.GetAxisRaw("Vertical");

        storeMousePosition = mousePointCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()  {

        playerRigidBody.MovePosition(playerRigidBody.position + storeMovement * moveSpeed * Time.fixedDeltaTime);

        Vector2 currentLookDirct = storeMousePosition - playerRigidBody.position;
        float playerAngle = Mathf.Atan2(currentLookDirct.y, currentLookDirct.x) * Mathf.Rad2Deg - 90f;
        playerRigidBody.rotation = playerAngle;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TeleportBoss"))
        {
            SceneManager.LoadScene("Test");
        }
    }
}
