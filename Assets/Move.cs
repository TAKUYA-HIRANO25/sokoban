using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    //�����܂ł̎���
    private float timeTaken = 2.0f;
    //�o�ߎ���
    private float timeErapsed;
    //�ړI�n
    private Vector3 destination;
    //�o���n�_
    private Vector3 origin;
    // Start is called before the first frame update
    void Start()
    {
        destination = transform.position;
        origin = destination;

    }
    //�ړ�����
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
        //�ړI�n�ɒ�����������
        if(origin == destination)
        {
            return;
        }
        //�o�ߎ��ԉ��Z
        timeErapsed += Time.deltaTime;
        float timeRate = timeErapsed / timeTaken;
        if(timeRate > 1) { timeRate = 1; }
        //�C�[�W���O�p
        float easing = timeRate;
        Vector3 currentPosition = Vector3.Lerp(origin, destination, easing);
        transform.position = currentPosition;
    }
}
