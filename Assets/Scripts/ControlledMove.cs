using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlledMove : MonoBehaviour
{
    // Tombol untuk menggerakkan ke atas
    public KeyCode upButton = KeyCode.UpArrow;

    // Tombol untuk menggerakkan ke bawah
    public KeyCode downButton = KeyCode.DownArrow;

    // Tombol untuk menggerakkan ke kiri
    public KeyCode leftButton = KeyCode.LeftArrow;

    // Tombol untuk menggerakkan ke kanan
    public KeyCode rightButton = KeyCode.RightArrow;

    // Kecepatan gerak
    public float speed = 10.0f;

    // Rigidbody 2D 
    private Rigidbody2D rigidBody2D;

    // Batas atas dan bawah game scene (Batas bawah menggunakan minus (-))
    public float yBoundary = 4.0f;

    // Batas kanan dan kiri game scene (Batas kiri menggunakan minus (-))
    public float xBoundary = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Dapatkan kecepatan lingkaran sekarang.
        Vector2 velocity = rigidBody2D.velocity;

        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas) dan kecepatan 0 ke komponen x.
        if (Input.GetKey(upButton))
        {
            velocity.x = 0.0f;
            velocity.y = speed;
        }

        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah) dan kecepatan 0 ke komponen x.
        else if (Input.GetKey(downButton))
        {
            velocity.x = 0.0f;
            velocity.y = -speed;
        }

        // Jika pemain menekan tombol ke kiri, beri kecepatan negatif ke komponen x (ke kiri) dan kecepatan 0 ke komponen y.
        else if (Input.GetKey(leftButton))
        {
            velocity.y = 0.0f;
            velocity.x = -speed;
        }

        // Jika pemain menekan tombol ke kanan, beri kecepatan positif ke komponen x (ke kanan) dan kecepatan 0 ke komponen y.
        else if (Input.GetKey(rightButton))
        {
            velocity.y = 0.0f;
            velocity.x = speed;
        }

        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }

        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;

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
