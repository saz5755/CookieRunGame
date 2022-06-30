using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLoop : MonoBehaviour
{
    private float width;
    private BoxCollider2D box;
    private void Awake()
    {
        box = GetComponent<BoxCollider2D>();
        this.width = box.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= -width)
        {
            this.Reposition();
        }
    }

    private void Reposition()
    {
        Vector2 offset = new Vector2(this.width * 2, 0) * 3;
        this.transform.position = (Vector2)this.transform.position + offset ;
    }
}