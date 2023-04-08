using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float scroll;
    [SerializeField] private MeshRenderer mesh;
    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * scroll);
        mesh.material.mainTextureOffset = offset;
    }
}
