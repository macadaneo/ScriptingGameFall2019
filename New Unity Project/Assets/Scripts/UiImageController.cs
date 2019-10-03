using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class UiImageController : MonoBehaviour
{

    private Image img;
    
    public void Awake()
    {
        img = GetComponent<Image>();
    }

    public void UpdateImage(FloatData data)
    {
        img.fillAmount = data.value;
    }
    
}
