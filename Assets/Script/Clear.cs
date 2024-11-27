using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("asdfvgbn");
        if (other.gameObject.CompareTag("goal"))
        {
            SceneManager.LoadScene("Result");
        }
    }
}
