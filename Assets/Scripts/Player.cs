using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Shubham
//23BCG10021
public class Player : MonoBehaviour
{
    private Vector3 vectorA;
    private Vector3 vectorB;
    private Rigidbody rb;
    [SerializeField] private Transform targetPosition;
    [SerializeField] private Transform targetPosition2;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        vectorA = transform.position;
        vectorB = (targetPosition.position - transform.position).normalized;

        if (Input.GetKeyDown(KeyCode.W))
            Addition();
        if (Input.GetKeyDown(KeyCode.S))
            Substraction();
        if (Input.GetKeyDown(KeyCode.A))
            Multiplication();
        if (Input.GetKeyDown(KeyCode.D))
            Division();
    }

    private void Move(Vector3 direction)
    {
        rb.velocity = direction * speed * Time.deltaTime;
    }

    private void Addition()
    {
        Vector3 resultAdd = vectorA + vectorB;

        Move(resultAdd);

        Debug.Log("Addittion: " + vectorA + " + " + vectorB);
        Debug.Log("Result: " +  resultAdd);
    }

    private void Substraction()
    {
        Vector3 resultSub = vectorB - vectorA; 

        Move(resultSub);

        Debug.Log("Substraction: " + vectorA + " - " + vectorB);
        Debug.Log("Result: " + resultSub);
    }

    private void Multiplication()
    {
        Vector3 resultMulElementWise = new Vector3(vectorA.x * vectorB.x, vectorA.y * vectorB.y, vectorA.z * vectorB.z);

        Move(resultMulElementWise);

        Debug.Log("Multiplication: " + vectorA + " * " + vectorB);
        Debug.Log("Result: " + resultMulElementWise);
    }

    private void Division()
    {
        Vector3 resultDivElementWise = new Vector3(vectorA.x / vectorB.x, vectorA.y / vectorB.y, vectorA.z / vectorB.z);

        Move(resultDivElementWise);

        Debug.Log("Division: " + vectorA + " / " + vectorB);
        Debug.Log("Result: " + resultDivElementWise);
    }
}