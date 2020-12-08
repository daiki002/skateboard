using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 playerPos = this.Player.transform.position;
        transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
    }
}
