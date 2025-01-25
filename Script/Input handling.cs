using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputhandling : MonoBehaviour
{

    private Vector3 InputVector;

    [SerializeField] private KeyCode forward = KeyCode.W;
    [SerializeField] private KeyCode backward = KeyCode.S;
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode right = KeyCode.D;

    void Update()
    {
        InputHandling();
    }

    public void InputHandling()
    {
        float xInput = 0;
        float zInput = 0;



        if (Input.GetKey(forward))
        {
            zInput++;
        }
            if (Input.GetKey(backward))
            {

                zInput--;
            }
            if (Input.GetKey(backward))
            {
                xInput--;
            }
            if (Input.GetKey(left))
            {
                xInput--;
            }

            if (Input.GetKey(right))
            {
                xInput++;
            }
            InputVector = new Vector3(xInput, 0, zInput);
        }


    }

