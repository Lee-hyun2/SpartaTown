using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform cam; // 카메라의 Transfrom을 참조합니다.

    Rigidbody2D rb;
    Vector2 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Cursor.lockState = CursorLockMode.Locked; // 마우스 커서를 잠금합니다.
    }

    private void FixedUpdate()
    {
        // 플레이어 이동 입력 처리
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // 이동 벡터 생성 (x와 y 방향으로 움직임)
        movement = new Vector2(moveHorizontal, moveVertical).normalized;

        // 플레이어 이동 및 회전 적용
        MovePlayer(movement);
    }

    void MovePlayer(Vector2 direction)
    {
        // 플레이어 이동
        Vector2 newPosition = rb.position + direction * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);

        // 캐릭터의 방향을 마우스 위치로 설정
        if (cam != null)
        {
            // 마우스 위치를 향해 캐릭터 방향 설정
            Vector2 mousePosition = Input.mousePosition;
            mousePosition = cam.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, cam.position.y - transform.position.y));

            // 캐릭터를 마우스 위치 기준으로 플립
            if (mousePosition.x > transform.position.x)
            {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z); // 오른쪽을 보도록 플립
            }
            else
            {
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z); // 왼쪽을 보도록 플립
            }
        }
    }

}