using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CheckX : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Canvas GetCanvasStart;
    [SerializeField] Canvas GetCanvasBoardGame;

    public int checkTrueOrFalseX;

    public void OnPointerClick(PointerEventData eventData)
    {
        checkTrueOrFalseX = 1;
        GetCanvasStart.gameObject.SetActive(false);
        GetCanvasBoardGame.gameObject.SetActive(true);
    }

}
