using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public string Name { get; protected set; }

    private void OnMouseDown()
    {
        PrintName();
    }
    public void PrintName()
    {
        Debug.Log($"I'm a {Name}!", this);
    }

    // ABSTRACTION
    public abstract float GetVolume();
}
