using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);



        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Pick Up"))

        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

        }

    }
    void SetCountText()
    {
        //countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
        }

    }
}
