using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    public bool IsView;
    public float MouseX;
    public float Gap;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("View", 0, 0.02f);
        IsView = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Camera.main.ScreenToViewportPoint(Input.mousePosition).x > 0.3f && Camera.main.ScreenToViewportPoint(Input.mousePosition).x < 0.7f && Camera.main.ScreenToViewportPoint(Input.mousePosition).y > 0.2f && Camera.main.ScreenToViewportPoint(Input.mousePosition).y < 0.8f)
            {
                IsView = true;
                MouseX = Camera.main.ScreenToViewportPoint(Input.mousePosition).x;
            }
        }
        if (!Input.GetMouseButton(0))
        {
            IsView = false;
        }
    }

    void View()
    {
        if (IsView)
        {
            Gap = (MouseX - Camera.main.ScreenToViewportPoint(Input.mousePosition).x) * 1500;
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + Gap, transform.localEulerAngles.z);

            MouseX = Camera.main.ScreenToViewportPoint(Input.mousePosition).x;
        }
    }
}
