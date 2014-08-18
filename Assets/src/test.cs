using UnityEngine;
using System.Collections;
//using FSharpUnityLibrary;

public class test : MonoBehaviour
{

    public Vector3[] newVertices;
    public Vector2[] newUV;
    public int[] newTriangles;
    public Mesh newMesh;

    // Use this for initialization
    void Start()
    {
        //var foo = Generator.GenerateVertices<T>(5000, Sin(Time));
        newMesh = new Mesh();
        GetComponent<MeshFilter>().mesh = newMesh;

        newMesh.vertices = GenerateNewVertices(1024);
        newMesh.uv = GenerateNewUV(newMesh.vertices.Length);
        newMesh.triangles = GenerateNewTriangles();
    }

    private Vector3[] GenerateNewVertices(int count)
    {
        return newVertices;
    }

    private Vector2[] GenerateNewUV(int count)
    {
        return newUV;
    }

    private int[] GenerateNewTriangles()
    {
        return newTriangles;
    }



    // Update is called once per frame
    void Update()
    {
        Mesh thisMesh = GetComponent<MeshFilter>().mesh;
        Vector3[] theseVertices = thisMesh.vertices;
        Vector3[] theseNormals = thisMesh.normals;
        int i = 0;
        while (i < theseVertices.Length)
        {
            theseVertices[i] += theseNormals[i] * Mathf.Sin(Time.time);
        }
        thisMesh.vertices = theseVertices;
    }
}
