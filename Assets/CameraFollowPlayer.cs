using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public int alma;
    [SerializeField] private Transform player;

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, player.transform.position.x, 0.05f),
                    Mathf.Lerp(transform.position.y, player.transform.position.y, 0.05f), -1);
    }
}
