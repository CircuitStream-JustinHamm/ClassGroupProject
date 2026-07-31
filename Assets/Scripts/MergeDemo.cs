using UnityEngine;
using UnityEngine.UIElements;

public class MergeDemo : MonoBehaviour
{
    public GameObject explosionEffect;

    private Button restartButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void HelloWorld()
    {
        Debug.Log("Hello, world!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);

        restartButton.style.display = DisplayStyle.Flex;

        Debug.Log("It Explodedededed");
    }
}
