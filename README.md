# Nodeheim Editor

A desktop editor for graphs built on the [Nodeheim](https://github.com/tiancama/Nodeheim) engine.

![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-14-239120?logo=csharp&logoColor=white)
![Status](https://img.shields.io/badge/status-early%20development-orange)
![License](https://img.shields.io/badge/license-MIT-blue)

## Overview

The editor lets you create nodes on a canvas, connect them, and save the result as a document. The graph itself and the loading and saving of documents come from the Nodeheim engine; the editor adds the surface on which nodes are placed and the user interface.

## Project structure

```
Nodeheim.Editor/
└── src/
    ├── Nodeheim.Editor.Domain/       # domain: surface and node positions
    ├── Nodeheim.Editor.Persistence/  # section mapper: surface in documents
    ├── Nodeheim.Editor/              # frontend: framework-free view models
    └── Nodeheim.Editor.Desktop/      # composition root and Avalonia views
```

## Getting started

Prerequisites: the [.NET 10 SDK](https://dotnet.microsoft.com/download).

The editor references the engine projects directly. Clone both repositories into the same parent folder:

```bash
git clone https://github.com/tiancama/Nodeheim.git
git clone https://github.com/tiancama/Nodeheim.Editor.git
cd Nodeheim.Editor

# build the solution
dotnet build

# run the editor
dotnet run --project src/Nodeheim.Editor.Desktop
```

The path to the engine is set by `EngineRoot` in `Directory.Build.props`.

## Using the editor

| Action | Input |
|---|---|
| Create a node | Double-click on the canvas |
| Select a node or connection | Click |
| Add to or remove from selection | Ctrl+Click |
| Clear selection | Click on empty canvas |
| Move selection | Drag |
| Connect selected nodes | `C` |
| Disconnect selected nodes | `D` |
| Delete selected nodes | `Delete` |

Clicking a connection selects both of its endpoints; dragging it moves both.

## Tech stack

- **Language / runtime:** C# 14 on .NET 10 (LTS)
- **UI:** Avalonia (MVVM), cross-platform
- **Engine:** Nodeheim, referenced as source projects

## Status

Early development. The editor supports creating, selecting, moving, connecting, disconnecting, and deleting nodes. Documents can be loaded and saved as JSON and XML, including node positions. The API is expected to change.

This is primarily a personal learning project; issues and feedback are welcome.

## How this project is built

The Nodeheim Editor is developed through AI pair programming. AI is a tool here, not the author: I set the direction, make the design decisions, and review every change that goes into the code, whether I typed it or an assistant suggested it.

## License

The Nodeheim Editor is released under the MIT License. See [`LICENSE`](LICENSE) for details.