using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    [SerializeField] Renderer[] backRenderres;
    [SerializeField] Renderer[] middleRenderers;
    [SerializeField] string sortingLayerName;
    int originOrder;
    // Start is called before the first frame update

    public void SetOriginOrder(int originOrader)
    {
        this.SetOriginOrder = originOrader;
        SetOrder(originOrder);
    }
    public void SetMOstFrontOrder(bool isMostFront)
    {
        SetMOstFrontOrder(isMostFront ? 100 : originOrder);
    }
   public void Strordar(int order)
    {
        int muOrder = order * 10;

        foreach (var renderer in backRenderres)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = muOrder;
        }

        foreach (var renderer in middleRenderers)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = muOrder + 1;
        }
    }

}
