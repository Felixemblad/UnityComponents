using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimondScript : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color newColor;
    public Transform outher;
    [Range(-1720, +1720)]
    public float rotatichoinSpeed;
    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(0.9f, 0.4f, 0.2f);
        //outher.position = new Vector3(3, 2, outher.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0f, 0f, rotatichoinSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0f, 0f, -rotatichoinSpeed * Time.deltaTime);
        transform.Translate(5 * Time.deltaTime, 0, 0, Space.Self);

    }
}
