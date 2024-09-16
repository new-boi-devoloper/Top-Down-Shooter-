using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    // private Player _player;
    //
    // public PlayerMovement(Player player)
    // {
    //     this._player = player;
    // }

    // public void Move(Vector2 direction, float playerSpeed)
    // {
    //     Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
    //
    //     _player.Rb.velocity = moveDirection * playerSpeed;
    // }

    public void Move(Rigidbody playerRb, Vector2 direction, float playerSpeed)
    {
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
    
        playerRb.velocity = moveDirection * playerSpeed;
    }

    public void Stop(Rigidbody playerRb)
    {
        playerRb.velocity /= 1.05f;
    }
    
    public void RotateHorizontal(Rigidbody playerRb, float playerRotation, float rotation)
    {
        // playerRb.rotation *= Quaternion.Euler(0, rotation * playerRotation, 0);
    }

    public void RotateVertical(Rigidbody playerRb, float playerRotation, float rotation)
    {
        // var verticalRotation = 0f;
        //
        // verticalRotation -= rotation * playerRotation;
        // verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        //
        // playerRb.transform.localRotation = Quaternion.Euler(verticalRotation, playerRb.transform.localRotation.eulerAngles.y, 0);
    }
}
