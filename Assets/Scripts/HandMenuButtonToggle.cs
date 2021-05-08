using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;


public class HandMenuButtonToggle : MonoBehaviour
{
    [SerializeField]
    private GameObject targetObject;

    private bool isButtonActive = false;

    public ButtonConfigHelper ButtonHelper { get; set; }

    private void ToggleOthersOff()
    {
        var allToggles = FindObjectsOfType<HandMenuButtonToggle>();
        foreach (HandMenuButtonToggle handMenuToggle in allToggles)
        {
            if (handMenuToggle.ButtonHelper != ButtonHelper)
            {
                handMenuToggle.targetObject.SetActive(false);
            }
        }
    }

    private void OnEnable()
    {
       ButtonHelper = GetComponent<ButtonConfigHelper>();
       ButtonHelper.OnClick.AddListener(Toggle);
    }

    private void OnDisable()
    {
        ButtonHelper.OnClick.RemoveListener(Toggle);
    }

    public void Toggle()
    {
        if (targetObject != null)
        {
            isButtonActive = !isButtonActive;
            targetObject.SetActive(isButtonActive);
        }

        ToggleOthersOff();
    }
}
