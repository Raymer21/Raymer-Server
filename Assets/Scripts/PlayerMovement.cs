﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerMovement : NetworkBehaviour
{
    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            float moveVertical = Input.GetAxisRaw("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * 0.1f, 0, moveVertical * 0.1f);
            transform.position = transform.position + movement;
        }
    }

    void Update()
    {
        HandleMovement();
    }
}
