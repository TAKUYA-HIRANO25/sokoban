using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    //完了までの時間
    private float timeTaken = 2.0f;
    //経過時間
    private float timeErapsed;
    //目的地
    private Vector3 destination;
    //出発地点
    private Vector3 origin;
    // Start is called before the first frame update
    void Start()
    {
        destination = transform.position;
        origin = destination;

    }
    //移動処理
    public void MoveTo(Vector3 newDestination)
    {
        timeErapsed = 0;
        origin = destination;
        transform.position = origin;
        destination = newDestination;
    }
    // Update is called once per frame
    void Update()
    {
        //目的地に着いたか判定
        if(origin == destination)
        {
            return;
        }
        //経過時間加算
        timeErapsed += Time.deltaTime;
        float timeRate = timeErapsed / timeTaken;
        if(timeRate > 1) { timeRate = 1; }
        //イージング用
        float easing = timeRate;
        Vector3 currentPosition = Vector3.Lerp(origin, destination, easing);
        transform.position = currentPosition;
    }
}
