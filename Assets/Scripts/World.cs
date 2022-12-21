using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class World : MonoBehaviour
{
    public int maxX;
    public int maxY;
    public int maxZ;
    Mesh mesh;
    Vector3[] vertexArray;
    int[] triangles;
    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    void Generate() {
        //To-Do: Generate World using Chunks.
        CreateGrid();
        UpdateMesh(vertexArray, triangles);
    }

    void UpdateMesh(Vector3[] vertexes, int[] tris) {
        mesh.Clear();
        mesh.vertices = vertexes;
        mesh.triangles = tris;
        mesh.RecalculateNormals();
        
    }
    void CreateGrid(){
        //To-Do: Generate in the Y dimension
        vertexArray = new Vector3[(maxX +1) * (maxZ + 1)];
        for (int i = 0, z = 0; z <= maxZ; z++) {
            for (int x = 0; x <= maxX; x++) {
                vertexArray[i] = new Vector3(x, 0, z);
                i++;
            }
        }
        int vert = 0;
        int tris = 0;
        triangles = new int[maxX * maxZ * 6];
        for (int z = 0; z < maxZ; z++){
            for (int x = 0; x < maxX; x++) {
                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + maxX + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + maxX + 1;
                triangles[tris + 5] = vert + maxX + 2;
                vert++;
                tris += 6;
            }
            vert++;
        }

    }
}
