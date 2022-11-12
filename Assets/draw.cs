using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw : MonoBehaviour
{
    LineRenderer _line;
    List<Vector3> _listPoint = new List<Vector3>();
    Vector2 oldMousePos = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        // Vector3[] listPos = new Vector3[5]
        // {
        //     new Vector3(0, 0),
        //         new Vector3(10, 10),
        //             new Vector3(10, 15),
        //                 new Vector3(20, 20),
        //                     new Vector3(20, 25),
        // };
        _line = this.GetComponent<LineRenderer>();
        // _line.positionCount = listPos.Length;
        // _line.SetPositions(listPos);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _listPoint.Clear();
        }
        if (!Input.GetMouseButton(0))
            return;

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(!oldMousePos.Equals(mousePos))
            {
                _listPoint.Add(mousePos);
                oldMousePos = mousePos;
            }
            _line.positionCount = _listPoint.Count;
            _line.SetPositions(_listPoint.ToArray());
    }
}
