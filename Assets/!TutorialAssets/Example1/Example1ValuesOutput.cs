using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Example1ValuesOutput : MonoBehaviour
{
    public TextMeshProUGUI GameTimeText;
    public TextMeshProUGUI SinTimeText;
    public TextMeshProUGUI LocalPositionText;

    void Update()
    {
        GameTimeText.text = $"gameTime = {Time.time:N2}";
        SinTimeText.text = $"sinTime = {Mathf.Sin(Time.time):N2}";
        LocalPositionText.text = $"transform.localPosition = new Vector3(0, {Mathf.Sin(Time.time):N2}, 0)";
    }
}
