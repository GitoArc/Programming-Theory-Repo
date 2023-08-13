using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    // ENCAPSULATION
    public float EdgeLength { get; private set; }

    // POLYMORPHISM
    public override float GetVolume()
    {
        return Mathf.Pow(EdgeLength, 3);
    }
    // POLYMORPHISM
    private void Awake()
    {
        Name = nameof(Cube);
    }
}
