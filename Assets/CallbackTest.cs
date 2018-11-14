using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallbackTest : Bolt.GlobalEventListener
{

    public override void SceneLoadLocalDone(string map)
    {
        Debug.Log("SceneLoadLocalDone");
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
