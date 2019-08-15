using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    public GameObject defaultWallPrefab;
    public GameObject defaultFloorPrefab;

    public GameObject wallPrefab;
    private int default_x_max = 19;
    private int default_z_max = 19;
    private int default_y_max = 19;

    // Use this for initialization
    void Start()
    {
        //枠を作るメソッド呼び出し
        CreateMapWaku();

        CreateMapFloor();
    }

    /// <summary>
    /// 枠作成処理
    /// </summary>
    void CreateMapWaku()
    {
        //ループしながらz軸の上と下２列に枠を作ります
        for (int dx = 0; dx <= default_x_max; dx++)
        {
            Instantiate(defaultWallPrefab, new Vector3(dx, 0, 0), Quaternion.identity);
            Instantiate(defaultWallPrefab, new Vector3(dx, 0, default_z_max), Quaternion.identity);
        }

        //同じくx軸に右と左に枠を作ります
        for (int dz = 0; dz <= default_z_max; dz++)
        {
            Instantiate(defaultWallPrefab, new Vector3(0, 0, dz), Quaternion.identity);
            Instantiate(defaultWallPrefab, new Vector3(default_x_max, 0, dz), Quaternion.identity);
        }
    }


    /// <summary>
    /// 床作成処理
    /// </summary>
    private void CreateMapFloor()
    {
        //尚之案
        //for (float dy = -0.5f; dy <= default_y_max; dy++)
        //{
        //    Instantiate(defaultFloorPrefab, new Vector3(dy, 0, 0), Quaternion.identity);
        //    //Instantiate(defaultFloorPrefab, new Vector3(default_z_max, dy, 0), Quaternion.identity);
        //}


        for (int i = 0; i <= default_x_max; i++)
        {
            //Instantiate(defaultFloorPrefab, new Vector3(i, -1, 0), Quaternion.identity);
            Debug.Log(i + "番目");
            for (int j = 0; j <= default_z_max; j++)
            {
                Instantiate(defaultFloorPrefab, new Vector3(i, -1, j), Quaternion.identity);
                Debug.Log(j);
            }
        }


    }
}