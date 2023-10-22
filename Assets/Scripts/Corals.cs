using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corals : MonoBehaviour
{
    public static bool Overlap1D(float min1, float max1, float min2, float max2)
    {
        if (min2 <= max1 && max1 <= max2) { return true; }
        if (min1 <= max2 && max2 <= max1) { return true; }
        return false;
    }

    public static bool Overlap2D(
        float xMin1, float xMax1, float yMin1, float yMax1,
        float xMin2, float xMax2, float yMin2, float yMax2)
    {
        return Overlap1D(xMin1, xMax1, xMin2, xMax2) && Overlap1D(yMin1, yMax1, yMin2, yMax2);
    }

    public static bool Overlap2D(
        Vector2 position1, float width1, float height1,
        Vector2 position2, float width2, float height2)
    {
        float xMin1 = position1.x - width1 * 0.5f;
        float xMax1 = position1.x + width1 * 0.5f;
        float yMin1 = position1.y - height1 * 0.5f;
        float yMax1 = position1.y + height1 * 0.5f;

        float xMin2 = position2.x - width2 * 0.5f;
        float xMax2 = position2.x + width2 * 0.5f;
        float yMin2 = position2.y - height2 * 0.5f;
        float yMax2 = position2.y + height2 * 0.5f;

        return Overlap2D(xMin1, xMax1, yMin1, yMax1, xMin2, xMax2, yMin2, yMax2);
    }
}
