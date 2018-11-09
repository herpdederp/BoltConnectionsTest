using System.Collections;
using System.Collections.Generic;
using Bolt;
using UdpKit;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShutdownTest : Bolt.GlobalEventListener
{

    public override void BoltShutdownBegin(AddCallback registerDoneCallback)
    {
        registerDoneCallback(Test0);
    }

    void Test0()
    {
        SceneManager.LoadScene("Menu");
    }

    public override void ConnectRequest(UdpEndPoint endpoint, IProtocolToken token)
    {
        BoltNetwork.Accept(endpoint);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(BoltNetwork.connections);
        Debug.Log(BoltNetwork.clients);

        if (Input.GetKeyDown(KeyCode.E))
        {

            BoltLauncher.Shutdown();
        }
    }
}
