using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform BeamHit;
    private Beam beamScript;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        beamScript = gameObject.GetComponent<Beam>();
        lineRenderer.enabled = false;
        lineRenderer.useWorldSpace = true;
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {     
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
        Debug.DrawLine(transform.position, hit.point);
        BeamHit.position = hit.point;
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, BeamHit.position);
        

        //ineRenderer.enabled = false;

        /*
        if (Input.GetKey(KeyCode.Space))
        {
            lineRenderer.enabled = true;
        }
        else
        {
            lineRenderer.enabled = false;
        }
        */
    }

    IEnumerator Timer()
    {
        lineRenderer.enabled = false;
        beamScript.enabled = false;
        yield return new WaitForSecondsRealtime(2);
        lineRenderer.enabled = true;
        beamScript.enabled = true;
        yield return new WaitForSecondsRealtime(2);
        StartCoroutine(Timer());
    }

    
}
