using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameInputHandler : MonoBehaviour
{
    public InputField nameInputField;
    public GameObject CharacterSelectionPanel; // 캐릭터 선택을 위한 판넬

    public void OnJoinButtonClicked()
    {
        string playerName = nameInputField.text;
        if (!string.IsNullOrEmpty(playerName) && playerName.Length >= 2 && playerName.Length <= 10)
        {
            // 이름을 씬 전환을 위해 저장
            PlayerPrefs.SetString("PlayerName", playerName);

            // 캐릭터 선택을 위한 판넬을 활성화
            CharacterSelectionPanel.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Player name should be between 2 and 10 characters!");
        }
    }
}
