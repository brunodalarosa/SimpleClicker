﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ShopOpenScript : MonoBehaviour, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler {
    public MainScript main_script;  //Our main script
    public GameObject shop_panel;   //The shop panel

    //When the object is created
    void Start() {
        this.gameObject.SetActive(false);
    }

    //Called when the pointer makes a click (just down)
    public void OnPointerDown(PointerEventData pointer_data) {
        this.GetComponent<Image>().color = new Color(this.GetComponent<Image>().color.r, this.GetComponent<Image>().color.g, this.GetComponent<Image>().color.b, 0.5f);
    }

    //Function fired when a click (up and down) event happens
    public void OnPointerClick(PointerEventData pointer_data) {
        main_script.attShop();
        shop_panel.SetActive(true);
    }

    //Called when the pointer "ends" the click (realeses the button)
    public void OnPointerUp(PointerEventData pointer_data) {
        this.GetComponent<Image>().color = new Color(this.GetComponent<Image>().color.r, this.GetComponent<Image>().color.g, this.GetComponent<Image>().color.b, 1f);
    }

}