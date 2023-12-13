using System.Collections.Generic;
using UnityEngine;

public class SortingManager : MonoBehaviour
{
    public enum SortingType {Ascending, Descending };

    public static List<T> randomizeListOrder<T>(List<T> originalList)
    {
        List<T> templist = new List<T>();
        for (int i = 0; i < originalList.Count; i++)
        {
            templist.Add(originalList[i]);
        }

        List<T> toReturn = new List<T>();

        for (int i = 0; i < originalList.Count; i++)
        {
            int r = Random.Range(0, templist.Count);
            toReturn.Add(templist[r]);
            templist.Remove(templist[r]);
        }

        return toReturn;
    }

    public static List<Transform> sortTransformsByDistance(List<Transform> originalList, Transform distanceFrom, SortingType type)
    {
        List<Transform> templist = new List<Transform>();
        for (int i = 0; i < originalList.Count; i++)
        {
            templist.Add(originalList[i]);
        }

        List<Transform> toReturn = new List<Transform>();

        for (int i = 0; i < originalList.Count; i++)
        {
            Transform t = null;
            float distance = Mathf.Infinity;
            for (int j = 0; j < templist.Count;j++)
            {
                if(Vector3.Distance(templist[j].position,distanceFrom.position) < distance)
                {
                    distance = Vector3.Distance(templist[j].position, distanceFrom.position);
                    t = templist[j];
                }
            }
            toReturn.Add(t);
            templist.Remove(t);
        }

        if (type == SortingType.Descending)
            toReturn.Reverse();

        return toReturn;
    }

    public static List<float> SortNumbersList(List<float> originalList, SortingType type)
    {
        List<float> templist = new List<float>();
        for (int i = 0; i < originalList.Count; i++)
        {
            templist.Add(originalList[i]);
        }

        List<float> toReturn = new List<float>();

        for (int i = 0; i < originalList.Count; i++)
        {
            float smallestNumber = Mathf.Infinity;
            for (int j = 0; j < templist.Count; j++)
            {
                if (templist[j] < smallestNumber)
                {
                    smallestNumber = templist[j];
                }
            }
            toReturn.Add(smallestNumber);
            templist.Remove(smallestNumber);
        }

        if (type == SortingType.Descending)
            toReturn.Reverse();

        return toReturn;
    }

}
