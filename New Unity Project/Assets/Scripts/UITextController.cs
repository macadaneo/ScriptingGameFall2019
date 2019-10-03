using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UITextController : MonoBehaviour
{
    private Text textLabel;

    public void UpdateText(IntData data)
    {
        textLabel.text = data.value.ToString();
    }

    void Awake()
    {
        textLabel = GetComponent<Text>();
    }
}
