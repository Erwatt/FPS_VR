using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererSettings : MonoBehaviour
{
    [SerializeField] private LineRenderer rend;

    private Vector3[] points;

    public LayerMask layerMask;

    public GameObject panel;
    public Image img;
    public Button btn;

    void Start()
    {
        rend = gameObject.GetComponent<LineRenderer>();
        points = new Vector3[2];
        
        points[0] = Vector3.zero;
        points[1] = transform.position + new Vector3(0, 0, 20);

        img = panel.GetComponent<Image>();
        
        rend.SetPositions(points);
        rend.enabled = true;
    }

    void Update()
    {
        if (AlignLineRenderer(rend) && Input.GetAxis("Submit") > 0)
        {
            btn.onClick.Invoke();
        }
        
    }

    public bool AlignLineRenderer(LineRenderer rend)
    {
        bool isHit = false;
        Ray ray;
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, layerMask))
        {
            btn = hit.collider.gameObject.GetComponent<Button>();
            points[1] = transform.forward + new Vector3(0, 0, hit.distance);
            rend.startColor = Color.red;
            rend.endColor = Color.red;
            isHit = true;
        }
        else
        {
            points[1] = transform.forward + new Vector3(0, 0, 20);
            rend.startColor = Color.green;
            rend.endColor = Color.green;
            isHit = false;
        }
        rend.SetPositions(points);
        rend.material.color = rend.startColor;
        return isHit;
    }

    public void ColorChangeOnClick()
    {
        if (btn != null)
        {
            if (btn.name == "red_btn")
            {
                img.color=Color.red;
            }
            else if (btn.name == "blue_btn")
            {
                img.color=Color.blue;
            }
            else if (btn.name == "green_btn")
            {
                img.color=Color.green;
            }
        }
    }
}
