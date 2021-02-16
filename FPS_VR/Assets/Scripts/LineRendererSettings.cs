using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererSettings : MonoBehaviour
{
    [SerializeField] private LineRenderer rend;
    
    private Vector3[] points;

    public LayerMask layerMask;

    public Button btn;
    
    void Start()
    {
        rend = gameObject.GetComponent<LineRenderer>();
        points = new Vector3[2];
        
        points[0]=Vector3.zero;
        points[1] = transform.position + new Vector3(0, 0, 100);
        
        rend.SetPositions(points);
        rend.enabled = true;
    }

    public void AlignLineRenderer(LineRenderer rend)
    {
        Ray ray;
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, layerMask))
        {
            points[1] = transform.forward + new Vector3(0, 0, hit.distance);
            btn = hit.collider.gameObject.GetComponent<Button>();
        }
        else
        {
            points[1] = transform.forward + new Vector3(0, 0, 100);
        }
        
        rend.SetPositions(points);
    }

    public void SelectWeaponOnClick()
    {
        if (btn != null)
        {
            if (btn.name == "Gun")
            {
                Debug.Log("GUN");
            }
            else if (btn.name == "Katana")
            {
                Debug.Log("KATANA");
            }
        }
    }
    
    void Update()
    {
        AlignLineRenderer(rend);
    }
}
