using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerBehaviour : MonoBehaviour
{
    [Header("Movement Properties")] 
    public float maxSpeed = 1.0f;

    [Header("Movement Input Options")]
    public MovementOptionsSO curreMovementOptions;
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode rightKey;
    public KeyCode leftKey;

    // Start is called before the first frame update
    void Start()
    {
        loadCurrentMovementOptions();
    }

    public void loadCurrentMovementOptions()
    {
        
        upKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), curreMovementOptions.upKey.name);
        downKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), curreMovementOptions.downKey.name);
        rightKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), curreMovementOptions.rightKey.name);
        leftKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), curreMovementOptions.leftkey.name);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(upKey))
        {
            // move up
            transform.position += Vector3.forward * maxSpeed;
        }

        if (Input.GetKeyDown(downKey))
        {
            // move down
            transform.position += Vector3.back * maxSpeed;
        }

        if (Input.GetKeyDown(rightKey))
        {
            // move right
            transform.position += Vector3.right * maxSpeed;
        }

        if (Input.GetKeyDown(leftKey))
        {
            // move left
            transform.position += Vector3.left * maxSpeed;
        }

    }
}
