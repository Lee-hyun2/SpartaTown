using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ImagePanelClickHandler : MonoBehaviour, IPointerClickHandler
{
    public string MainScene; // ���� ȭ���� �� �̸�

    public void OnPointerClick(PointerEventData eventData)
    {
        // �̹��� �ǳ��� Ŭ���Ǿ��� �� ���� ȭ������ �� ��ȯ
        SceneManager.LoadScene(MainScene);
    }
}
