using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class chageBoxes : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Image origImg;

    [SerializeField] GameObject CheckX;
    [SerializeField] GameObject CheckO;

    [SerializeField] Sprite imageX;
    [SerializeField] Sprite imageTick;


    public void OnPointerClick(PointerEventData eventData)
    {
        if (CheckX.GetComponent<CheckX>().checkTrueOrFalseX == 1)
        {
            Debug.Log("Õ");
            CheckO.GetComponent<CheckO>().checkTrueOrFalseO = 0;
            CheckX.GetComponent<CheckX>().checkTrueOrFalseX = 0;
            origImg.sprite = imageX;
        }
        else if (CheckO.GetComponent<CheckO>().checkTrueOrFalseO == 0)
        {
            Debug.Log("Î");
            CheckX.GetComponent<CheckX>().checkTrueOrFalseX = 1;
            CheckO.GetComponent<CheckO>().checkTrueOrFalseO = 1;
            origImg.sprite = imageTick;
        }
    }

}
