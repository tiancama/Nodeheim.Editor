using Nodeheim.Editor.Domain;
using Nodeheim.Persistence.Documents;

namespace Nodeheim.Editor.Persistence;

/// <summary>
/// Provides the owner <c>editor</c> and the section mappers of its sections.
/// </summary>
public static class EditorSections
{
    /// <summary>
    /// Gets the name of the owner <c>editor</c>.
    /// </summary>
    public const string Owner = "editor";

    /// <summary>
    /// Gets the section mapper of <c>editor.surface</c>.
    /// </summary>
    public static ISectionMapper<Surface> Surface { get; } = new SurfaceSectionMapper();
}
