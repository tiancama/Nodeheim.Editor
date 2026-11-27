# Ubiquitous Language

Editor-owned terms. Engine terms: engine documentation <!-- TODO: link -->; do not redefine.

## Rules
- Never alone: "agent" (coding agent, AI agent; world agent, `Agent` in code), "position", "reference", "type".
- "node" alone = graph node (engine `Node`). Otherwise qualify: surface node, node view model.
- MVVM: model terms have no suffix; `XViewModel` represents X, `XView` shows it.
- Reserved, do not use: "world".
- Avoid: "edge" (→ connection), "entry" (→ surface node), "entity", "request" and "selection gesture" (→ intent).

## Roles
- domain: `Editor.Domain`; always the editor's domain.
- section mapper: `Editor.Persistence`; implements the engine's section mapper interface for editor sections.
- frontend: `Editor`; UI-framework-free view models and interaction logic.
- composition root: `Editor.Desktop`; wires all parts, hosts the views.

## Terms
- surface: the plane nodes are placed on. Holds one surface node per node ID: center (surface position) and optional radius overriding the default.
- canvas: view element showing the surface; views and README only.
- connection: displays the link between two nodes; no state besides its endpoints, no direction (ADR-0007).
- selection: the selected nodes; a connection counts as selected when both endpoints are (ADR-0007).
- intent: input forwarded to the interaction controller; a gesture (pointer-based, meaning depends on interaction state) or a command (discrete action).
- exclusive / toggle: press without / with Ctrl; replaces / toggles the selection. grab: press on a node or connection; may start a drag. Details: ADR-0008.
- owner `editor`, section `editor.surface`: `defaults/node/radius`; repeated `nodes/node` with `id`, `x`, `y`, optional `radius`.
