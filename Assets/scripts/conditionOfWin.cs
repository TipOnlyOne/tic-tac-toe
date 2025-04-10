using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class conditionOfWin : MonoBehaviour
{
    //реализовать бота через алгоритм с использование рандомайзера, количество цифр и будет сложностью бота
    public GameObject[] checkGameField;
    public string[] fullField;
    [SerializeField] TMP_Text title;
    [SerializeField] GameObject canvasWin;

    void Update()
    {
        Win();
    }

    public void Win()
    {
        if ((fullField[0] == fullField[4]) && (fullField[4] == fullField[8]))
        {
            if (fullField[0] == "X")
            {
                title.text = "Победили крестики";
                canvasWin.gameObject.SetActive(true);
            }
            else
            {
                title.text = "Победили кружки";
                canvasWin.gameObject.SetActive(true);
            }
        }
        else if ((fullField[1] == fullField[4]) && (fullField[4] == fullField[7]))
        {
            if (fullField[1] == "X")
            {
                title.text = "Победили крестики";
                canvasWin.gameObject.SetActive(true);
            }
            else
            {
                title.text = "Победили кружки";
                canvasWin.gameObject.SetActive(true);
            }
        }
        else if ((fullField[2] == fullField[4]) && (fullField[4] == fullField[6]))
        {
            if (fullField[2] == "X")
            {
                title.text = "Победили крестики";
                canvasWin.gameObject.SetActive(true);
            }
            else
            {
                title.text = "Победили кружки";
                canvasWin.gameObject.SetActive(true);
            }
        }
        else if ((fullField[3] == fullField[4]) && (fullField[4] == fullField[5]))
        {
            if (fullField[3] == "X")
            {
                title.text = "Победили крестики";
                canvasWin.gameObject.SetActive(true);
            }
            else
            {
                title.text = "Победили кружки";
                canvasWin.gameObject.SetActive(true);
            }
        }
        else if ((fullField[0] == fullField[1]) && (fullField[1] == fullField[2]))
        {
            if (fullField[0] == "X")
            {
                title.text = "Победили крестики";
                canvasWin.gameObject.SetActive(true);
            }
            else
            {
                title.text = "Победили кружки";
                canvasWin.gameObject.SetActive(true);
            }
        }
        else if ((fullField[6] == fullField[7]) && (fullField[7] == fullField[8]))
        {
            if (fullField[6] == "X")
            {
                title.text = "Победили крестики";
                canvasWin.gameObject.SetActive(true);
            }
            else
            {
                title.text = "Победили кружки";
                canvasWin.gameObject.SetActive(true);
            }
        }
        else if ((fullField[0] == fullField[3]) && (fullField[3] == fullField[6]))
        {
            if (fullField[0] == "X")
            {
                title.text = "Победили крестики";
                canvasWin.gameObject.SetActive(true);
            }
            else
            {
                title.text = "Победили кружки";
                canvasWin.gameObject.SetActive(true);
            }
        }
        else if ((fullField[2] == fullField[5]) && (fullField[5] == fullField[8]))
        {
            if (fullField[2] == "X")
            {
                title.text = "Победили крестики";
                canvasWin.gameObject.SetActive(true);
            }
            else
            {
                title.text = "Победили кружки";
                canvasWin.gameObject.SetActive(true);
            }
        }
    }
}
