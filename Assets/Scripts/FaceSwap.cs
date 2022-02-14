using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceSwap : MonoBehaviour
{
	
	public List<Material> faceMaterials = new List<Material>();
	private ARFaceManager faceManager;
	private int faceMaterialIndex = 0;

    void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
    }

	public void SwitchFace1()
	{
		foreach(ARFace face in faceManager.trackables)
		{
			face.GetComponent<Renderer>().material = faceMaterials[0];
		}
	}
	
	public void SwitchFace2()
	{
		foreach(ARFace face in faceManager.trackables)
		{
			face.GetComponent<Renderer>().material = faceMaterials[1];
		}
	}
	
	public void SwitchFace3()
	{
		foreach(ARFace face in faceManager.trackables)
		{
			face.GetComponent<Renderer>().material = faceMaterials[2];
		}
	}
	
	public void SwitchFace4()
	{
		foreach(ARFace face in faceManager.trackables)
		{
			face.GetComponent<Renderer>().material = faceMaterials[3];
		}
	}
	
	public void SwitchFace5()
	{
		foreach(ARFace face in faceManager.trackables)
		{
			face.GetComponent<Renderer>().material = faceMaterials[4];
		}
	}
	
	public void SwitchFace6()
	{
		foreach(ARFace face in faceManager.trackables)
		{
			face.GetComponent<Renderer>().material = faceMaterials[5];
		}
	}
	
	public void SwitchFace7()
	{
		foreach(ARFace face in faceManager.trackables)
		{
			face.GetComponent<Renderer>().material = faceMaterials[6];
		}
	}
	
	public void SwitchFace8()
	{
		foreach(ARFace face in faceManager.trackables)
		{
			face.GetComponent<Renderer>().material = faceMaterials[7];
		}
	}
	
}
