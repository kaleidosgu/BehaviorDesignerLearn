using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGizmos : MonoBehaviour {
    public float LengthOfGizmos;
    public LayerMask RelatedLayerMask;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Vector3 vecDst = transform.right.normalized * LengthOfGizmos + transform.position;
        Gizmos.DrawLine(transform.position, vecDst);

        RaycastHit raycastHit;
        bool bRes = Physics.Raycast(transform.position, transform.right, out raycastHit, LengthOfGizmos, (int)RelatedLayerMask);
        if (bRes == true)
        {
            int a = 0;
        }
    }
}
