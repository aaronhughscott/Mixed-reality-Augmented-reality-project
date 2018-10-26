using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastManager : MonoBehaviour
{
    private GameObject raycastedObj;

    [Header("ray cast settings")]
    [SerializeField] private float rayLength = 10;
    [SerializeField] private LayerMask Newlayermask;

    [Header("references")]
    [SerializeField] private PlayerVitals playerVitals;
    [SerializeField] private Image crossHair;
    [SerializeField] private Text itemnameText;

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, Newlayermask.value))
        {
            if(hit.collider.CompareTag("Consumable"))
            {
                CrosshairActive();
                raycastedObj = hit.collider.gameObject;
                itemnameText.text = raycastedObj.GetComponent<Itemproperties>().itemName;

            if (Input.GetMouseButton(0))
                {
                    raycastedObj.GetComponent<Itemproperties>().Interaction();
                    //consume
                    raycastedObj.SetActive(false);
                }
            }
        }
        else
        {
            CrosshairNormal();
            itemnameText.text = null;

        }
    }
    void CrosshairActive()
    {
        crossHair.color = Color.red;
    }
    void CrosshairNormal()
    {
       crossHair.color = Color.white;
    }
}