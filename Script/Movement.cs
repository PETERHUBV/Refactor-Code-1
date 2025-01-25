using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [Header("Movement")]
    [Tooltip("Horizontal Speed")]
    [SerializeField] private float moveSpeed;
    [Tooltip("Rate of change for  moveSpeed")]
    [SerializeField] private float acceleration;
    [Tooltip("Deceleration rate")]
    [SerializeField] private float deceleration;


    private float currentSpeed;
    private CharacterController CharController;
    private float initialYposition;
    // Start is called before the first frame update
    private void Awake()
    {
        CharController = GetComponent<CharacterController>();
        initialYposition = transform.position.y;


    }


    private void Move(Vector3 InputVector)
    {
        if (InputVector == Vector3.zero)
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= deceleration * Time.deltaTime;
                currentSpeed = Mathf.Max(currentSpeed, 0);
            }
        }
        else
        {
            currentSpeed = Mathf.Lerp(currentSpeed, moveSpeed, Time.deltaTime * acceleration);
        }
        Vector3 movement = InputVector.normalized * currentSpeed * Time.deltaTime;
        CharController.Move(movement);
        transform.position = new Vector3(transform.position.x, initialYposition, transform.position.z);
    }
}