using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private Vector3 pos;//摄像机移动的位置
    [SerializeField]
    private Camera mainCamera;//摄像机
    [SerializeField]
    private GameObject player,associatedPortal;//玩家和相关联的传送门
    [SerializeField]
    private bool canGo = false;//是否可以传送
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
            canGo = true;   
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canGo = false;
    }
    private void MovePlayer()
    {
        player.transform.position = associatedPortal.transform.position;
    }
    private void MoveCamera()
    {
        mainCamera.transform.position = pos;
    }

    public void PortalTo()
    {
        if(canGo)
        {
            MoveCamera();
            MovePlayer();
        }
    }
}
