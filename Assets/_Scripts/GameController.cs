using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                
                break;
            case DeviceOrientation.LandscapeLeft:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -38.0f);
                LivesLabel.rectTransform.anchoredPosition = new Vector2(353.0f, -38.0f);
                break;
            case DeviceOrientation.LandscapeRight:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -83.0f);
                LivesLabel.rectTransform.anchoredPosition = new Vector2(-500.0f, -83.0f);
                break;
            case DeviceOrientation.Unknown:
                
                break;
            default:
                
                break;
        }
        
    }
}
