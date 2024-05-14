using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ImagePanelClickHandler : MonoBehaviour, IPointerClickHandler
{
    public string MainScene; // 메인 화면의 씬 이름

    public void OnPointerClick(PointerEventData eventData)
    {
        // 이미지 판넬이 클릭되었을 때 메인 화면으로 씬 전환
        SceneManager.LoadScene(MainScene);
    }
}
