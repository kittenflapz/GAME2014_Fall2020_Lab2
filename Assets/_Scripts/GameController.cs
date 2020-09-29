using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    private float livesLabelHalfWidth;
    private float livesLabelHalfHeight;
    private float scoreLabelHalfWidth;
    private float scoreLabelHalfHeight;

    private bool hasSafeArea = false;


    public static Rect RectTransformToScreenSpace(RectTransform transform)
    {
        Vector2 size = Vector2.Scale(transform.rect.size, transform.lossyScale);
        return new Rect((Vector2)transform.position - (size * 0.5f), size);
    }


    // Start is called before the first frame update
    void Start()
    {
        livesLabelHalfWidth = LivesLabel.rectTransform.rect.width * 0.5f;
        livesLabelHalfHeight = LivesLabel.rectTransform.rect.height * 0.5f;
        scoreLabelHalfWidth = ScoreLabel.rectTransform.rect.width * 0.5f;
        scoreLabelHalfHeight = ScoreLabel.rectTransform.rect.height * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        livesLabelHalfWidth = LivesLabel.rectTransform.rect.width * 0.5f;
        livesLabelHalfHeight = LivesLabel.rectTransform.rect.height * 0.5f;
        scoreLabelHalfWidth = ScoreLabel.rectTransform.rect.width * 0.5f;
        scoreLabelHalfHeight = ScoreLabel.rectTransform.rect.height * 0.5f;

        LivesLabel.rectTransform.position =
            new Vector2(Screen.safeArea.xMin + livesLabelHalfWidth, Screen.safeArea.yMax - livesLabelHalfHeight);


        ScoreLabel.rectTransform.position =
            new Vector2(Screen.safeArea.xMax - livesLabelHalfWidth, Screen.safeArea.yMax - livesLabelHalfHeight);


        /*
        hasSafeArea = (Screen.width == Screen.safeArea.width) && (Screen.height == Screen.safeArea.height) ? false : true;

        var positionOffset = Screen.safeArea.position * 0.5f;

        var widthDiff = Screen.width - Screen.safeArea.width;
        var heightDiff = Screen.height - Screen.safeArea.height;

        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -200.0f);
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -200.0f);
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -77.0f);
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -77.0f);
                }
                break;
            case ScreenOrientation.LandscapeLeft:
                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -83.0f);
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(353.0f, -83.0f);
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -38.0f);
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(353.0f, -38.0f);
                }
                break;
            case ScreenOrientation.LandscapeRight:
                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -83.0f);
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(-500.0f, -83.0f);
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -83.0f);
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(-500.0f, -83.0f);
                }
                break;
            case ScreenOrientation.Unknown:

                break;
            default:

                break;
        }
    }*/
    }
    }
