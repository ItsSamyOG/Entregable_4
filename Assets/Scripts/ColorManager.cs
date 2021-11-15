using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorManager : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Color RandomColor()
    {
        float red, green, blue;
        red = Random.Range(0f, 1f);
        green = Random.Range(0f, 1f);
        blue = Random.Range(0f, 1f);
        return new Color(red, green, blue);

    }
    public Vector3 RandomScale()
    {
        float x, y, z;
        x = Random.Range(-1f, 1f);
        y = Random.Range(-1f, 1f);
        z = Random.Range(-1f, 1f);
        return new Vector3(x, y, z);


    }
    public Vector3 RandomPosition()
    {
        float x, y;
        x = Random.Range(-5f, 5f);
        y = Random.Range(-5f, 5f);
        return new Vector3(x, y, 0);


    }
    private void OnMouseDown()
    {
        GetComponent<MeshRenderer>().material.color = RandomColor();
        transform.localScale += RandomScale();
        transform.position = RandomPosition();

    }



}
