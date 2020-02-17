using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMoviment : MonoBehaviour
{
    public GameObject player;
    public GameObject renderfog;
    public GameObject camfog;
    public float dst;
    public float dst2,offsetx,offsetz;
    void Update()
     {
    
        transform.position = new Vector3(player.transform.position.x, dst, player.transform.position.z);
        renderfog.transform.position = new Vector3(player.transform.position.x + offsetx, dst2, player.transform.position.z + offsetz);
        camfog.transform.position = new Vector3(player.transform.position.x + offsetx, dst2, player.transform.position.z + offsetz);
        renderfog.transform.rotation =  Quaternion.Euler(90, player.transform.position.y, 0);
    }

}
