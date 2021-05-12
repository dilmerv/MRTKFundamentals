using UnityEngine;

public class ExperienceStartUp : MonoBehaviour
{
    [SerializeField]
    private Transform environmentTransform;

    [SerializeField]
    private Transform handTransforms;

    void Awake()
    {
        HideAll(environmentTransform);

        HideAll(handTransforms);
    }

    private void HideAll(Transform transformToHide)
    {
        // make sure to hide all environment components by default
        foreach (Transform transform in transformToHide)
        {
            transform.gameObject.SetActive(false);
        }
    }
}
