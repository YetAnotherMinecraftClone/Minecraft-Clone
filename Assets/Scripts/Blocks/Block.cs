using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    // This (and inherited) classes won't belong to a specific GameObject, they should be considered as helpers since a Chunk is actually a Mesh
    // You are expected to base your blocks off of this class and are meant to add functionality on top of them
    Vector3 pos;
    BlockType type;
    
    //Left Click Interaction
    public virtual void leftClick() {
        //To-Do: break block
    }

    //Right Click Interaction
    public virtual void rightClick() {
        //To-Do: place block
    }
}
