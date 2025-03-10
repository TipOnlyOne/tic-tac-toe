using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CheckO : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Canvas GetCanvasStart;
    [SerializeField] Canvas GetCanvasBoardGame;

    public int checkTrueOrFalseO;

    public void OnPointerClick(PointerEventData eventData)
    {
        checkTrueOrFalseO = 0;
        GetCanvasStart.gameObject.SetActive(false);
        GetCanvasBoardGame.gameObject.SetActive(true);
    }

}
