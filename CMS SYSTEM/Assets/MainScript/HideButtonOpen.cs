using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButtonOpen : MonoBehaviour
{
   public GameObject HideInfoImage;

    public void HideBtnClik()
    {
        HideInfoImage.SetActive(true);
    }

    public void BackClik()
    {
        HideInfoImage.SetActive(false);
    }
}
