using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRangeRandomPosition : MonoBehaviour
{

    [SerializeField] GameObject m_prefab;
    //[SerializeField] Transform rangeA;
    //[SerializeField] Transform rangeB;
    [SerializeField] float _createValue = 0;
    [SerializeField] float _createMaxValue = 3;

    // Start is called before the first frame update
    void Start()
    {
        //if (_createValue <= _createMaxValue)
        //{
        //    float x = Random.Range(rangeA.position.x, rangeB.position.x);
        //    // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        //    //float y = Random.Range(rangeA.position.y, rangeB.position.y);
        //    // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
        //    float z = Random.Range(rangeA.position.z, rangeB.position.z);

        //    // GameObjectを上記で決まったランダムな場所に生成
        //    Instantiate(m_prefab, new Vector3(x, 3, z), m_prefab.transform.rotation);

        //    _createValue += 1;
        //}
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_createValue < _createMaxValue)
        {
            float x = Random.Range(59f, -86f);
            float y = 2;
            float z = Random.Range(82f, -49f);
            Vector3 position = new Vector3(x, y, z);
            Instantiate(m_prefab, new Vector3(x, y, z), Quaternion.identity);

            _createValue += 1;
        }
    }
}
