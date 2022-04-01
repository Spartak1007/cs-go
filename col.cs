using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class col : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bulletText;
    public GameObject image;
    static int bullet = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        bullet = bullet - 1;
        bulletText.text = bullet + "";
        Destroy(image);
        Destroy(gameObject);
    }
}
