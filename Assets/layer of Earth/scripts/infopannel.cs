using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infopannel : MonoBehaviour
{
    public GameObject info;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void WhenButtonClicked()
    {
        if (info.activeInHierarchy == true)
            info.SetActive(false);
        else
            info.SetActive(true);
    }
}
