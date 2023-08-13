using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    // ENCAPSULATION
    public float Radius { get; private set; }
    public float Height { get; private set; }

    // POLYMORPHISM
    public override float GetVolume()
    {
        return Mathf.PI * Mathf.Pow(Radius, 2) * Height;
    }
    // POLYMORPHISM
    private void Awake()
    {
        Name = nameof(Cylinder);
    }
}
