using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWithMouseMove : MonoBehaviour
{
    // Kecepatan gerak
    public float speed = 5f;

    // Rigidbody 2D 
    private Rigidbody2D rigidBody2D;

    // Batas atas dan bawah game scene (Batas bawah menggunakan minus (-))
    public float yBoundary = 4.0f;

    // Batas kanan dan kiri game scene (Batas kiri menggunakan minus (-))
    public float xBoundary = 8.0f;

    private Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 tmpDir = mousePosition - transform.position;
        transform.position = Vector2.Lerp(transform.position, mousePosition, speed * 1f / tmpDir.magnitude * Time.deltaTime);
        
        // Dapatkan posisi lingkaran sekarang.
        Vector3 position = transform.position;

        // Jika posisi lingkaran melewati batas atas (yBoundary), kembalikan ke batas atas tersebut.
        if (position.y > yBoundary)
        {
            position.y = yBoundary;
        }

        // Jika posisi lingkaran melewati batas bawah (-yBoundary), kembalikan ke batas atas tersebut.
        else if (position.y < -yBoundary)
        {
            position.y = -yBoundary;
        }

        // Jika posisi lingkaran melewati batas atas (xBoundary), kembalikan ke batas atas tersebut.
        if (position.x > xBoundary)
        {
            position.x = xBoundary;
        }

        // Jika posisi lingkaran melewati batas bawah (-xBoundary), kembalikan ke batas atas tersebut.
        else if (position.x < -xBoundary)
        {
            position.x = -xBoundary;
        }

        // Masukkan kembali posisinya ke transform.
        transform.position = position;
    }
}
