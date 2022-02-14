using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchScript : MonoBehaviour
{
	[SerializeField]
	private InputField searchInput;
	
	[SerializeField]
	private Button tomford;
	
	[SerializeField]
	private Button stepper;
	
	[SerializeField]
	private Button playmonster;
	
	[SerializeField]
	private Button oakley;
	
	[SerializeField]
	private Button masaki;
	
	[SerializeField]
	private Button front;
	
	[SerializeField]
	private Button emporio;
	
	[SerializeField]
	private Button silhouette;
	
	[SerializeField]
	private GameObject b;
	
	void Start() {
		tomford.gameObject.SetActive(false);
		stepper.gameObject.SetActive(false);
		playmonster.gameObject.SetActive(false);
		oakley.gameObject.SetActive(false);
		masaki.gameObject.SetActive(false);
		front.gameObject.SetActive(false);
		emporio.gameObject.SetActive(false);
		silhouette.gameObject.SetActive(false);
		b.gameObject.SetActive(true);
	}

    // Update is called once per frame
    void Update()
    {
		b.gameObject.SetActive(false);
		
        if(searchInput.text == "Tom Ford" || searchInput.text == "tom ford") {
			tomford.gameObject.SetActive(true);
		} else if (searchInput.text == "Stepper" || searchInput.text == "stepper"){
			stepper.gameObject.SetActive(true);
		} else if (searchInput.text == "Playmonster" || searchInput.text == "playmonster") {
			playmonster.gameObject.SetActive(true);
		} else if (searchInput.text == "Silhouette" || searchInput.text == "silhouette") {
			silhouette.gameObject.SetActive(true);
		} else if (searchInput.text == "Oakley" || searchInput.text == "oakley") {
			oakley.gameObject.SetActive(true);
		} else if (searchInput.text == "Masaki" || searchInput.text == "masaki") {
			masaki.gameObject.SetActive(true);
		} else if (searchInput.text == "Front" || searchInput.text == "front") {
			front.gameObject.SetActive(true);
		} else if (searchInput.text == "Emporio Armani" || searchInput.text == "emporio"){
			emporio.gameObject.SetActive(true);
		} else if (searchInput.text == "") {
			b.gameObject.SetActive(true);
		} else {
			tomford.gameObject.SetActive(false);
			stepper.gameObject.SetActive(false);
			playmonster.gameObject.SetActive(false);
			oakley.gameObject.SetActive(false);
			masaki.gameObject.SetActive(false);
			front.gameObject.SetActive(false);
			emporio.gameObject.SetActive(false);
			silhouette.gameObject.SetActive(false);
			b.gameObject.SetActive(false);
		}
    }
}
