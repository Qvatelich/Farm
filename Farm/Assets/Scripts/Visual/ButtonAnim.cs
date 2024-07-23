using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    public void Enter()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.localScale =new Vector3(1.15f,1.15f,1.15f);
    }

    public void Exit()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.localScale = Vector3.one;
    }
}
