using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    // ENCAPSULATION
    public float Radius { get; private set; }

    // POLYMORPHISM
    public override float GetVolume()
    {
        return 4 / (3 * Mathf.PI * Mathf.Pow(Radius, 3));
    }
    // POLYMORPHISM
    private void Awake()
    {
        Name = nameof(Sphere);
    }
}
