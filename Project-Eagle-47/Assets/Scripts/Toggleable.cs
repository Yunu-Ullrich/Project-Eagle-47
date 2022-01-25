using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Toggleable
{
    void Update();
}
class ImplementationClass : Toggleable
{
    // Explicit interface member implementation:
    void Toggleable.Update()
    {
        // Method implementation.
    }

    static void Main()
    {
        // Declare an interface instance.
        Toggleable obj = new ImplementationClass();

        // Call the member.
        obj.Update();
    }
}
