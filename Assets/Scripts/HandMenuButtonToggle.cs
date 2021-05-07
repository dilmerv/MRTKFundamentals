using UnityEngine;

public class HandMenuButtonToggle : MonoBehaviour
{
    [SerializeField]
    private GameObject targetObject;

    private bool isButtonActive = false;

    public void Toggle()
    {
        isButtonActive = !isButtonActive;

        if (targetObject != null)
        {
            targetObject.SetActive(isButtonActive);
        }
    }
}
