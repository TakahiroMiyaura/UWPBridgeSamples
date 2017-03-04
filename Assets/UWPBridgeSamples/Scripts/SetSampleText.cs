// Copyright(c) 2017 Takahiro Miyaura

using UnityEngine;

public class SetSampleText : MonoBehaviour
{
    public ISetSampleTextService service;

    public GameObject Text3D;


    // Use this for initialization
    private void Start()
    {
        // Initialize Service From UWP.
        service = UWPBridgeService.GetService<ISetSampleTextService>();
    }

    // Update is called once per frame
    private void Update()
    {
        //If Service is not Initialize,Call 'Start()'.
        if (service == null)
            Start();

        //Call Service.
        var textMesh = Text3D.GetComponent<TextMesh>();
        textMesh.text = service.GetText();
    }

    //ISetSampleTextService is interface for class create on UWP Project. 
    public interface ISetSampleTextService : UWPBridgeService.IUWPBridgeService
    {
        // Get string for 3DText.
        string GetText();
    }
}