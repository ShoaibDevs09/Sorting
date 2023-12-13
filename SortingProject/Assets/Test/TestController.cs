using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestController : MonoBehaviour
{
    public List<Image> ImagesRandomSort;
    public List<Color> ColorsRandomSort;
    public List<float> numbersToSort;
    public SortingManager.SortingType numbersSorttype;
    public List<Text> numbersToSortText;
    public List<Transform> transformsToSort;
    public Transform transformToSortTarget;
    public SortingManager.SortingType transformSorttype;


    private void Start()
    {
        for (int i = 0; i < ImagesRandomSort.Count; i++)
        {
            ImagesRandomSort[i].color = ColorsRandomSort[i];
        }

        for (int i = 0; i < numbersToSort.Count; i++)
        {
            numbersToSortText[i].text = numbersToSort[i].ToString();
        }

        for (int i = 0; i < transformsToSort.Count; i++)
        {
            transformsToSort[i].GetComponentInChildren<Text>().text = i.ToString();
        }
    }

    public void randomizeListOrder()
    {
        ImagesRandomSort = SortingManager.randomizeListOrder(ImagesRandomSort);
        for (int i = 0; i < ImagesRandomSort.Count; i++)
        {
            ImagesRandomSort[i].color = ColorsRandomSort[i];
        }
    }

    public void SortNumbers()
    {
        numbersToSort = SortingManager.SortNumbersList(numbersToSort, numbersSorttype);
        for (int i = 0; i < numbersToSort.Count; i++)
        {
            numbersToSortText[i].text = numbersToSort[i].ToString();
        }
    }

    public void SortByDistance()
    {
        transformsToSort = SortingManager.sortTransformsByDistance(transformsToSort,transformToSortTarget, transformSorttype);
        for (int i = 0; i < transformsToSort.Count; i++)
        {
            transformsToSort[i].GetComponentInChildren<Text>().text = i.ToString();
        }
    }
}
