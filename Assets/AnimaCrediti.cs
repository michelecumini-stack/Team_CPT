using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class AnimaCrediti : MonoBehaviour
{
    public RectTransform creditiTransform;

    private float startX;

    [Header("Animation Settings")]
    [SerializeField] private float startY = 0f;
    [SerializeField] private float endY = 90f;
    [SerializeField] private float velocita = 4f;
    [SerializeField] private AnimationCurve movementCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
    [SerializeField, Range(0, 1)] private float animationProgress = 0f;

    private bool isAnimating = false;

    private void Start()
    {
        startX = creditiTransform.anchoredPosition.x;
        animationProgress = 0f;
    }

    private void Update()
    {
        if (!isAnimating) return;

        float target = 1f;
        animationProgress = Mathf.MoveTowards(animationProgress, target, velocita * Time.deltaTime);

        ApplyRotation();

        if (!Mathf.Approximately(animationProgress, target)) return;

        isAnimating = false;
    }

    private void ApplyRotation()
    {
        if (creditiTransform == null) return;

        Debug.Log("Animare");
        float curveValue = movementCurve.Evaluate(animationProgress);
        float currentYPos = Mathf.Lerp(startY, endY, curveValue);
        Debug.Log("Devo applicare: "+startX + " "+ currentYPos);
        creditiTransform.transform.position = new Vector2(startX, currentYPos);
//        creditiTransform.anchoredPosition.Set(startX, currentYPos);
    }

    private void OnValidate()
    {
        startX = creditiTransform.anchoredPosition.x;
        ApplyRotation();
    }
}
