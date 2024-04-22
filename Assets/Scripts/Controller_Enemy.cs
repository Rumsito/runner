﻿using UnityEngine;

public class Controller_Enemy : MonoBehaviour
{
    public static float enemyVelocity;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(new Vector3(-enemyVelocity, 0, 0), ForceMode.Force);
        OutOfBounds();
    }

    public void OutOfBounds()  /// Si el enemigo se va como muy osea onda muy lejitos se elimina el objeto
    {
        if (this.transform.position.x <= -15)
        {
            Destroy(this.gameObject);
        }
    }
}
