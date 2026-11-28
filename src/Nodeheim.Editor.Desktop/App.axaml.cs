using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Nodeheim.Editor.Persistence;
using Nodeheim.Persistence;
using Nodeheim.Persistence.Files;
using Nodeheim.Persistence.Json;
using Nodeheim.Persistence.Xml;

namespace Nodeheim.Editor.Desktop;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            IDocumentRepository documentRepository = new DocumentRepositoryBuilder()
                .AddFormat(JsonFormat.Value)
                .AddFormat(XmlFormat.Value)
                .UseStorage(FileStorage.Value)
                .AddEngine()
                .AddSectionMapper(EditorSections.Owner, EditorSections.Surface)
                .Build();
            ShellViewModel shell = new(documentRepository);
            desktop.MainWindow = new MainWindow() { DataContext = shell };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
