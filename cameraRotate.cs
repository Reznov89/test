using UnityEngine;
using System.Collections;

public class cameraRotate : MonoBehaviour {

	public GameObject camaraAR;
	public GameObject objetivo;
	private string whereTo;
	
	void Start () 
	{
		whereTo = this.gameObject.name;
	}

	void OnMouseDown () 
	{
		if (whereTo == "rotateLeft") 
		{
			camaraAR.transform.LookAt(objetivo.transform.position);
			camaraAR.transform.Translate(Vector3.left * 35f);
			//Otro metodo que probe pero me funciono meor el de lookat y translate
			//camaraAR.transform.RotateAround(coordenadas,this.transform.position, 35f);
		}
		else 
		{
			camaraAR.transform.LookAt(objetivo.transform.position);
			camaraAR.transform.Translate(Vector3.right * 35f);
			//camaraAR.transform.RotateAround(coordenadas,this.transform.position, -35f);
		}
	}
}
