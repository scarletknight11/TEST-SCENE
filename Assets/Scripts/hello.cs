using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour {

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube.SetActive(true);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag =="Floor")
        {
            cube.SetActive(false);
        }
    }
}
