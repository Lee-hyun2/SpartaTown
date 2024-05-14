using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameInputHandler : MonoBehaviour
{
    public InputField nameInputField;
    public GameObject CharacterSelectionPanel; // ĳ���� ������ ���� �ǳ�

    public void OnJoinButtonClicked()
    {
        string playerName = nameInputField.text;
        if (!string.IsNullOrEmpty(playerName) && playerName.Length >= 2 && playerName.Length <= 10)
        {
            // �̸��� �� ��ȯ�� ���� ����
            PlayerPrefs.SetString("PlayerName", playerName);

            // ĳ���� ������ ���� �ǳ��� Ȱ��ȭ
            CharacterSelectionPanel.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Player name should be between 2 and 10 characters!");
        }
    }
}
