using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
	private Button glassbtn;
	
	[SerializeField]
	private Button shopbtn;
	
	[SerializeField]
	private Button exitbtn;
	
	[SerializeField]
	private Image b;
	
	void Start() {
		glassbtn.gameObject.SetActive(true);
		shopbtn.gameObject.SetActive(true);
		exitbtn.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
	}

    // Update is called once per frame
    public void Glass()
    {
		glassbtn.gameObject.SetActive(true);
		shopbtn.gameObject.SetActive(true);
		exitbtn.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
    }
	
	public void appearGlass() {
		glassbtn.gameObject.SetActive(false);
		shopbtn.gameObject.SetActive(false);
		exitbtn.gameObject.SetActive(true);
        b.gameObject.SetActive(true);
	}
}
