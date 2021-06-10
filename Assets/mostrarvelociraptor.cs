using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mostrarvelociraptor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject info;
    private bool Show = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mostrarveloci()
    {
    	if(!Show)
    	{
    		info.SetActive(true);
    		Show = true;
    	}
    	else
    	{
    		info.SetActive(false);
    		Show= false;
    	}
    }
}
