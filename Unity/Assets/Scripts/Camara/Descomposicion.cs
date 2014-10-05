using UnityEngine;
using System.Collections;

public class Descomposicion : MonoBehaviour 
{
	public bool iniciaApertura;
	public bool iniciaCierre;



	void Awake()
	{
	
	}
	// Use this for initialization
	void Start () 
	{
		iniciaApertura = false;
		iniciaCierre = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(iniciaApertura)
		{

			Camera.main.GetComponent<TouchCamController>().distance = 5.7f;
			animation.Play();
			iniciaApertura = false;

		

		}
		if(iniciaCierre)
		{

		}
	}
}
