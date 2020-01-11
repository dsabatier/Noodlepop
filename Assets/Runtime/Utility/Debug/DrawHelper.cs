using UnityEngine;

public class DrawHelper
{
    public static void DrawBox(Vector2 center, Vector2 size, Color color, float time)
    {
        Vector2 top = Vector2.up * size * 0.5f;
        Vector2 bottom = Vector2.down * size * 0.5f;
        Vector2 left = Vector2.left * size * 0.5f;
        Vector2 right = Vector2.right * size * 0.5f;
        
        Vector2 topLeft = center + top + left;
        Vector2 topRight = center + top + right;
        Vector2 bottomLeft = center + bottom + left;
        Vector2 bottomRight = center + bottom + right;
        
        Debug.DrawLine(topLeft, topRight, color, time);
        Debug.DrawLine(topRight, bottomRight, color, time);
        Debug.DrawLine(bottomRight, bottomLeft, color, time);
        Debug.DrawLine(bottomLeft, topLeft, color, time);
    }
}
