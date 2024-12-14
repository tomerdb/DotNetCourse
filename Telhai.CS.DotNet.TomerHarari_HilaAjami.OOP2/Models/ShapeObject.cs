using System.Windows;

namespace Telhai.CS.DotNet.TomerHarari_HilaAjami.OOP2.Models;

/// <summary>
/// Represents an abstract base class for shape objects.
/// </summary>
public abstract class ShapeObject
{
    /// <summary>
    /// Gets the unique identifier of the shape.
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// Gets the type of the shape.
    /// </summary>
    public virtual string TypeShape => string.Empty;

    /// <summary>
    /// Gets or sets the name of the shape.
    /// </summary>
    public string? Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the X-coordinate of the shape.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the Y-coordinate of the shape.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Gets or sets the UI element representing the shape.
    /// </summary>
    public UIElement ShapeElement { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShapeObject"/> class with default coordinates.
    /// </summary>
    public ShapeObject() : this(0, 0)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShapeObject"/> class with specified coordinates.
    /// </summary>
    /// <param name="x">The X-coordinate of the shape.</param>
    /// <param name="y">The Y-coordinate of the shape.</param>
    protected ShapeObject(double x, double y)
    {
        Id = Guid.NewGuid().ToString().Substring(0, 8); // UNIQUE ID RANDOMLY
        X = x;
        Y = y;
    }

    /// <summary>
    /// Creates the shape as a UIElement.
    /// </summary>
    /// <returns>The created shape as a UIElement.</returns>
    public abstract UIElement CreateShape();

    /// <summary>
    /// Returns a string that represents the current shape object.
    /// </summary>
    /// <returns>A string that represents the current shape object.</returns>
    public override string ToString()
    {
        return $"{TypeShape}:{Id}:{Name}";
    }
}