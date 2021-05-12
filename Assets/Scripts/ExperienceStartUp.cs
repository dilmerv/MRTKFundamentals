using UnityEngine;

public class ExperienceStartUp : MonoBehaviour
{
    [SerializeField]
    private Transform environmentTransform;

    void Awake()
    {
        // make sure to hide all environment components by default
        foreach (Transform transform in environmentTransform)
        {
            transform.gameObject.SetActive(false);
        }
    }
}
