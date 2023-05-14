using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    //this is our speed of the texture movement
    public float speed = 0.5f;

    private Renderer renderer;
    [SerializeField] float offset; 


    // Start is called before the first frame update
    void Start()
    {

        //we now have the Renderer componet so we can change it
        renderer = GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {
        // this is to increase the offset based on general time
        offset += Time.deltaTime * speed;

        //keeps our Offset inbetween 0 and 1
        if (offset > 1)
        {
            offset -= 1;
        }

        // applies the offset to our material so it can move
        renderer.material.mainTextureOffset = new Vector2(0, offset);

    }
}
