using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables 
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -6.25f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera's position behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
