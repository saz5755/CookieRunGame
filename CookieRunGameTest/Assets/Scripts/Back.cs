using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    private float back = 1f;
    private float width= 27;
    private Material mat;
    private float x;
    private void Awake()
    {
        back = Random.Range(.3f, .8f);
        mat = GetComponent<SpriteRenderer>().material;

        BoxCollider2D backgroundCollider = this.GetComponent<BoxCollider2D>();
        this.width = backgroundCollider.size.x;
    }

    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * back;

        /*x += Time.deltaTime;
        x %= 1;

        mat.SetTextureOffset("_MainTex", new Vector2(x, 0));*/
        if (this.transform.position.x <= -width)
        {
            this.Reposition();
        }
    }

    private void Reposition()
    {
        Vector2 offset = new Vector2(this.width * 2, 0);
        this.transform.position = (Vector2)this.transform.position + offset;
    }


}
