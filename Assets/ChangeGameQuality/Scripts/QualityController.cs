using UnityEngine;
using UnityEngine.UI;

public class QualityController : MonoBehaviour
{
    public Dropdown dropdownQuality;
    private void Awake()
    {
        if (PlayerPrefs.HasKey("QualityPreference"))
        {
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("QualityPreference"));
            dropdownQuality.value = PlayerPrefs.GetInt("QualityPreference");
        }
        else
        {
            dropdownQuality.value = QualitySettings.GetQualityLevel();
        }
    }
    public void QualityChange(int qualityPreference)
    {
        QualitySettings.SetQualityLevel(qualityPreference);
        PlayerPrefs.SetInt("QualityPreference", qualityPreference);
    }
}