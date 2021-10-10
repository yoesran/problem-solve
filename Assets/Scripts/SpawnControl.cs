using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject rect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("Spawn", 3.0f);
    }

    void Spawn()
    {
        Vector3 position = transform.position;
        position.x = Random.Range(-8.35f, 8.35f);
        position.y = Random.Range(-4f, 4f);
        rect.transform.position = position;
        Instantiate(rect);
    }
}
