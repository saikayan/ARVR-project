using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonchange : MonoBehaviour
{
    public GameObject button_object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void whenButtonClicked()
    {
        if (button_object.activeInHierarchy == true)
        button_object.SetActive(false);
        else
        button_object.SetActive(true);
    }
}
