using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoTweenToggle : MonoBehaviour
{
    public RectTransform handle;   // The circular knob
    public Image background;       // The background (oval shape)
    public Color onColor = new Color(0.2f, 0.5f, 1f);  // Active state color
    public Color offColor = new Color(0.8f, 0.8f, 0.8f); // Inactive state color
    public float toggleDuration = 0.3f; // Animation duration

    private Toggle toggle;
    private Vector2 offPosition;
    private Vector2 onPosition;
    void Start()
    {
        toggle = GetComponent<Toggle>();

        // Calculate knob positions
        offPosition = handle.anchoredPosition;
        onPosition = new Vector2(-offPosition.x, offPosition.y);

        // Add listener to the toggle
        toggle.onValueChanged.AddListener(OnToggleChanged);

        // Initialize the toggle state
        UpdateToggle(toggle.isOn, true);
    }

    void OnToggleChanged(bool isOn)
    {
        UpdateToggle(isOn, false);
    }

    void UpdateToggle(bool isOn, bool instant)
    {
        // Animate background color
        background.DOColor(isOn ? onColor : offColor, toggleDuration);

        // Animate the knob position
        Vector2 targetPosition = isOn ? onPosition : offPosition;

        if (instant)
        {
            handle.anchoredPosition = targetPosition;
        }
        else
        {
            handle.DOAnchorPos(targetPosition, toggleDuration).SetEase(Ease.OutQuad);
        }
    }
}
