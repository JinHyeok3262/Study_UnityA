using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab;// 팝업 프리팹 변수
    public Transform canvasTransform; // 캔버스 트랜스폼 변수
    public string TitleText; // 팝업 제목 변수
    public string ContentText; // 팝업 내용 변수

    public void OpenNoticePopup()
    {
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform); // 생성한 팝업 변수
        Popup popupScript = newPopup.GetComponent<Popup>(); // 팝업 스크립트 변수

        popupScript.SetContent(this.TitleText, this.ContentText); // 팝업 내용 설정
    }
}