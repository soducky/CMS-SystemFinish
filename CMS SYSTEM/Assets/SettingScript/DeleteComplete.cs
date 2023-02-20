using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteComplete : MonoBehaviour // 삭제 완료 메세지 클래스 
{
    public GameObject DeleteCompleteText; //삭제완료메세지 

    public void EnterAddMode2()
    {
        GameObject.FindWithTag("DeleteButton").GetComponent<DeleteButton>().DeleteButtonClik();
        // 삭제완료 메세지 누르면 Deletebutton 누르는 것과 동일한 동작
    }

    public void DeleteCompleteMethod()
    {
        DeleteCompleteText.SetActive(false);
        //  기존모드로 돌아갔으면 안내메세지는 비활성화
    }
}
