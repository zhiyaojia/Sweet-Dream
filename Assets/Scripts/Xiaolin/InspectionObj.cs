using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionObj : MonoBehaviour
{
    public GameObject[] inspectionObjects;
    private int currIndex;

    //public void TurnOnInspection(int index)
    //{
    //    this.currIndex = index;
    //    inspectionObjects[index].SetActive(true);
    //}

    public void TurnOnInspection()
    {
        //this.currIndex = index;
        inspectionObjects[currIndex].SetActive(true);
    }

    public void TurnOffInspection()
    {
        inspectionObjects[currIndex].SetActive(false);
    }

    public int getCurrIndex()
    {
        return this.currIndex;
    }
    public void addCurrIndex()
    {
        this.currIndex++;
    }
    public void minusCurrIndex()
    {
        this.currIndex--;
    }
    public int getCount()
    {
        return inspectionObjects.Rank;
    }
    
}
