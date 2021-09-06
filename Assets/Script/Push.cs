using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Push : MonoBehaviour
{
    [SerializeField]
    private GameObject mycube;
    private Transform Ts;

    float cubex;
    float cubey;
    float cubez;

    float Increase = 0;
    void Start()
    {
        Ts=mycube.GetComponent<Transform>();
    }
    
    void Update()
    {
        cubex=Ts.localScale.x;
        cubey=Ts.localScale.y;
        cubez=Ts.localScale.z;
        
        if (cubex<2)
        {
            Increase=0.55f;
        }
        else if(cubex<4)
        {
            Increase = 0.45f;
        }
        else if (cubex<6)
        {
            Increase = 0.35f;
        }
        
        if(cubex>1&&cubey>1)
        {
            Ts.localScale -= new Vector3(0.01f,0.01f,0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ts.localScale += new Vector3(Increase,Increase,0);
        }

        if(cubex>=5.4f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
