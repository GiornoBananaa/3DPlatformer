using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMaterial : MonoBehaviour
{

    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector2[] uv = mesh.uv;
        Color[] colors = new Color[uv.Length];

        for (var i = 0; i < uv.Length; i++)
            colors[i] = Color.Lerp(Color.red, Color.green, uv[i].x);

        mesh.colors = colors;
    }

}
