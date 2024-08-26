using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneApps : MonoBehaviour
{
    [SerializeField] private GameObject calling;
    private Calling call;
    // Start is called before the first frame update
    void Start()
    {
        call = calling.GetComponent<Calling>();
    }

    public void AcceptCall()
    {
        call.AcceptCalling();
        call.PlayVoice();
    }

    public void CloseCall()
    {
        call.StopCalling();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
