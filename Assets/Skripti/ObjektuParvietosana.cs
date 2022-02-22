using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Lietos interfeisus, lai nodrosinatu peles funkcijas
using UnityEngine.EventSystems;


public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	private RectTransform transformacijuLogs;
	public Canvas kanva;

	void Start () {
		transformacijuLogs = GetComponent<RectTransform> ();
	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais klikskis uz objekta");
	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta objekta vilksana");
	}
	public void OnDrag(PointerEventData notikums){
		transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Objekta vilksana partraukta!");
	}

}
