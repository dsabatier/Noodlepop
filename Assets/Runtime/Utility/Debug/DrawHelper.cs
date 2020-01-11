using UnityEngine;

/// <summary>
/// To help debug drawing things I wish Unity already did for me :)
/// </summary>
public class DrawHelper
{
    /// <summary>
    /// Draws a box of the specified size at the specified point in world space
    /// </summary>
    /// <param name="center">Center of the box in world space</param>
    /// <param name="size">Size of the box</param>
    /// <param name="color">Color of the box outline</param>
    /// <param name="duration">How long the box should be visible for</param>
    /// <param name="depthTest">Should the box be obscured by objects closer to the camera?</param>
    public static void DrawBox(Vector2 center, Vector2 size, Color color, float duration, bool depthTest)
    {
        Vector2 top = Vector2.up * size * 0.5f;
        Vector2 bottom = Vector2.down * size * 0.5f;
        Vector2 left = Vector2.left * size * 0.5f;
        Vector2 right = Vector2.right * size * 0.5f;
        
        Vector2 topLeft = center + top + left;
        Vector2 topRight = center + top + right;
        Vector2 bottomLeft = center + bottom + left;
        Vector2 bottomRight = center + bottom + right;
        
        Debug.DrawLine(topLeft, topRight, color, duration, depthTest);
        Debug.DrawLine(topRight, bottomRight, color, duration, depthTest);
        Debug.DrawLine(bottomRight, bottomLeft, color, duration, depthTest);
        Debug.DrawLine(bottomLeft, topLeft, color, duration, depthTest);
    }

    /// <summary>
    /// Draws a box of the specified size at the specified point in world space
    /// </summary>
    /// <param name="center">Center of the box in world space</param>
    /// <param name="size">Size of the box</param>
    /// <param name="color">Color of the box outline</param>
    /// <param name="duration">How long the box should be visible for</param>
    public static void DrawBox(Vector2 center, Vector2 size)
    {
        DrawBox(center, size, Color.white, 0.0f, false);
    }
    
    /// <summary>
    /// Draws a box of the specified size at the specified point in world space
    /// </summary>
    /// <param name="center">Center of the box in world space</param>
    /// <param name="size">Size of the box</param>
    /// <param name="color">Color of the box outline</param>
    /// <param name="duration">How long the box should be visible for</param>
    public static void DrawBox(Vector2 center, Vector2 size, Color color)
    {
        DrawBox(center, size, color, 0.0f, false);
    }
    
    /// <summary>
    /// Draws a box of the specified size at the specified point in world space
    /// </summary>
    /// <param name="center">Center of the box in world space</param>
    /// <param name="size">Size of the box</param>
    /// <param name="color">Color of the box outline</param>
    /// <param name="duration">How long the box should be visible for</param>
    public static void DrawBox(Vector2 center, Vector2 size, Color color, float duration)
    {
        DrawBox(center, size, color, duration, false);
    }
    
}
